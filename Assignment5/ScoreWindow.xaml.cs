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
            InitializeComponent();

            MyDataRow row = new MyDataRow(game.GetName(), game.GetAge(), game.CorrectAnswers, game.IncorrectAnswers, game.GetSeconds());
            rows.Add(row);

            if (game.CorrectAnswers < 6)
            {
                SoundPlayer simpleSound = new SoundPlayer("wa-wa-wa.wav");
                simpleSound.Play();
            }
            else
            {
                SoundPlayer simpleSound = new SoundPlayer("victoryscreech.wav");
                simpleSound.Play();
            }

            data_grid.ItemsSource = rows;
        }
    }
}
