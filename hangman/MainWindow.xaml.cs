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

namespace hangman
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string word;
        public int lengthWord;
        public bool heeftGewonnen = false;
        public bool heeftVerloren = false;
        
        public List<string> teRadenWoord;
        public List<string> gebruikteLetters = new List<string>(24);
        int aantalMisGokken;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void letterGokButton_Click(object sender, RoutedEventArgs e)
        {
            string gok;
            gok = gokTextBox.Text.ToUpper().Trim();
            gokTextBox.Text = "";


            if (true == JuisteGok(gok))
            {
                gebruikteLetters.Add(gok);


                if (word.Contains(gok))
                {
                    for (int i = 0; i < lengthWord; i++)
                    {
                        if (word.Substring(i,1).Equals(gok) == true)
                        {
                            teRadenWoord[i] = gok;
                        }
                
                    }

                    ToonWoord();

                    if (teRadenWoord.Contains("_ ") != true)
                    {
                        MessageBox.Show("ge hebt gewonnen!!!!");
                        heeftGewonnen = true;
                    }
                }
                else
                {
                    FouteGok();
                }
            }
            
        }

        public bool JuisteGok(string gok)
        {
            if (heeftGewonnen)
            {
                MessageBox.Show("ge hebt het al geraden");
                return false;
            }
            else if (heeftVerloren)
            {
                MessageBox.Show("ge zijt dood");
                return false;
            }
            else if (gebruikteLetters.Contains(gok))
            {
                MessageBox.Show("letter al gebruikt");
                return false;
            } 
            else if (gok == "")
            {
                MessageBox.Show("je hebt geen letter gezed");
                return false;
            }
            else if (gok.Any(char.IsDigit))
            {
                MessageBox.Show("geef een letter geen nummer");
                return false;
            }
            else
            {
                return true;
            }
        }



        private void setBoxButton_Click(object sender, RoutedEventArgs e)
        {
            word = setWordTextBox.Text.Trim().ToUpper(); //spacies weg halen en alles in hoofdletters zetten
            if (word.Any(char.IsDigit))//kijken of er een nummer in de string zit
            {
                MessageBox.Show("error er is een nummer in uw string");
            }
            else
            {
                aantalMisGokken = 0;
                heeftGewonnen = false;
                heeftVerloren = false;
                lengthWord = word.Length;
                teRadenWoord = new List<string>(lengthWord);

                setWordTextBox.Text = "";
                lengthTextBlock.Text = Convert.ToString(lengthWord);
                
                gebruikteLetters.Clear();
                hangManCanvas.Children.Clear();
                

                for (int i = 0; i <= lengthWord - 1; i++)
                {
                    teRadenWoord.Add("_ ");
                }

                ToonWoord();
            }
        }


        public void ToonWoord()
        {
            wordTextBlock.Text = "";
            foreach (string letter in teRadenWoord)
            {
                wordTextBlock.Text += letter;
            }
        }

        public void FouteGok()
        {
            aantalMisGokken++;
            
            switch (aantalMisGokken)
            {
                case 1:
                    TekenCirkel(40,40,130,110); //hoofd
                    break;
                case 2:
                    TekenLijn(150, 150, 150, 200); //lichaam
                    break;
                case 3:
                    TekenLijn(150, 160, 130, 200); //linker arm
                    break;
                case 4:
                    TekenLijn(150, 160, 170, 200); // rechter arm
                    break;
                case 5:
                    TekenLijn(150, 200, 130, 250); // linker been
                    break;
                default:
                    TekenLijn(150, 200, 170, 250); //rechter been
                    heeftVerloren = true;
                    MessageBox.Show("ge zijt verloren");
                    break;
            }
        }

        public void TekenCirkel(int breedte, int hoogte, int x_as, int y_as)
        {
            Ellipse cirkel = new Ellipse();
            cirkel.Width = breedte;
            cirkel.Height = hoogte;
            cirkel.Margin = new Thickness(x_as, y_as, 0, 0);
            cirkel.Stroke = new SolidColorBrush(Colors.Black);
            cirkel.Fill = new SolidColorBrush(Colors.Red);

            hangManCanvas.Children.Add(cirkel);

        }

        public void TekenLijn(int x1, int y1, int x2, int y2)
        {
            Line lijn = new Line();
            lijn.X1 = x1;
            lijn.Y1 = y1;
            lijn.X2 = x2;
            lijn.Y2 = y2;

            lijn.Stroke = new SolidColorBrush(Colors.Black);
            

            hangManCanvas.Children.Add(lijn);
        }
    }
}


//for (int i = 0; i <= 7; i++)
//{
//    teRadenWoord.Add("_ ");
//}
//ToonWoord();