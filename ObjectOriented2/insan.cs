using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented2
{
    internal class insan
    {
        public insan() {
            ad = "Esra";
            soyad = "UÇAR";
            yas = 28;
            kilo = 60;
            boy= 1.60;
        }

        public void Tanis() {
            Console.Write("Ben: {0} {1}... Boyum {2}, Kilom {3}, Yasim {4}",ad,soyad,boy,kilo,yas);           
        }

        public string ad { get; set; }
        public string soyad { get; set; }
        public double boy { get; set; }
        public int kilo { get; set; }
        public int yas { get; set; }





    }
}

