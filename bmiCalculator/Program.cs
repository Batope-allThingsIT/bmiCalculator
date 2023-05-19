
using System;
//Name: Babatope Ayeni
//Date: 09/18/2021
//Unit 3: C# Lab 3 – Body Mass Index calculator

namespace bmiCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double meters;
            double heightInInches;
            double kilograms;
            double lbs;
            double bmi;
            string classification;


            //Student Name
            Console.WriteLine("Student Name: Babatope Ayeni\n");

            //Enter meters
            Console.Write("Enter weight :");
            lbs = Convert.ToDouble(Console.ReadLine());


            //Enter meters
            Console.Write("Enter Height in Inches :");
            heightInInches = Convert.ToDouble(Console.ReadLine());

            // convert kilogram to meters
            kilograms = lbs / 2.2046;

            // convert inches to meters
            meters = heightInInches / 39.37;


            //bmi
            bmi = kilograms / (meters * meters);


           Console.WriteLine("\nBMI: " + bmi);


            // calculate BMI category
            // public static String bmiClassification(double bmi)
            // {
            //  String classification = "";

            // string classification;

            //  string classification;
          

            if (bmi < 18.5)
                {
                    classification = "Underweight";
                }
                else if ( bmi < 25.0)
                {
                    classification = "Normal";
                }
                else if ( bmi < 30.0)
                {
                    classification = "Overweight";
                }
                else 
                {
                    classification = "Obese";
                }
            


            Console.WriteLine("\nBMI:$ " + bmi.ToString("0.00")+ " category is " + classification);



        }



 

    }
}
