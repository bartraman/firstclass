using System;
using System.Collections.Generic;

namespace firstclass
{
    class Program
    {
        string kenteken;

        static void Main(string[] args)
        {
            List<car> Autolijst = new List<car>();

            if (menu() == 1)
            {
                OpvullenAuto(Autolijst);
                Console.SetCursorPosition(12, 12);
            }
            if (menu() == 2)
            {
                output(Autolijst);
            }
        }


        private static int menu()
        {
            do
            {
                Console.WriteLine($"(1) Een auto inlezen.");
                Console.WriteLine($"(2) Auto's weergeven.");
                Console.WriteLine($"(0) Menu aflsuiten");
                return Convert.ToInt32(Console.ReadLine());
            } while (Convert.ToInt32(Console.ReadLine()) > 2);
        }

        private static void output(List<car> AutoLijst)
        {
            foreach (car Auto in AutoLijst)
            {
                int i = 0;
                i++;
                Console.WriteLine($"Auto {i}:");
                Console.WriteLine($"Kenteken: {Auto.strKenteken}");
                Console.WriteLine($"Merk: {Auto.strMerk}");
                Console.WriteLine($"Kleur: {Auto.strColor}");
                Console.WriteLine($"Km-Stand: {Auto.intKmstand}");
                Console.WriteLine("");
            }
        }

        private static void OpvullenAuto(List<car> autolijst)
        {
            do
            {
                car Auto = new car();
                Console.Write("Geef het kenteken in: ");
                Auto.strKenteken = Console.ReadLine();
                Console.Write("Geef het merk in: ");
                Auto.strMerk = Console.ReadLine();
                Console.Write("Geef het kleur in: ");
                Auto.strColor = Console.ReadLine();
                Console.Write("Geef het kilometerstand in: ");
                Auto.intKmstand = Convert.ToInt32(Console.ReadLine());
                autolijst.Add(Auto);
                Console.WriteLine("Wilt u het programma nog eens draaien?");
            } while ((Console.ReadLine().Substring(0, 1).ToUpper()) == "J");

        }
    }
}
