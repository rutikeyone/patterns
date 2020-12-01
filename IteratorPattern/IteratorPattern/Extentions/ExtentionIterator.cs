using IteratorPattern.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Extentions
{
    static class ExtentionIterator
    {

        public static IEnumerator<int> GetEnumerator(this Range range)
        {
            int Step = range.Start.Value < range.End.Value ? 1 : -1;
            for (int i = range.Start.Value; i <= range.End.Value; i += Step){
                yield return i;
            }
        }  
    }
}
