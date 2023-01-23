using System;
using System.Collections.Generic;
using System.Globalization;
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
using Microsoft.Speech.Recognition;
using Microsoft.Speech.Synthesis;

namespace Lab3_dialogowe
    {
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
        {
        static SpeechSynthesizer ss = new SpeechSynthesizer();
        static SpeechRecognitionEngine sre;
        static Pizza pizza = new Pizza()
            {
            Type = "wybierz",
            Dough = "wybierz",
            ExtraIngredient = "wybierz",
            Sauce = "wybierz",
            Size = "wybierz"
            };
        static List<Pizza> order = new List<Pizza>();
        static bool pizzaAdded;
        static bool doughSelected = false;
        static bool categorySelected = false;
        static bool sizeSelected = false;
        static bool sauceSelected = false;
        static bool ingriSelected = false;
        int pizzaPrice;
        int orderPrice;

        public MainWindow()
            {
            pizzaPrice = 0;
            orderPrice = 0;
            ss.SetOutputToDefaultAudioDevice();
            CultureInfo ci = new CultureInfo("pl-PL");
            sre = new SpeechRecognitionEngine(ci);
            sre.SetInputToDefaultAudioDevice();
            sre.SpeechRecognized += Sre_SpeechRecognized;
            sre.SpeechRecognitionRejected += Sre_SpeechRecognitionRejected;
            Grammar grammar = new Grammar(".\\Grammar\\Skladniki.xml")
                {
                Enabled = true
                };
            sre.LoadGrammar(grammar);
            sre.RecognizeAsync(RecognizeMode.Multiple);
            //ss.SpeakAsync("Witamy w Pizzerii San Dżiowanni, jaką pizzę chcesz zamowić?.");
            ss.SpeakAsync("Jakie chcesz ciasto?");
            Loaded += MainWindow_Loaded;

            }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
            {
            throw new NotImplementedException();
            }

        private void Sre_SpeechRecognitionRejected(object sender, SpeechRecognitionRejectedEventArgs e)
            {
            throw new NotImplementedException();
            }

        private void Sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
            {
            throw new NotImplementedException();
            }
        }
        
}
