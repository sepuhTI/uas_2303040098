using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_2303040098
{
    class Variabel
    {
        public double JariJari { get; protected set; }
        public double TinggiTabung { get; protected set; }
        public double TinggiKerucut { get; protected set; }
        public double LuasAlas { get; protected set; }
        public double TinggiLimas { get; protected set; }
        public double Sisi { get; protected set; }
        public double VolTabung()
        {
            return Math.PI * Math.Pow(JariJari, 2) * TinggiTabung;
        }
        public double VolKubus()
        {
            return Math.Pow(Sisi, 3);
        }
    }
}
