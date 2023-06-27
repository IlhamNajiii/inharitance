namespace person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            person person1 = new person("Nana", 19);
            person1.InfoPerson();

            Karyawan Karyawan1 = new Karyawan("Adel", 18);
            Karyawan1.InfoPerson();
            Karyawan1.InfoPerson("Mahasiswa");

            Console.ReadKey();
        }
    }
}