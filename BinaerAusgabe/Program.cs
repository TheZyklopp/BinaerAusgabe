using System;

namespace BinaerAusgabe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben Sie eine Zahl zwischen 0 und 255 ein:");
            string eingabe = Console.ReadLine();

            byte zahl;
            if (!byte.TryParse(eingabe, out zahl))
            {
                Console.WriteLine("Fehlerhafte Eingabe!");
                return;
            }

            string binary = Byte2Binary(zahl); //sagt das der string binary aus der umgewandelten zahl entstehen soll.
            string hexadecimal = Byte2Hexadecimal(zahl);

            Byte2Binary(zahl); //gibt die zahl Weiter an Byte2Binary
            Byte2Hexadecimal(zahl);

            Console.WriteLine(binary); //schreibe umgewandelte Zahl
            Console.WriteLine(hexadecimal);

        }
        public static string Byte2Binary(byte number)
        {
            string binary = "";
            for (int i = 0; i < 8; i++) //schleife über 8 wiederholungen da ein byte 8 bit hat
            {
                // Prüfen, ob das niedrigstwertige Bit 1 oder 0 ist
                binary = (number % 2) + binary; // teilt die zahl durch 2 und rechnet die zahl auf die binär zahl dazu.
                // Die Zahl um ein Bit nach rechts verschieben
                number = (byte)(number / 2);
            }
            return binary;
        }

        public static string Byte2Hexadecimal(byte number)
        {
            return number.ToString("X2");
        }
    }
}
