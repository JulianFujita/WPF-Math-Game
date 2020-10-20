using Assignment5.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Media;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Assignment5
{
    /// <summary>
    /// Interaction logic for ScoreWindow.xaml
    /// </summary>
    public partial class ScoreWindow : Window
    {
        /// <summary>
        /// A list of all the games
        /// </summary>
        private static List<MyDataRow> rows = new List<MyDataRow>();

        /// <summary>
        /// Constructor for the score window
        /// </summary>
        /// <param name="game"></param>
        public ScoreWindow(Game game)
        {
            try
            {
                InitializeComponent();

                MyDataRow row = new MyDataRow(game.GetName(), game.GetAge(), game.CorrectAnswers, game.IncorrectAnswers, game.GetSeconds());
                rows.Add(row);

                // 0-4 correct answers
                if (game.CorrectAnswers <= 4)
                {
                    SoundPlayer simpleSound = new SoundPlayer("wa-wa-wa.wav");
                    simpleSound.Play();

                    ImageBrush myBrush = new ImageBrush(new BitmapImage(new Uri(@"Images/brain_fire.jpg", UriKind.Relative)));
                    this.Background = myBrush;
                }
                // 5-7 correct answers
                else if (game.CorrectAnswers <= 7)
                {
                    SoundPlayer simpleSound = new SoundPlayer("spongebob-fail.wav");
                    simpleSound.Play();

                    ImageBrush myBrush = new ImageBrush(new BitmapImage(new Uri(@"Images/spongebob_cafe.jpg", UriKind.Relative)));
                    this.Background = myBrush;
                }
                // 8-10 correct answers
                else
                {
                    SoundPlayer simpleSound = new SoundPlayer("victoryscreech.wav");
                    simpleSound.Play();
                }

                rows.Sort();  //Implement an interface or create a sorting algorithm
                data_grid.ItemsSource = rows;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
