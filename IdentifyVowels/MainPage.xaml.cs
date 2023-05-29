namespace IdentifyVowels;

public partial class MainPage : ContentPage
{
    //array of vowels
	char[] arrayOfVowels = { 'a', 'e', 'i', 'o', 'u' };

	public MainPage()
	{
		InitializeComponent();
	}

	private void onCheckBtnClicked(object sender, EventArgs e)
	{
        //stores user input
		var userInput = entry.Text;

        //validate if the user input is empty or not
        if (userInput == null || userInput == "") {
            errorMsg.Text = "Letter field should not be empty.";
            errorMsg.IsVisible = true;
            resultMsg.IsVisible = false;
        }
		else {
            errorMsg.IsVisible = false;
            //for-loop to go through every char in vowel array
            foreach (char letter in arrayOfVowels)
            {
                //compare
                if (userInput == letter.ToString())
                {
                    resultMsg.Text = "Yes, it is a vowel.";
                    resultMsg.IsVisible = true;
                    resultMsg.TextColor = Colors.Black;
                    break;
                }
                else
                {
                    resultMsg.Text = "No, it is not a vowel.";
                    resultMsg.IsVisible = true;
                    resultMsg.TextColor = Colors.Red;
                }
            }
        }
			
        SemanticScreenReader.Announce(CheckBtn.Text);
	}
}


