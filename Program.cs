namespace MaaKalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //meil on münt, mille diameeter on 25.75 mm
            //Arvutada välja Maa ümbermõõt ja mitu münti
            //Mahub järjestikku ümber Maa
            //Arvutuses tohib kasutada ainult mündi diameetrit ja Maa raadiust
            double earthRadius = 6371000.0;

            double circumference = 2 * Math.PI * earthRadius;


            string googolplex = "10^(10^100)";

            Console.WriteLine("Maa ümbermõõt: " + circumference + " м");
            Console.WriteLine("Googolplex: " + googolplex);

            Console.WriteLine("\nMitu 1/googolplex'iga võrduvat 'pikkusühikut' mahuks ümber Maa?:");
            Console.WriteLine("N = C * googolplex = " + circumference + " * " + googolplex);
        }
    }
}
