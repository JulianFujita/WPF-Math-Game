using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

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
            throw new NotImplementedException();
        }

        /// <summary>
        /// Generates the next question
        /// </summary>
        public override void GenerateQuestion()
        {
            throw new NotImplementedException();
        }
    }
}
