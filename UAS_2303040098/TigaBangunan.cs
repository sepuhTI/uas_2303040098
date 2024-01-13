using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_2303040098
{
    internal class TigaBangunan : Variabel
    {
        public TigaBangunan(double sisi, double jariJari,double tinggiTabung, double tinggiKerucut, double luasAlas, double tinggiLimas)
        {
            Sisi = sisi;
            JariJari = jariJari;
            TinggiTabung = tinggiTabung;
            TinggiKerucut = tinggiKerucut;
            LuasAlas = luasAlas;
            TinggiLimas = tinggiLimas;
        }

        public double VolKubusTabungKerucut()
        {
            double volKerucut = (1.0 / 3.0) * Math.PI * Math.Pow(JariJari, 2) * TinggiKerucut;
            return VolKubus() + VolTabung() + volKerucut;
        }

        public double VolKubusTabungLimas()
        {
            double volLimas = (1.0 / 3.0) * LuasAlas * TinggiLimas;
            return VolKubus() + VolTabung() + volLimas;
        }
    }
}
