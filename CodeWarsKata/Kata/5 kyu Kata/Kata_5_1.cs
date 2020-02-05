namespace Kata._5_kyu_Kata
{
    public class Kata_5_1
    {
        //https://www.codewars.com/kata/54521e9ec8e60bc4de000d6c
        public static int MaxSequence(int[] arr)
        {
            var sum = 0;
            var maxSum = 0;
            foreach (var t in arr)
            {
                sum += t;
                if (sum > maxSum)
                    maxSum = sum;
                if (sum < 0)
                    sum = 0;
            }

            return maxSum;
        }
    }
}
