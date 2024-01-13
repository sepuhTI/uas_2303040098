using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_2303040098
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.Write("> Masukan panjang jari jari: ");
                    double JariJari = Convert.ToDouble(Console.ReadLine());
                    Console.Write("> Masukan tinggi tabung: ");
                    double TinggiTabung = Convert.ToDouble(Console.ReadLine());
                    Console.Write("> Masukan tinggi kerucut: ");
                    double TinggiKerucut = Convert.ToDouble(Console.ReadLine());
                    Console.Write("> Masukan tinggi limas: ");
                    double TinggiLimas = Convert.ToDouble(Console.ReadLine());
                    Console.Write("> Masukan luas alas limas: ");
                    double LuasAlas = Convert.ToDouble(Console.ReadLine());
                    Console.Write("> Masukan panjang sisi: ");
                    double Sisi = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();


                    // Dua Bangunan
                    Console.WriteLine("Dua Bangunan");
                    DuaBangunan duaB = new DuaBangunan(JariJari, TinggiTabung, TinggiKerucut, LuasAlas, TinggiLimas);

                    Console.WriteLine("Volume tabung: {0}", duaB.VolTabung());
                    Console.WriteLine("Volume tabung dan kerucut: {0}", duaB.VolTabungKerucut());
                    Console.WriteLine("Volume tabung dan limas: {0}", duaB.VolTabungLimas());
                    Console.WriteLine();


                    // Tiga Bangunan
                    Console.WriteLine("Tiga Bangunan");
                    TigaBangunan tigaB = new TigaBangunan(Sisi, JariJari, TinggiTabung, TinggiKerucut, LuasAlas, TinggiLimas);

                    Console.WriteLine("Volume kubus: {0}", tigaB.VolKubus());
                    Console.WriteLine("Volume kubus tabung dan kerucut: {0}", tigaB.VolKubusTabungKerucut());
                    Console.WriteLine("Volume kubus tabung dan limas : {0}", tigaB.VolKubusTabungLimas());

                    Console.ReadKey();
                    return;
                }
                catch
                {
                    Console.WriteLine("Tolong hanya memasukan angka saja");
                }
            } while (true);
        }
    }
}
