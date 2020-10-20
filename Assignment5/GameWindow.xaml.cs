using Assignment5.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Media;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Assignment5
{
    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        /// <summary>
        /// The handle to the game
        /// </summary>
        private Game game;
        /// <summary>
        /// The countdown timer
        /// </summary>
        private DispatcherTimer countDown;
        /// <summary>
        /// The countdown starting number
        /// </summary>
        private int count = 2;
        /// <summary>
        /// The title of the game
        /// </summary>
        private string title;

        /// <summary>
        /// Constructs the game window
        /// </summary>
        /// <param name="timer">The timer of te game</param>
        /// <param name="title">The title of the game</param>
        /// <param name="gameType">The type of game</param>
        public GameWindow(Game game, string title)
        {
            try
            {
                // Set up the game
                InitializeComponent();

                this.game = game;
                this.title = title;
                game.SetHandles(first_number_label, second_number_label, answer_box, timer_label, feedback_label, this);
                game_type_label.Content = title;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Called when the user presses the I'm Ready button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReadyButtonPressed(object sender, RoutedEventArgs e)
        {
            try
            {
                // Play sound
                SoundPlayer simpleSound = new SoundPlayer("game-start.wav");
                simpleSound.Play();

                // Hide button
                ready_button.Visibility = Visibility.Hidden;

                // Countdown
                countDown = new DispatcherTimer();
                countDown.Interval = new TimeSpan(0, 0, 1);
                countDown.Tick += CountDown_Tick;
                countdown_label.Content = (count + 1).ToString();
                countDown.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

        /// <summary>
        /// Called whenever a countdown is required
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CountDown_Tick(object sender, EventArgs e)
        {
            try
            {
                if (count > 0)
                {
                    countdown_label.Content = count;
                    count--;
                }
                else
                {
                    // Show all components
                    ShowAllComponents();

                    // Hide any components
                    countdown_label.Content = "";
                    ready_button.Visibility = Visibility.Hidden;

                    game.GetTimer().Start();
                    game.GenerateQuestion();
                    countDown.Stop();
                }
            }
            catch (Exception)
            {
                string className = MethodInfo.GetCurrentMethod().DeclaringType.Name;
                string methodName = MethodInfo.GetCurrentMethod().Name;

                throw new Exception("Class: " + className + "\nMethod Name: " + methodName);
            }
        }

        /// <summary>
        /// Called whenever there is a change in the answer box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnswerBoxChanged(object sender, KeyEventArgs e)
        {
            try
            {
                e.Handled = true;
                int length = e.Key.ToString().Length;

                if (length > 1 && !Char.IsDigit(e.ToString()[1]))
                    e.Handled = false;
                if (e.Key == Key.Enter && answer_box.Text.Length != 0)
                {
                    game.CheckAnswer();
                    answer_box.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Shows all relevant components for the game
        /// </summary>
        private void ShowAllComponents()
        {
            try
            {
                submit_button.Visibility = Visibility.Visible;
                operator_label.Content = game.GetGameType();
                equality_label.Content = "=";
                answer_box.Visibility = Visibility.Visible;
                answer_box.Focus();
            }
            catch (Exception)
            {
                string className = MethodInfo.GetCurrentMethod().DeclaringType.Name;
                string methodName = MethodInfo.GetCurrentMethod().Name;

                throw new Exception("Class: " + className + "\nMethod Name: " + methodName);
            }
        }

        /// <summary>
        /// Executed when the quit button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QuitButtonPressed(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Executed when the submit button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitButtonPressed(object sender, RoutedEventArgs e)
        {
            try
            {
                if (answer_box.Text.Length != 0)
                {
                    game.CheckAnswer();
                    answer_box.Text = "";
                    answer_box.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
