using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using PasswordGeneratorLB1.Properties;

namespace PasswordGeneratorLB1
{
    internal class Password
    {

        private

        int _pwLength;
        bool _ssymbols;
        bool _numbers;
        bool _upCase;
        bool _downCase;
        double length = 5;

        bool isNeedToSkip(int arrayNumber, bool check_Num, bool check_Ssym, bool check_upCase, bool check_downCase)
        {
            if (arrayNumber == use_numbers && !check_Num)
            {
                return true;
            } else if (arrayNumber == use_ssymbols && !check_Ssym) 
            {
                return true;
            } else if (arrayNumber == use_upCase && !check_upCase) 
            {
                return true;
            } else if (arrayNumber == use_downCase && !check_downCase) 
            {
                return true;
            }
            return false;
        }

        const int use_ssymbols = 1;
        const int use_numbers = 2;
        const int use_downCase = 3;
        const int use_upCase = 4;


        public string[] digits = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        public string[] lowercaseLetters = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        public string[] uppercaseLetters = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        public string[] specialSymbols = new string[] { "#", "!", "$", ";", "_", "&", "^", "%", "&", "*", "(", ")", "{", "}", "[", "]" };

        public Password()
        {
 
        }

        public bool countPasswordPower()
        {

            double pwr = 1.44 * Math.Pow(10, 10);
            double pw = 0;
            double A = 0;
            if (_ssymbols)
            {
                A = A + 17;
            }
            if (_numbers)
            {
                A = A + 10;
            }
            if (_upCase)
            {
                A = A + 26;
            }
            if (_downCase)
            {
                A = A + 26;
            }
            pw = Math.Pow(A, length);
            if (pw >= pwr)
            {
                return true; //сильный пароль
            }
            return false;
        }

        public void setSS(bool ss) 
        {
            _ssymbols = ss;
        }

        public void setDig(bool dig)
        {
            _numbers = dig;
        }
        public void setUpC(bool upC)
        {
            _upCase = upC;
        }
        public void setDownC(bool downC)
        {
            _downCase = downC;
        }

        public void setLength(double L)
        {
            length = L;
        }

        public string genRndPassword() 
        {
            int quantity = 0;
            int howMuchNeeded = 0;
            bool correct = false;
            StringBuilder sbPassword = new StringBuilder();
            Random random = new Random();
            var hasNumber = new Regex(@"[0-9]");
            var hasUpperChar = new Regex(@"[A-Z]");
            var hasSpecialSymbols = new Regex(@"[!-/:-?]");
            var hasLowerChar = new Regex(@"[a-z]");
            do
            {
                sbPassword.Clear();
                for (int i = 0; i < length; i++)
                {
                    int randomArrayNumber;
                    do
                    {
                        quantity = 0;
                        randomArrayNumber = random.Next(1, 5);
                    } while (isNeedToSkip(randomArrayNumber, _numbers, _ssymbols, _upCase, _downCase));

                    switch (randomArrayNumber)
                    {
                        case use_numbers:
                            int randomDigitIndex = random.Next(0, digits.Length);
                            sbPassword.Append(digits[randomDigitIndex]);
                            break;
                        case use_upCase:
                            int randomUppercaseLetterIndex = random.Next(0, uppercaseLetters.Length);
                            sbPassword.Append(uppercaseLetters[randomUppercaseLetterIndex]);
                            break;
                        case use_downCase:
                            int randomLowercaseLetterIndex = random.Next(0, lowercaseLetters.Length);
                            sbPassword.Append(lowercaseLetters[randomLowercaseLetterIndex]);
                            break;
                        case use_ssymbols:
                            int randomSpecialSymbolIndex = random.Next(0, digits.Length);
                            sbPassword.Append(specialSymbols[randomSpecialSymbolIndex]);
                            break;
                    }
                }
                if ((_numbers == true) && hasNumber.IsMatch(sbPassword.ToString()) == true)
                    quantity = quantity + 1;
                if ((_ssymbols == true) && hasSpecialSymbols.IsMatch(sbPassword.ToString()) == true)
                    quantity = quantity + 1;
                if ((_downCase == true) && hasLowerChar.IsMatch(sbPassword.ToString()) == true)
                    quantity = quantity + 1;
                if ((_upCase == true) && hasUpperChar.IsMatch(sbPassword.ToString())== true)
                    quantity = quantity + 1;
                howMuchNeeded = Convert.ToInt32(_numbers) + Convert.ToInt32(_ssymbols) + Convert.ToInt32(_downCase) + Convert.ToInt32(_upCase);
                if (quantity == howMuchNeeded)
                    correct = true;
            } while (!correct);
            return sbPassword.ToString();
        }
    }
}
