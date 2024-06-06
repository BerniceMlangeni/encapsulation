using System;
using System.Security.Cryptography.X509Certificates;

namespace program
{
    internal class Area
    {

        //define the breath and base which we will call breath
        public double breath;
         public double height;

        public double Getarea()
        {
            return 0.5*(breath * height);
        }

        public void Result()
        {
          Console.WriteLine("breath: " + "" +  breath);
           Console.WriteLine("height: " + "" + height);
            Console.WriteLine("Area = " + "" + Getarea());
        }

        static void Main(string[] args)
        {
           //creating an object for class area
            Area area = new Area();
           // area.Result();
            Console.WriteLine("Enter the breath");
           // Convert.ToDecimal(Console.ReadLine());
             area.breath = double.Parse(Console.ReadLine());

            
            Console.WriteLine("Enter the height");
           // Convert.ToDecimal(Console.ReadLine());
             area.height = double.Parse(Console.ReadLine());

            area.Result();
        }

    }
}
