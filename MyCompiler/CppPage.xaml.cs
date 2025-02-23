namespace MyCompiler;

public partial class CppPage : ContentPage
{
	public CppPage()
	{
		InitializeComponent();
	}

    private async void OpenCppTutorial(object sender, TappedEventArgs e)
    {
        await Launcher.OpenAsync("https://cplusplus.com/doc/tutorial/");
    }

    private async void OpenCodecademyCpp(object sender, TappedEventArgs e)
    {
        await Launcher.OpenAsync("https://www.learncpp.com");
    }

    private async void OpenGeeksForGeeksCpp(object sender, TappedEventArgs e)
    {
        await Launcher.OpenAsync("https://www.geeksforgeeks.org/c-plus-plus/");
    }

    private async void OpenW3SchoolsCpp(object sender, TappedEventArgs e)
    {
        await Launcher.OpenAsync("https://www.w3schools.com/cpp/");
    }
}