namespace Kata._6_kyu_kata
{
    //https://www.codewars.com/kata/5839edaa6754d6fec10000a2
    public class Kata_6_1
    {
        public static char FindMissingLetter(char[] array)
        {
            for (var i = 0; i < array.Length - 1; i++)
            {
                if (array[i + 1] - array[i] == 2)
                {
                    return (char) (array[i] + 1);
                }
            }

            return ' ';
        }
    }
}
