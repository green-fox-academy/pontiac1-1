using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp81
{
    public class SharpieSet
    {
        public List<Sharpie> Sharpielist;

        public SharpieSet()
        {
            Sharpielist = new List<Sharpie>();
        }

        public int CountUsable()
        {
            int usable = 0;
            for (int i = 0; i < Sharpielist.Count; i++)
            {
                if (Sharpielist[i].InkAmt != 0)
                {

                    usable++;
                }
            }
            return usable;
        }
        public void RemoveEmpty()
        {
            for (int i = 0; i < Sharpielist.Count; i++)
            {
                if (Sharpielist[i].InkAmt == 0)
                {
                   Sharpielist.Remove(Sharpielist[i]);
                }
            }
        }

    }
}
