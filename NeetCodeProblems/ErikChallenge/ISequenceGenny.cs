using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErikChallenge
{
    public interface ISequenceGenny
    {
        public List<int> SequenceResult(int start, int length);
    }
}
