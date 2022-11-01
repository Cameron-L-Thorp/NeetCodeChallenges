using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErikChallenge
{
    public class SequenceGenerator : ISequenceGenny
    {
        public List<int> SequenceResult(int start, int length)
        {
            List<int> result = new List<int>();

            for(int i = 0; i < length ; i++)
            {
                result.Add(start);
                start++;
            }
            return result;
        }
    }
}
