using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Threading;

namespace Assignment5.Models
{
    class Divide : Game
    {
        /// <summary>
        /// Builds the game
        /// </summary>
        /// <param name="name">Name of the player</param>
        /// <param name="age">Age of the player</param>
        public Divide(string name, int age, string gameType) : base(name, age, gameType) { }

        /// <summary>
        /// Checks the player's answer
        /// </summary>
        public override void CheckAnswer()
        {
            int a = Int32.Parse(this.GetFirstNumberLabel().Content.ToString());
            int b = Int32.Parse(this.GetSecondNumberLabel().Content.ToString()); ;
            int c = Int32.Parse(this.GetAnswerBox().Text.ToString());

            if (a / b == c)
            {
                this.PlayCorrectSound();
                GenerateQuestion();
            }
            else
            {
                this.PlayIncorrectSound();
                GenerateQuestion();
            }
        }

        /// <summary>
        /// Generates the next question
        /// </summary>
        public override void GenerateQuestion()
        {
            try
            {
                if (this.QuestionsAnswered < this.GetMaxGames())
                {
                    Random r = new Random();

                    // Make sure division has no remainder
                    int a = r.Next(1, 11);
                    int b = r.Next(1, 11);
                    while (a <= b || (a % b) != 0)
                    {
                        a = r.Next(1, 11);
                        b = r.Next(1, 11);
                    }
                    

                    this.GetFirstNumberLabel().Content = a;
                    this.GetSecondNumberLabel().Content = b;
                }
                // End the game
                else
                {
                    this.GetTimer().Stop();
                    this.KillWindow();

                    new ScoreWindow(this).Show();
                }

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
