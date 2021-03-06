﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardHandlerlib
{
    public class CardHandler
    {
        public string CardChecker(string input)
        {
            //return "2 of Diamonds";

            //string output = "";

            //output = ValuesChecker(input);
            //output += " of ";
            //output += SuitChecker(input[1]);

            //return output;

            //string output = "";

            //output = ValuesChecker(input);
            //output += " of ";
            //output += SuitChecker(input[input.Length-1]);

            //return output;

            //if (input.Length < 4)
            //{
            //    string output = "";

            //    output = ValuesChecker(input);
            //    output += " of ";
            //    output += SuitChecker(input[input.Length - 1]);

            //    return output;
            //}
            //else return "Invalid input";

            if (input.Length == 2 || input.Length == 3)
            {
                string value = input.Substring(0, input.Length - 1);
                char suit = input.Last();

                string output = "";

                output = ValuesChecker(value);
                output += " of ";
                output += SuitChecker(suit);

                return output;

            }
            else throw new ArgumentException("Input is wrong length");
        }

        public string SuitChecker(char input)
        {
            //return "Diamond";

            //if (input.Contains("d"))
            //    return "Diamond";
            //else
            //    return "Club";

            //if (input == 'd')
            //    return "Diamond";
            //else if (input == 'c')
            //    return "Club";
            //else if (input == 'h')
            //    return "Heart";
            //else return "Spade";

            //if (input == 'd')
            //    return "Diamond";
            //else if (input == 'c')
            //    return "Club";
            //else if (input == 'h')
            //    return "Heart";
            //else return "Spade";

            //if (input == 'd')
            //    return "Diamond";
            //else if (input == 'c')
            //    return "Club";
            //else if (input == 'h')
            //    return "Heart";
            //else if (input == 's')
            //    return "Spade";
            //else return "Invalid input";

            if (input == 'd' || input == 'D')
                return "Diamonds";
            else if (input == 'c' || input == 'C')
                return "Clubs";
            else if (input == 'h' || input == 'H')
                return "Hearts";
            else if (input == 's' || input == 'S')
                return "Spades";
            else throw new ArgumentException("Input is not a valid suit");
        }

        public string ValuesChecker(string input)
        {
            //return "2";

            if (input == "10")
                return "10";
            else if (input == "9")
                return "9";
            else if (input == "8")
                return "8";
            else if (input == "7")
                return "7";
            else if (input == "6")
                return "6";
            else if (input == "5")
                return "5";
            else if (input == "4")
                return "4";
            else if (input == "3")
                return "3";
            else if (input == "2")
                return "2";
            else if (input == "A" ||input == "a")
                return "Ace";
            else if (input == "J" || input == "j")
                return "Jack";
            else if (input == "Q" || input == "q")
                return "Queen";
            else if (input == "K" || input == "k")
                return "King";
            else throw new ArgumentException("Input is not a valid value");
        }
    }
}
