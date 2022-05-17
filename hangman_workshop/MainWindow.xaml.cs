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

namespace hangman_workshop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string word = "HANGMAN";
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
            
        }

        private void setBoxButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        

        public void FouteGok()
        {






            /*
            TekenCirkel(40, 40, 130, 110); //hoofd
            TekenLijn(150, 150, 150, 200); //lichaam
            TekenLijn(150, 160, 130, 200); //linker arm
            TekenLijn(150, 160, 170, 200); // rechter arm
            TekenLijn(150, 200, 130, 250); // linker been
            TekenLijn(150, 200, 170, 250); //rechter been
            */
        }

        

        
    }
}
