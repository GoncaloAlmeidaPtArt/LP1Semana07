using System;

namespace ColorSpheres
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Sphere esferaUm = new Sphere( 100, 5);

            esferaUm.Throw();

            esferaUm.Throw();

            Console.WriteLine(esferaUm.GetTimesThrow());

            
        }
    }
}
