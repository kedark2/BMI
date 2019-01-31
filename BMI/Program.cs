using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            double Weight;
            double Height;
                  
            Console.WriteLine("Enter Weight(kg): ");
            Weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Height(cm): ");
            Height = Convert.ToDouble(Console.ReadLine());

            double HeightInMeter = Height / 100;
            double BMI = Weight/(HeightInMeter*HeightInMeter);

            Console.Write("Your BMI is = " + BMI );
            if(BMI<10.5){
                Console.Write(" You are UnderWeight. Eat more." );
            }
            if(BMI>18.5 && BMI < 24.9){
                Console.Write(" You are normal." );
            }
            if (BMI > 24.9 && BMI < 29.9)
            {
                Console.Write(" You are OverWeight. Eat Less." );
            }
            if (BMI > 30)
            {
                Console.Write(" You are OBESE. Don't eat at all.");
            }

            Console.Read();
        }
    }
}
