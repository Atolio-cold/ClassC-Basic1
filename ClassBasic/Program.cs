using System;
using System.Collections.Generic;

namespace ZooApp
{
    // Klasa bazowa - Zwierze
    public abstract class Zwierze
    {
        public string Nazwa { get; set; }
        public int Wiek { get; set; }

        // Konstruktor
        public Zwierze(string nazwa, int wiek)
        {
            Nazwa = nazwa;
            Wiek = wiek;
        }

        // Abstrakcyjna metoda do wydania dźwięku, musi być implementowana w klasach dziedziczących
        public abstract void WydajDzwiek();

        // Metoda do wyświetlania podstawowych informacji o zwierzęciu
        public virtual void PokazInfo()
        {
            Console.WriteLine($"Zwierzę: {Nazwa}, Wiek: {Wiek} lat");
        }
    }

    // Klasa Lew dziedzicząca po Zwierze
    public class Lew : Zwierze
    {
        public Lew(string nazwa, int wiek) : base(nazwa, wiek)
        {
        }

        // Implementacja abstrakcyjnej metody wydania dźwięku
        public override void WydajDzwiek()
        {
            Console.WriteLine("Rooaarr!");
        }

        // Nadpisanie metody PokazInfo
        public override void PokazInfo()
        {
            base.PokazInfo();
            Console.WriteLine("Lew jest królem dżungli!");
        }
    }

    // Klasa Panda dziedzicząca po Zwierze
    public class Panda : Zwierze
    {
        public Panda(string nazwa, int wiek) : base(nazwa, wiek)
        {
        }

        // Implementacja abstrakcyjnej metody wydania dźwięku
        public override void WydajDzwiek()
        {
            Console.WriteLine("Panda mówi: Grrr...");
        }

        // Nadpisanie metody PokazInfo
        public override void PokazInfo()
        {
            base.PokazInfo();
            Console.WriteLine("Panda jest urocza i je bambusy!");
        }
    }

    // Klasa Zoo, która będzie zarządzać zwierzętami
    public class Zoo
    {
        private List<Zwierze> zwierzeta = new List<Zwierze>();

        // Metoda do dodawania zwierząt do zoo
        public void DodajZwierze(Zwierze zwierze)
        {
            zwierzeta.Add(zwierze);
        }

        // Metoda do wyświetlania wszystkich zwierząt w zoo
        public void PokazZwierzęta()
        {
            foreach (var zwierze in zwierzeta)
            {
                zwierze.PokazInfo();
                zwierze.WydajDzwiek();
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Tworzenie instancji obiektów
            Lew lew = new Lew("Simba", 5);
            Panda panda = new Panda("Po", 3);

            // Tworzenie zoo i dodawanie zwierząt
            Zoo zoo = new Zoo();
            zoo.DodajZwierze(lew);
            zoo.DodajZwierze(panda);

            // Pokazywanie informacji o zwierzętach
            zoo.PokazZwierzęta();
        }
    }
}
