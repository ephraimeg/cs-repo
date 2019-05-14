using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study.MLinq
{
    public class MLinq
    {
        public void Main()
        {
            int[] scores = new int[] { 97, 92, 82, 60 };

            IEnumerable<int> scoreQuery = from score in scores where score > 80 select score;

            foreach (int i in scoreQuery)
            {
                Console.Write(i + " ");
            }
        }
    }
}
