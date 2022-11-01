using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErikChallenge
{
    public class RandomSequence : IRandomGenny
    {
        public List<int> RandomResult(int length)
        {
            Random random = new Random();
            List<int> result = new List<int>();
            for( int i = 0; i < length; i++)
            {
                result.Add(random.Next(length, (length + length)));
            }
            return result;
        }
    }
}
