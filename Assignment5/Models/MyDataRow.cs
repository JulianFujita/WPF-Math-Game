using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5.Models
{
    class MyDataRow
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

        public string Name 
        {
            get { return name; }
            set { name = value; } 
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public int Correct
        {
            get { return correct; }
            set { correct = value; }
        }
        public int Incorrect
        {
            get { return incorrect; }
            set { incorrect = value; }
        }
        public int Seconds
        {
            get { return seconds; }
            set { seconds = value; }
        }
    }
}
