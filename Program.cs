using System.Collections.Generic;
using System.Linq;

namespace Formkontrollsystem
{
    internal class Program
    {
        static void Main()
        {

            List<Form> list = new List<Form>();


            list.Add(new Triangle("triangle1", "grønn", 3.5, 4.6));
            list.Add(new Triangle("triangle2", "blå", 2.9, 100.66));

            list.Add(new Sirkel("sirkel1", "gul", 4.8));
            list.Add(new Sirkel("sirkel2", "blå", 4.12));

            list.Add(new Rektangel("rektangel1", "svart", 4.6, 4.1));
            list.Add(new Rektangel("rektangel2", "blå", 4.1, 10.1));


            //Default liste
            Console.WriteLine("Liste alle elementene i listen!");
            Console.ReadKey();
            ListeAlleElementeneIListen(list);

            //TotalArealAvAlleFormer
            Console.WriteLine("TotalArealAvAlleFormerIListen");
            Console.ReadKey();
            TotalArealAvAlleFormerIListen(list);

            //Sortering med list.Sort()
            /*Console.WriteLine("Sortering med list.Sort()");
            Console.ReadKey();
            SortertListeEtterAreal(list);
            ListeAlleElementeneIListen(list);*/

            //BobbleSortering
            Console.WriteLine("Sortering med bobblesort");
            Console.ReadKey();
            BobbleSortertListeEtterAreal(list);
            ListeAlleElementeneIListen(list);

            //SortListByFarge
            Console.WriteLine("OrderByFarge med Linq");
            Console.ReadKey();
            PrintSortedListByFarge(list);

        }


        private static void TotalArealAvAlleFormerIListen(List<Form> list)
        {
            double TotalAreal = 0;

            foreach (Form Object in list)
            {
                TotalAreal += Object.BeregnAreal();
            }
            Console.WriteLine($"Total areal av alle objekter i listen: {TotalAreal}");
        }

        private static void ListeAlleElementeneIListen(List<Form> list)
        {
            foreach (Form Object in list)
            {
                Console.WriteLine($"Navn: {Object.Navn}");
                Console.WriteLine($"Farge: {Object.Farge}");
                Console.WriteLine($"Areal: {Object.BeregnAreal()}");
                Console.WriteLine("\n");
            }
        }

        private static void PrintSortedListByFarge(List<Form> list)
        {
            //Vi oppretter en ny filtrert liste etter farge (sortedList) (case-sensitive)
            var SortedListByFarge = list.OrderBy(Object => Object.Farge).ToList();
            //Case-insensitive filtrering
            //var SortedListByFarge = list.OrderBy(Object => Object.Farge StringComparer.OrdinalIgnoreCase).ToList();
            ListeAlleElementeneIListen(SortedListByFarge);
        }

        /*private static void SortertListeEtterAreal(List<Form> list)
        {
            list.Sort((x, y) => x.BeregnAreal().CompareTo(y.BeregnAreal()));

            Console.WriteLine($"\nSortedListEtterAreal:\n");
        }*/

        //Samme sorteringen med bobblesortering
        private static void BobbleSortertListeEtterAreal(List<Form> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    if (list[j].BeregnAreal() > list[j + 1].BeregnAreal())
                    {
                        // Swap list[j] and list[j+1]
                        Form temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
        }

    }
}
    /*Oppgave: Formkontrollsystem

    Ditt oppdrag er å lage et enkelt system for håndtering av ulike former (shapes) ved hjelp av arv i C#.
    Del 1: Klasser og Arv

    Lag følgende klasser:

        Form (Shape):
            En abstrakt klasse som representerer en generell form.
            Egenskaper: Navn, Farge.
            Metode: BeregnAreal() skal være abstrakt og returnere arealet av formen.


        Sirkel (Circle):
            Arver fra Form.
            Egenskap: Radius.
            Implementer metoden BeregnAreal() for å beregne arealet av sirkelen.


        Rektangel (Rectangle):
            Arver fra Form.
            Egenskaper: Lengde, Bredde.
            Implementer metoden BeregnAreal() for å beregne arealet av rektangelet.


        Trekant (Triangle):
            Arver fra Form.
            Egenskaper: Base, Høyde.
            Implementer metoden BeregnAreal() for å beregne arealet av trekanten.


    Del 2: Hovedprogram (Main)


    I hovedprogrammet, gjør følgende:

        Opprett en liste av Form-objekter.
        Legg til minst to instanser av hver formtype (sirkel, rektangel, trekant) i listen.
        Gå gjennom listen og skriv ut informasjon om hver form, inkludert navn, farge og beregnet areal.


    Del 3: Ekstra funksjonalitet


        Totalt Areal:
            Implementer en metode i hovedprogrammet for å beregne og skrive ut det totale arealet av alle formene i listen.


        Sortering:
            Implementer en metode for å sortere formene i listen basert på areal (fra lavest til høyest).


        Fargefiltrering:
            Implementer en metode for å filtrere formene i listen basert på farge og skrive ut resultatet.*/
