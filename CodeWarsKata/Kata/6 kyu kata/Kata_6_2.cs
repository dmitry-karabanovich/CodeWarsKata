namespace Kata._6_kyu_kata
{
    //https://www.codewars.com/kata/54da539698b8a2ad76000228
    public class Kata_6_2
    {
        public static bool IsValidWalk(string[] walk)
        {
            if (walk.Length != 10)
            {
                return false;
            }

            int n = 0,
                s = 0,
                w = 0,
                e = 0;

            foreach (var step in walk)
            {
                switch (step)
                {
                    case "n":
                        n++;
                        break;
                    case "s":
                        s++;
                        break;
                    case "w":
                        w++;
                        break;
                    case "e":
                        e++;
                        break;
                }
            }

            return n == s && w == e;
        }
    }
}
