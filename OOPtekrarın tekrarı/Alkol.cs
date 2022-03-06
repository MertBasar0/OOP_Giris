using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPtekrarın_tekrarı
{
    public class Alkol
    {
        public int AlkolOran { get; set; }
        public int CC { get; set; }

        private string _marka;

        public string Marka
        {
            get 
            { 
                return _marka;
            }
            set 
            {
                if (value =="tuborg")
                {
                    value = "efes";
                }
                _marka = value; 
            
            }
        }



        public Alkol(string marka)
        {
            Marka = marka;
        }

        public Alkol(int oran, int cc, string marka)
        {
            AlkolOran = oran;
            CC = cc;
            Marka = marka;
        }
    }

    public class Bira : Alkol 
    {
        public bool SicakMi { get; set; }
        public Bira(bool sicak,string marka2):base(marka2)
        {


            SicakMi = sicak;

            if (SicakMi == true)
            {
                Console.WriteLine("getirme");
            }
            else
            {
                Console.WriteLine("getir içelim");
            }
        }
    }

    //public class Sarap : Alkol
    //{
    //    public string Renk { get; set; }
    //}

    //public class Viski : Alkol
    //{
    //    public string Icerik { get; set; }
    //}
}
