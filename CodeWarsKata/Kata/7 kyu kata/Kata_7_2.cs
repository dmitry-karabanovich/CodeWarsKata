using System.Collections.Generic;
using System.Linq;

namespace Kata._7_kyu_kata
{
    public class Kata_7_2
    {
        public static IEnumerable<string> FriendOrFoe(string[] names)
        {
            return names.Where(x => x.Length == 4);
        }
    }
}
