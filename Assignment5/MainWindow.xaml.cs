using Assignment5.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
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

namespace Assignment5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            try
            {
                InitializeComponent();

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }

        /// <summary>
        /// Called when the user makes any change to the name input text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameInputDetected(object sender, TextCompositionEventArgs e)
        {
            try
            {
                if (Char.IsDigit(e.Text[0]))
                    e.Handled = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        /// <summary>
        /// Called when the user makes any change to the age input text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AgeInputDetected(object sender, TextCompositionEventArgs e)
        {
            try
            {
                if (!Char.IsDigit(e.Text[0]))
                    e.Handled = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        /// <summary>
        /// Called when the user presses the start game button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartGamePressed(object sender, RoutedEventArgs e)
        {
            try
            {
                bool validName = false;
                bool validAge = false;

                if (name_input.Text.Length == 0)
                {
                    name_label.Content = "Please enter your name";
                }
                else
                {
                    name_label.Content = "";
                    validName = true;
                }
                if (age_input.Text.Length == 0)
                {
                    age_label.Content = "Please enter your age";
                }
                else
                {
                    age_label.Content = "";
                    validAge = true;
                }

                // Game is ready to be started
                if (validName && validAge)
                {
                    String gameType = "";
                    if (add_radio.IsChecked ?? false)   // Weird bool? vs bool solution.
                        gameType = "ADD";
                    else if (subtract_radio.IsChecked ?? false)
                        gameType = "SUB";
                    else if (multiply_radio.IsChecked ?? false)
                        gameType = "MUL";
                    else if (divide_radio.IsChecked ?? false)
                        gameType = "DIV";

                    StartChosenGame(gameType);
                }
                    
            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }
        }

        /// <summary>
        /// Starts the actual game by manipulating windows
        /// </summary>
        /// <param name="gameType">The type of game being played</param>
        public void StartChosenGame(string gameType) 
        {
            try
            {
                Game currentGame = null;
                string name = name_input.Text.ToString();
                int age = Int32.Parse(age_input.Text.ToString());
                string gameTitle = "";

                switch (gameType)
                {
                    case "ADD":
                        currentGame = new Add(name, age, "+");
                        gameTitle = "Addition";
                        break;
                    case "SUB":
                        currentGame = new Subtract(name, age, "-");
                        gameTitle = "Subtraction";
                        break;
                    case "MUL":
                        currentGame = new Multiply(name, age, "x");
                        gameTitle = "Multiplication";
                        break;
                    case "DIV":
                        currentGame = new Divide(name, age, "/");
                        gameTitle = "Division";
                        break;
                }

                this.Hide();
                new GameWindow(currentGame, gameTitle).ShowDialog();  // Executed on same thread
                this.Show();
            }
            catch (Exception)
            {
                string className = MethodInfo.GetCurrentMethod().DeclaringType.Name;
                string methodName = MethodInfo.GetCurrentMethod().Name;
                
                throw new Exception("Class: " + className + "\nMethod Name: " + methodName);
            }
        }
    }
}
