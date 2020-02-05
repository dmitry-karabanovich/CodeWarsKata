using System.Security.Cryptography.X509Certificates;

namespace Kata._7_kyu_kata
{
    //https://www.codewars.com/kata/56606694ec01347ce800001b
    public class Kata1
    {
        public static bool IsTriangle(int a, int b, int c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
    }
}