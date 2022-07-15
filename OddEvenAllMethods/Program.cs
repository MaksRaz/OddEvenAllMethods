using System;
using System.Linq;

namespace OddEvenMethods
{
    public static class OddOrEvenClass
    {
        public static bool IsOddByRemainder(int num) => num % 2 == 1 ? true : false;

        public static bool IsOddByLastBinaryNum(int num)
        {
            if ((num & 1) == 1)
            {
                return true;
            }

            return false;
        }

        public static bool IsOddByLoop(int num)
        {
            while (num > 1)
            {
                num -= 2;
            }

            if (num == 1)
            {
                return true;
            }

            return false;
        }

        public static bool IsOddByString(int num)
        {
            var temp = num.ToString();
            var oddNumbers = new int[] { '1', '3', '5', '7' };
            if (oddNumbers.Contains(temp[^1]))
            {
                return true;
            }

            return false;
        }

        public static bool IsOddByDivision(int num)
        {
            var temp = num.ToString();
            Int32.TryParse(new string(temp.Reverse().ToArray()), out num);
            while (num > 10)
            {
                num /= 10;
            }

            var oddNumbers = new int[] { 1, 3, 5, 7 };
            if (oddNumbers.Contains(num))
            {
                return true;
            }

            return false;
        }

        public static bool IsOddByLastBinaryString(int num)
        {
            var temp = Convert.ToString(num, 2);

            if (temp[^1] == '1')
            {
                return true;
            }

            return false;
        }
    }

}
