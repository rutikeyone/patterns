using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Classes
{
    public class Product
    {
        private List<object> Parts = new();

        public void Add(object part)
        {
            this.Parts.Add(part);
        }

        public string ListParts()
        {
            string Result = string.Empty;

            for(int i = 0; i < Parts.Count; i++)
            {
                Result += Parts[i].GetType().Name + " ";
            }


            return Result;
        }
    }
}
