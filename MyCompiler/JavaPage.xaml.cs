namespace MyCompiler;

public partial class JavaPage : ContentPage
{
	public JavaPage()
	{
		InitializeComponent();
	}

    private async void OpenJavaTutorial(object sender, EventArgs e)
    {
        await Launcher.OpenAsync("https://docs.oracle.com/en/java/");
    }

    private async void OpenCodecademyJava(object sender, EventArgs e)
    {
        await Launcher.OpenAsync("https://www.codecademy.com/learn/learn-java");
    }

    private async void OpenGeeksForGeeksJava(object sender, EventArgs e)
    {
        await Launcher.OpenAsync("https://www.geeksforgeeks.org/java/");
    }

    private async void OpenW3SchoolsJava(object sender, EventArgs e)
    {
        await Launcher.OpenAsync("https://www.w3schools.com/java/");
    }

}