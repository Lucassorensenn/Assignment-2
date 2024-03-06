namespace MauiApp5;

public partial class MainPage : ContentPage
{


	public MainPage()
	{
		InitializeComponent();
	}



//Lucas's part
    private void OnFlight (object sender, EventArgs e)
    {
        flight.Text = "Flight found";
    }
//



    //From
    void OnFromTextChanged(object sender, TextChangedEventArgs e)
    {
        string oldText = e.OldTextValue;
        string newText = e.NewTextValue;
        string myText = From.Text;
    }

    void OnFromCompleted(object sender, EventArgs e)
    {
        string text = ((Entry)sender).Text;
    }

    //To
    void OnToTextChanged(object sender, TextChangedEventArgs e)
    {
        string oldText = e.OldTextValue;
        string newText = e.NewTextValue;
        string myText = To.Text;
    }

    void OnToCompleted(object sender, EventArgs e)
    {
        string text = ((Entry)sender).Text;
    }

    //Des
    void OnDesTextChanged(object sender, TextChangedEventArgs e)
    {
        string oldText = e.OldTextValue;
        string newText = e.NewTextValue;
        string myText = Des.Text;
    }

    void OnDesCompleted(object sender, EventArgs e)
    {
        string text = ((Entry)sender).Text;
    }

}

