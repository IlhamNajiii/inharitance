using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person
{
    internal class person
    {
        public string Name { get; set; }
        public int Umur { get; set; }

        public person(string name, int umur)
        {
            Name = name;
            Umur = umur;
        }

        public void InfoPerson()
        {
            Console.WriteLine("\nNama saya {0}, dan umur saya {1}", Name, Umur);
        }
    }
    class Karyawan : person
    {
        string idKaryawan { get; set; }
        string subjek { get; set; }

        public Karyawan(string name, int umur) : base(name, umur) { }
        public void InfoPerson(string subjek)
        {
            this.subjek = subjek;
            Console.WriteLine("Saya disini sebagai {0}", this.subjek);
        }
    }
}
