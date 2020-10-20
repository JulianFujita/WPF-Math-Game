using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Windows;

namespace Assignment5.Models
{
    class MyDataRow : IComparable<MyDataRow>
    {
        /// <summary>
        /// Name of the player
        /// </summary>
        private string name;
        /// <summary>
        /// Age of the player
        /// </summary>
        private int age;
        /// <summary>
        /// Number of correct answers
        /// </summary>
        private int correct;
        /// <summary>
        /// Number of incorrect answers
        /// </summary>
        private int incorrect;
        /// <summary>
        /// Number of seconds it took to answer 10 questions
        /// </summary>
        private int seconds;

        /// <summary>
        /// Constructor for a single row of data
        /// </summary>
        /// <param name="name">Player's name</param>
        /// <param name="age">Player's age</param>
        /// <param name="correct">Correct answers</param>
        /// <param name="incorrect">Incorrect answers</param>
        /// <param name="seconds">Seconds elapsed</param>
        public MyDataRow(string name, int age, int correct, int incorrect, int seconds) 
        {
            this.name = name;
            this.age = age;
            this.correct = correct;
            this.incorrect = incorrect;
            this.seconds = seconds;
        }

        /// <summary>
        /// Player name
        /// </summary>
        public string Name 
        {
            get { return name; }
            set { name = value; } 
        }
        /// <summary>
        /// Player age
        /// </summary>
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        /// <summary>
        /// Correct answers
        /// </summary>
        public int Correct
        {
            get { return correct; }
            set { correct = value; }
        }
        /// <summary>
        /// Incorrect answers
        /// </summary>
        public int Incorrect
        {
            get { return incorrect; }
            set { incorrect = value; }
        }
        /// <summary>
        /// Seconds elapsed
        /// </summary>
        public int Seconds
        {
            get { return seconds; }
            set { seconds = value; }
        }

       /// <summary>
       /// Used by Sort() method
       /// </summary>
       /// <param name="other"></param>
       /// <returns></returns>
        public int CompareTo([AllowNull] MyDataRow other)
        {
            try
            {
                MyDataRow row = (MyDataRow)other;

                // Left is less than right
                if (this.Correct < row.Correct)
                    return 1;
                // Left is greater than right
                else if (this.Correct > row.Correct)
                    return -1;
                // Both are equal
                else
                {
                    // Left is faster than right
                    if (this.Seconds < row.Seconds)
                        return -1;
                    // Left is slower than right
                    else if (this.Seconds > row.Seconds)
                        return 1;
                    else
                        return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            return 0;

        }
    }
}
