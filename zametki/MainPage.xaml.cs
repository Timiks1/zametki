namespace zametki;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{




		File.AppendAllText("/Users/tim/Desktop/s3/mat.txt", field.Text+"&&");

		string text = File.ReadAllText("/Users/tim/Desktop/s3/mat.txt");
		string[] arr = text.Split("&&");
		foreach(string a in arr)
		{
			final.Text += a + "\n";
		}
		
	}
}


