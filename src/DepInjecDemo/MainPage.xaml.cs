namespace DepInjecDemo;


public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    // Note: This is what is not working for me
    public MainPage(MainViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}