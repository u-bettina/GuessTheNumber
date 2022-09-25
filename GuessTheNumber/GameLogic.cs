using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    enum GuessResult
    {
        SmallerThanThought,
        BiggerThanThought,
        Found
    }
    static class GameLogic
    {
        #region Fields
        static Random r;
        static int min, max, thoughtNumber;
        #endregion

        #region Properties
        public static int Min { get => min; }
        public static int Max { get => max; }
        #endregion

        #region Constructors
        static GameLogic()
        {
            r = new Random();
            min = 1;
            max = 100;
            thoughtNumber = 50;
        }
        public static void NewGame(int min, int max)
        {
            GameLogic.min = min;
            GameLogic.max = max;
            thoughtNumber = r.Next(min, max + 1);
        }
        #endregion

        #region Subroutines
        public static GuessResult Guess(int guess)
        {
            if (guess < thoughtNumber)
            {
                return GuessResult.SmallerThanThought;
            }
            else if (guess > thoughtNumber)
            {
                return GuessResult.BiggerThanThought;
            }
            return GuessResult.Found;
        }
        #endregion



    }
}
