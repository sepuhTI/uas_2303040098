using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_2303040098
{
    internal class DuaBangunan : Variabel
    {
        public DuaBangunan(double jariJari, double tinggiTabung, double tinggiKerucut, double luasAlas, double tinggiLimas)
        {
            JariJari = jariJari;
            TinggiTabung = tinggiTabung;
            TinggiKerucut = tinggiKerucut;
            LuasAlas = luasAlas;
            TinggiLimas = tinggiLimas;
        }

        public double VolTabungKerucut()
        {
            double volKerucut = (1.0 / 3.0) * Math.PI * Math.Pow(JariJari, 2) * TinggiKerucut;
            return VolTabung() + volKerucut;
        }

        public double VolTabungLimas()
        {
            double volLimas = (1.0 / 3.0) * LuasAlas * TinggiLimas;
            return VolTabung() + volLimas;
        }
    }
}
