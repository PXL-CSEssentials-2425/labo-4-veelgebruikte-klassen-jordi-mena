using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PasswordMeter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Input velden: userNameTextBox en passwordTextBox
        /// Output veld: resultTextBlock
        /// </summary>

        public MainWindow()
        {
            InitializeComponent();
        }



        private void passwordMeterButton_Click(object sender, RoutedEventArgs e)
        {

            string tempUser = userNameTextBox.Text.Trim();
            string temPasswoord = passwordTextBox.Text.Trim();  //hebben we deze var nodig???
            int failedCounter = 0;



            resultTextBlock.Text = string.Empty;
            //controleer of het ww niet de gebruikersnaam bevat (contains = zoals bool)
           bool checkUsercontainer = temPasswoord.Contains(tempUser);

            //als het true is dan moet je een melding laten zien op de resulttextbox

            //Controleer of het wachtwoord niet de gebruikersnaam bevat.
            if (checkUsercontainer == true )
            {
                resultTextBlock.Text = "wachtwoord mag gebruikersnaam NIET bevatten!\n";
           
            }


            
            //Controleer of het wachtwoord minstens één getal bevat.
            if (temPasswoord.Any(char.IsNumber) == false)
            {
                failedCounter++;
                //resultTextBlock.Text += "Wachtwoord moet minstens een getal bevatten!\n";
            
            }
            if (temPasswoord.Length < 10)
            {
                failedCounter ++;
                //resultTextBlock.Text += "Wachtwoord moet minstens tien karakters lang zijn!\n";

            }
            switch (failedCounter) 
            { 
           
                case 0:
                    resultTextBlock.Text = "your password is strong";
                    break;
                case 1:
                    resultTextBlock.Text = "your password is OK";
                    break;

                default:
                    resultTextBlock.Text = "your passwoord is bad";
                    break;

                

            
            
            }

            //Haal 5 willekeurige letters uit de gebruikersnaam en voeg ze toe als kleine letters aan het wachtwoord. (random)
            //Genereer een getal van één tot vijf en voeg zoveel uitroeptekens toe.(stringbuilder)

            //Genereer 5 willekeurige cijfers en voeg deze toe aan het wachtwoord. (random)
            //Haal 2 willekeurige letters uit de gebruikersnaam en voeg ze toe als hoofdletters aan het wachtwoord.(random)
            
        }





















        private void passwordTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void userNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
