using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    internal class SeznamPojistenych
    {
        List<Osoba> seznam = new List<Osoba>();

        public void pridatOsobu()
        {
            string jmeno;
            string prijmeni;
            int vek;
            string tel_cislo;

            Console.WriteLine("Zadejte jméno pojistného:");
            jmeno = Console.ReadLine();
            Console.WriteLine("Zadejte příjmení:");
            prijmeni = Console.ReadLine();
            Console.WriteLine("Zadejte telefoní číslo:");
            tel_cislo = Console.ReadLine();
            Console.WriteLine("Zadejte věk:");
            vek = int.Parse(Console.ReadLine());

            seznam.Add(new Osoba(jmeno, prijmeni, vek, tel_cislo));

            Console.WriteLine("Data byla uložena. Pokračujte stiskem libovolné klávesy...\n");
            Console.ReadKey();

        }

        public void vypisSeznam()
        {
            foreach (Osoba o in seznam)
            {
                Console.WriteLine(o);

            }
            Console.WriteLine("Pokračujte stiskem libovolné klávesy...");
            Console.ReadKey();
        }

        public void vyhledavaniPojistneho()
        {
            Console.WriteLine("Zadejte jmeno pojistného:");
            string jmenoPojistneho;
            jmenoPojistneho = Console.ReadLine();

            Console.WriteLine("Zadejte príjmení:");
            string prijmeniPojistneho;
            prijmeniPojistneho = Console.ReadLine();

            foreach (Osoba o in seznam)
            {
                if (o.jmeno.Equals(jmenoPojistneho) && o.prijmeni.Equals(prijmeniPojistneho))
                {
                    Console.WriteLine($"{o.jmeno} {o.prijmeni} {o.vek} {o.tel_cislo}");
                }

            }
            Console.WriteLine("Pokračujte stiskem libovolné klávesy...");
            Console.ReadKey();
        }

    }
}
