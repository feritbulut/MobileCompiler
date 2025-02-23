namespace MyCompiler;

public partial class CsharpPage : ContentPage
{
	public CsharpPage()
	{
		InitializeComponent();
	}

    private async void OpenCsTutorial(object sender, TappedEventArgs e)
    {
        await Launcher.OpenAsync("https://docs.microsoft.com/en-us/dotnet/csharp/");
    }

    private async void OpenCodecademyCs(object sender, TappedEventArgs e)
    {
        await Launcher.OpenAsync("https://csharp-station.com");
    }

    private async void OpenGeeksForGeeksCs(object sender, TappedEventArgs e)
    {
        await Launcher.OpenAsync("https://www.geeksforgeeks.org/csharp-programming-language/");
    }

    private async void OpenW3SchoolsCs(object sender, TappedEventArgs e)
    {
        await Launcher.OpenAsync("https://www.w3schools.com/cs/");
    }
}