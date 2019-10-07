using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace StringCalculatorChallenge
{
    public static class Calculator
    {
        public static int AddNumber(string number)
        {
            int result = 0;
            try
            {
                Regex pattern = new Regex(@"([a-zA-Z])");
                var arrayNumber = number.Replace('\n', ',').Split(',');
                //Step #1
                if (string.IsNullOrEmpty(number))
                {
                    result = 0;
                }
                else if (number.Contains(",,"))
                {
                    var getNumber = number.Where(x => char.IsDigit(x)).ToArray();
                    result = getNumber.Sum(n => int.Parse(n.ToString()));
                }
                else if (number.Contains(",") && !pattern.IsMatch(number))
                {
                    result = arrayNumber.Sum(n => int.Parse(n));
                }
                else if (pattern.IsMatch(number))
                {
                    var getNumber = number.Where(x => char.IsDigit(x)).ToArray();
                    result = getNumber.Sum(n => int.Parse(n.ToString()));
                }
                else if (arrayNumber.Any(n => int.Parse(n) < 0))
                {
                    return 1;
                }
                else
                {
                    result = int.Parse(number);
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return result;
        }
    }
}