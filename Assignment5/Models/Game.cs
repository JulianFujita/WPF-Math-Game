using System;
using System.Collections.Generic;
using System.Media;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace Assignment5.Models
{
    /// <summary>
    /// This is the abstract class for any type of game
    /// </summary>
    public abstract class Game : IGameControls
    {
        /// <summary>
        /// The window for the game
        /// </summary>
        private Window window;
        /// <summary>
        /// The timer for the current game
        /// </summary>
        private DispatcherTimer timer = new DispatcherTimer();
        /// <summary>
        /// Handle of the first number label
        /// </summary>
        private Label firstNumber;
        /// <summary>
        /// Handle of the second number label
        /// </summary>
        private Label secondNumber;
        /// <summary>
        /// Handle of the answer box
        /// </summary>
        private TextBox answerBox;
        /// <summary>
        /// Handle of the countdown
        /// </summary>
        private Label countDown;
        /// <summary>
        /// Handle of the feedback label
        /// </summary>
        private Label answerFeedback;
        /// <summary>
        /// The type of game being played represented by an operator
        /// </summary>
        private string gameType;
        /// <summary>
        /// Name of the current player
        /// </summary>
        private string playerName;
        /// <summary>
        /// Age of the current player
        /// </summary>
        private int playerAge;
        /// <summary>
        /// Seconds since the game has been started
        /// </summary>
        private int seconds = 0;
        /// <summary>
        /// The title for the current game
        /// </summary>
        private int maxGames = 10;
        /// <summary>
        /// The number of questions answered so far
        /// </summary>
        private int questionsAnswered = 0;

        /// <summary>
        /// Builds the game
        /// </summary>
        public Game(String name, int age, string gameType) 
        {
            try
            {
                this.gameType = gameType;
                this.playerName = name;
                this.playerAge = age;
                timer.Interval = TimeSpan.FromMilliseconds(1000);
                timer.Tick += new EventHandler(StartGame);
            }
            catch (Exception)
            {
                string className = MethodInfo.GetCurrentMethod().DeclaringType.Name;
                string methodName = MethodInfo.GetCurrentMethod().Name;

                throw new Exception("Class: " + className + "\nMethod Name: " + methodName);
            }
        }

        /// <summary>
        /// Sets all the handles for the game window
        /// </summary>
        /// <param name="first">First number</param>
        /// <param name="second">Second number</param>
        /// <param name="answer">Player's answer</param>
        /// <param name="count">The countdown label</param>
        /// <param name="feedback">Feedback label</param>
        /// <param name="window">The parent window</param>
        public void SetHandles(Label first, Label second, TextBox answer, Label count, Label feedback, Window window) 
        {
            this.countDown = count;
            this.firstNumber = first;
            this.secondNumber = second;
            this.answerBox = answer;
            this.answerFeedback = feedback;
            this.window = window;
        }

        /// <summary>
        /// Occurs when the player gets the right answer
        /// </summary>
        public void PlayCorrectSound()
        {
            try
            {
                this.CorrectAnswers++;
                answerFeedback.Content = "Correct!";

                Random r = new Random();
                if (r.Next(0, 3) == 0)
                {
                    SoundPlayer simpleSound = new SoundPlayer("plankton-correct.wav");
                    simpleSound.Play();
                }
                else
                {
                    SoundPlayer simpleSound = new SoundPlayer("chime-correct.wav");
                    simpleSound.Play();
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
        /// Occurs when the player gets the wrong answer
        /// </summary>
        public void PlayIncorrectSound()
        {
            try
            {
                this.IncorrectAnswers++;
                answerFeedback.Content = "Incorrect!";

                Random r = new Random();

                if (r.Next(0, 3) == 0)
                {
                    SoundPlayer simpleSound = new SoundPlayer("my_leg.wav");
                    simpleSound.Play();
                }
                else
                {
                    SoundPlayer simpleSound = new SoundPlayer("wrong.wav");
                    simpleSound.Play();
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
        /// Get the timer for te current game
        /// </summary>
        /// <returns>The timer</returns>
        public DispatcherTimer GetTimer() { return timer; }

        /// <summary>
        /// Gets the game type of the current game
        /// </summary>
        /// <returns>Game type</returns>
        public string GetGameType()
        {
            return this.gameType;
        }

        /// <summary>
        /// Get the first number label
        /// </summary>
        /// <returns>The label</returns>
        public Label GetFirstNumberLabel() { return firstNumber; }
        /// <summary>
        /// Get the second number label
        /// </summary>
        /// <returns>The label</returns>
        public Label GetSecondNumberLabel() { return secondNumber; }
        /// <summary>
        /// Get the first number label
        /// </summary>
        /// <returns>The textbox</returns>
        public TextBox GetAnswerBox() { return answerBox; }
        /// <summary>
        /// Get the countdown label
        /// </summary>
        /// <returns>The label</returns>
        public Label GetCountDownLabel() { return countDown; }
        /// <summary>
        /// Get the feedback label
        /// </summary>
        /// <returns>The label</returns>
        public Label GetFeedbackLabel() { return answerFeedback; }
        /// <summary>
        /// Get the number of seconds that have elapsed while incrementing the number
        /// </summary>
        /// <returns>Elapsed seconds</returns>
        public int GetSeconds()
        {
            return seconds++;
        }

        /// <summary>
        /// Get the max games
        /// </summary>
        /// <returns>Max games</returns>
        public int GetMaxGames() { return maxGames; }
        /// <summary>
        /// Property for score
        /// </summary>
        public int Score { get; set; }
        /// <summary>
        /// Property for correct answers
        /// </summary>
        public int CorrectAnswers { get; set; }
        /// <summary>
        /// Property for incorrect answers
        /// </summary>
        public int IncorrectAnswers { get; set; }
        /// <summary>
        /// Property for the number of questions answered
        /// </summary>
        public int QuestionsAnswered { get { return questionsAnswered++; } set {  } }

        /// <summary>
        /// Kills the game
        /// </summary>
        public void KillWindow() { window.Close(); }

        /// <summary>
        /// Get the player's name
        /// </summary>
        /// <returns></returns>
        public string GetName() { return playerName; }
        /// <summary>
        /// Get the player's age
        /// </summary>
        /// <returns></returns>
        public int GetAge() { return playerAge; }

        /// <summary>
        /// Start the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void StartGame(object sender, EventArgs e)
        {
            try
            {
                this.GetCountDownLabel().Content = "Time: " + this.GetSeconds() + " seconds";
            }
            catch (Exception)
            {
                string className = MethodInfo.GetCurrentMethod().DeclaringType.Name;
                string methodName = MethodInfo.GetCurrentMethod().Name;

                throw new Exception("Class: " + className + "\nMethod Name: " + methodName);
            }
        }
        /// <summary>
        /// The generate question method must be implemented
        /// </summary>
        public abstract void GenerateQuestion();
        /// <summary>
        /// The check answer method must be implemented
        /// </summary>
        public abstract void CheckAnswer();
    }
}
