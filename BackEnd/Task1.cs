using System;

namespace BackEnd
{
    public class Task1
    {
        private const string Stack = "Stack";
        private const string Overflow = "Overflow";
        private const string StackOverflow = "Stack Overflow!";


        public string GetWordMod(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                throw new Exception("Please specify input.");

            //ASSUMPTION: Assuming that a input can have spaces between and characters, so I am not removing the spaces between or characters

            var inputLength = input.Length;

            if (IsAMiltiple(inputLength, 2) && IsAMiltiple(inputLength, 4))
                return StackOverflow;

            if (IsAMiltiple(inputLength, 2))
                return Stack;

            if (IsAMiltiple(inputLength, 4))
                return Overflow;
                
            return string.Empty;
        }

        private  bool IsAMiltiple(int firstValue, int secValue)
        {
            return firstValue % secValue == 0;
        }
    }
}
