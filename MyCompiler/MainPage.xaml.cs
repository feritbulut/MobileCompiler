using System.Collections.ObjectModel;
using System.Diagnostics;
using Microsoft.Maui.Controls;

namespace MyCompiler
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();

            Title = string.Empty;
        }

        private async void GoToJavaPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new JavaPage());
        }

        private async void OnLanguageSelected(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                string selectedLanguage = button.Text;
                await Navigation.PushAsync(new CompilerPage(selectedLanguage));
            }
        }

        private async void GoToCppPage(object sender, TappedEventArgs e)
        {
            await Navigation.PushAsync(new CppPage());
        }

        private async void GoToCsharpPage(object sender, TappedEventArgs e)
        {
            await Navigation.PushAsync(new CsharpPage());
        }

        private async void GoToPythonPage(object sender, TappedEventArgs e)
        {
            await Navigation.PushAsync(new PythonPage());
        }
    }

}