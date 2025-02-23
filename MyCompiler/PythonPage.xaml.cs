namespace MyCompiler;

public partial class PythonPage : ContentPage
{
	public PythonPage()
	{
		InitializeComponent();
	}

    private async void OpenPythonOrg(object sender, TappedEventArgs e)
    {
        await Launcher.OpenAsync("https://www.python.org/");
    }

    private async void OpenRealPython(object sender, TappedEventArgs e)
    {
        await Launcher.OpenAsync("https://realpython.com/");
    }

    private async void OpenGeeksforGeeksPython(object sender, TappedEventArgs e)
    {
        await Launcher.OpenAsync("https://www.geeksforgeeks.org/python-programming-language/");
    }

    private async void OpenW3SchoolsPython(object sender, TappedEventArgs e)
    {
        await Launcher.OpenAsync("https://www.w3schools.com/python/");
    }
}