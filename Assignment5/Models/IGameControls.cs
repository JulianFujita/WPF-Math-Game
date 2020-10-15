using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5.Models
{
    /// <summary>
    /// This will force every game to implement the startGame function
    /// </summary>
    public interface IGameControls
    {
        /// <summary>
        /// When the game starts, the correct game type must be built
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void StartGame(object sender, EventArgs e);
        /// <summary>
        /// Generate a new question that makes sense for the game type
        /// </summary>
        void GenerateQuestion();
        /// <summary>
        /// Check the answer for the game type
        /// </summary>
        void CheckAnswer();
    }
}
