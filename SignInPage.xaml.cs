namespace LoginRegister;

public partial class SignInPage : ContentPage
{
	public SignInPage()
	{
		InitializeComponent();
	}

    private async void TapGestureRecognizer_Tapped_For_SignUP(object sender, TappedEventArgs e)
    {
		await Shell.Current.GoToAsync("//SignUp");
    }
}