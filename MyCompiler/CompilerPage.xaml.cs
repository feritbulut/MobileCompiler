using System;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace MyCompiler;

public partial class CompilerPage : ContentPage
{
    private string selectedLanguage;

    public CompilerPage(string language)
    {
        InitializeComponent();
        selectedLanguage = language;
        languageLabel.Text = $"chosen language: {selectedLanguage}";
        if (selectedLanguage == "C++")
        {
            LanguageImage.Source = "c.png";
        }
        else if(selectedLanguage == "C#")
        {
            LanguageImage.Source = "csharp.png";
        }
        else {
            LanguageImage.Source = $"{selectedLanguage.ToLower()}.png";
        }

        
    }

    private async void OnRunClicked(object sender, EventArgs e)
    {
        string code = codeEditor.Text;
        if (string.IsNullOrWhiteSpace(code))
        {
            await DisplayAlert("Error", "Code field is empty!", "OK");
            return;
        }

        string output = await CompileCode(selectedLanguage, code);
        outputLabel.Text = output;
    }

    private async Task<string> CompileCode(string language, string code)
    {
        var client = new HttpClient();
        var requestData = new
        {
            clientId = "68b7873e76a37258c2aea465fe3e63f9",
            clientSecret = "b94390c88550fe38bf184d75c531b5de9e9176dd54b4c47e9b0f9c388840e292",
            script = code,
            stdin = "",
            language = GetLanguageKey(language),
            versionIndex = "0",
            compileOnly = false
        };

        var jsonContent = new StringContent(JsonConvert.SerializeObject(requestData), Encoding.UTF8, "application/json");
        var response = await client.PostAsync("https://api.jdoodle.com/v1/execute", jsonContent);
        var responseString = await response.Content.ReadAsStringAsync();

        var jsonResponse = JsonConvert.DeserializeObject<dynamic>(responseString);
        return jsonResponse.output ?? "Error!";
    }

    private string GetLanguageKey(string language)
    {
        return language switch
        {
            "Python" => "python3",
            "C#" => "csharp",
            "C++" => "cpp17",
            "Java" => "java",
            _ => "python3"
        };
    }
}