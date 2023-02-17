namespace DepInjecDemo;


public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
    
    public MainPage(MainViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}