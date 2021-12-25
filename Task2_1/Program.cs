using System;

namespace Task2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            DiagonalMatrix dm = new DiagonalMatrix();
            Console.WriteLine($"dm.Size => {dm.Size}");

            dm = new DiagonalMatrix(0,1,2147483647, -2147483648, 4,5,0,11);
            Console.WriteLine($"dm.Size => {dm.Size}");
            Console.WriteLine($"dm[4, 4] => {dm[4, 4]}");
            dm[4, 4] = 5;
            Console.WriteLine($"dm[4, 4] => {dm[4, 4]}");
            Console.WriteLine("dm.ToString() =>");
            Console.WriteLine(dm);
            DiagonalMatrix dm1 = new DiagonalMatrix(1,2,3,4);
            Console.WriteLine($"dm1.Track() => {dm1.Track()}");

            DiagonalMatrix dm2 = new DiagonalMatrix(0, 1, 2, 10, 5);
            Console.WriteLine($"dm1.Equals(dm2) => {dm1.Equals(dm2)}");
            Console.WriteLine("dm1.Add(dm2) =>");
            Console.WriteLine(dm1.Add(dm2));

            Console.WriteLine($"dm1.GetHashCode() => {dm1.GetHashCode()}");
            Console.WriteLine($"dm2.GetHashCode() => {dm2.GetHashCode()}");

            DiagonalMatrix dm3 = new DiagonalMatrix(0, 1, 2, 10, 5);
            Console.WriteLine($"dm2.Equals(dm3) => {dm2.Equals(dm3)}");
            Console.WriteLine($"dm3.GetHashCode() => {dm3.GetHashCode()}");
        }
    }
}
