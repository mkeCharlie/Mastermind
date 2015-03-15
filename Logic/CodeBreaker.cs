using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    /// <summary>
    /// White feedback == right color & position.
    /// </summary>
    public class Codebreaker
    {
        private int _lastGuessNumber;
        private readonly List<Tuple<string, string>> _guesses;



        public Codebreaker()
        {
            _guesses = new List<Tuple<string, string>>();
        }

        public string Guess(string feedback)
        {
            if (_lastGuessNumber > 0)
            {
                var lastGuessPair = _guesses[_lastGuessNumber - 1];

                var lastGuess = lastGuessPair.Item1;

                _guesses.Remove(lastGuessPair);

                _guesses.Add(new Tuple<string, string>(lastGuess, feedback));
            }

            string guess;
            if (feedback.Length == 4)
            {
                if (_lastGuessNumber > 1)
                {
                    guess = "GGYY";
                }
                else
                {
                    guess = "BBWW";
                }
            }
            else
            {
                if (_lastGuessNumber == 0)
                {
                    guess = "WWBB";
                }
                else if (_lastGuessNumber == 1)
                {
                    guess = "YYGG";
                }
                else
                {
                    guess = "BBRR";
                }
            }

            _guesses.Add(new Tuple<string, string>(guess, null));
            _lastGuessNumber++;
            return guess;
        }
    }
}
