using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    public class Mahasiswa
    {
        //properties
        public string NIM { get; set; }
        public string Nama { get; set; }
        public float IPK { get; set; }
        
        //method
        public void Regristrasi()
        {
            Console.WriteLine("Nama : {0}", Nama);
            Console.WriteLine("NIM  : {0}", NIM);
            Console.WriteLine("IPK  : {0}", IPK);
            Console.WriteLine("\nTelah melakukan regristrasi");
        }
        public void IsiKRS()
        {
            Console.WriteLine("{0} Sedang melakukan proses KRS", Nama);
        }
    }
}
