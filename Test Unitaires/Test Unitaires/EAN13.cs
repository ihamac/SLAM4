using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Unitaires
{
    public class EAN13
    {
        private int[] ean13;
        public EAN13(int[] ean13)
        {

        }
        public int PoidsPair() {
            int position = 0;
            for(int i=0; i < ean13.Length; i++)
            {
                if (i % 2 == 0)
                {
                    position = position + ean13[i];
                }
            }
            return position;
        }
        public int PoidsImpair()
        {
            int position = 0;
            for (int i = 0; i < ean13.Length; i++)
            {
                if (i % 2 != 0)
                {
                    position = position + ean13[i];
                }
            }
            return position;
        }
        public int Reste()
        {
            return 0;
        }
        public int Cle()
        {
            return 0;
        }
        public override string ToString()
        {
            string s = "";
            return s;
        }
    }
}
