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
        //input data
        string fromtxt = From.Text;
        string totxt = To.Text;
        string daytxt = Days.Text;
       

        string[] lines = System.IO.File.ReadAllLines(@"E:\flights (2).csv");

        foreach (string line in lines)
        {
            string[] parts = line.Split(',');

            string arrivedFrom = parts[1];
            
            string day = parts[4];

            if(arrivedFrom == From.Text && day == Days.Text)
            {
                flight.Text = line;
            }
        }
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

