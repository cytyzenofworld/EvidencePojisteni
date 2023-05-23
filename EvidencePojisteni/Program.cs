namespace EvidencePojisteni
{
    class Hlavni
    {
        static void VytiskniMenu()
        {
            string menuText = @"------------------------
Evidence Pojistenych
------------------------
Vyberte si akci:
1 - Pridat nového Pojisteneho
2 - Vypsat vsechny pojistene
3 - Vyhledat pojisteneho
4 - Konec";
            Console.WriteLine(menuText);



        }

        static void Main(string[] args)
        {
            SeznamPojistenych seznam_osob = new SeznamPojistenych();

            string imput;
            while (true)
            {
                VytiskniMenu();
                imput = Console.ReadLine();

                if (imput == "1")
                {
                    seznam_osob.pridatOsobu();
                }
                if (imput == "2")
                {
                    seznam_osob.vypisSeznam();
                }
                if (imput == "3")
                {
                    seznam_osob.vyhledavaniPojistneho();
                }
                if (imput == "4")
                {
                    break;

                }

                Console.Clear();
            }

        }

    }

}