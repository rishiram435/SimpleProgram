using System;

namespace SimpleProgram
{
    static class Constants
    {
        public const double PI= 3.14159;
    }
    public class getArray
    {
        public int Average(int[] array,int size)
        {
            int sum = 0;
            int average = 0;
            for (int i = 0; i < size; i++)
            {
                sum += array[i];
             
            }
            average = sum / size;
            return average;

        }

        public double Average(double[] array, int size)
        {
            double sum = 0.0;
            double average = 0.0;
            for (int i = 0; i < size; i++)
            {
                sum += array[i];
            }
            average = sum / size;
            return average;

        }

        public static object BinarySearchIterative(int[] inputArray, int key)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    return ++mid;
                }
                else if (key < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return "Nil";
        }

        public void GetArrayInt()
        {
            int size;
            Console.WriteLine("Enter the Size :");
            size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("Enter the Elements of the Array : ");
            for (int i = 0; i < size; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            int len = a.Length;
            Console.Write("The average of your integer array: "+ Average(a, len));
        }

        public void getArrayDouble()
        {
            int size;
            Console.WriteLine("\nEnter the Size :");
            size = Convert.ToInt32(Console.ReadLine());
            double[] b = new double[size];
            Console.WriteLine("Enter the Elements of the Array : ");
            for(int i=0; i< size; i++)
            {
                b[i] = Convert.ToDouble(Console.ReadLine());
            }
            int len = b.Length;
            Console.Write("The average of your double array: " + Average(b, len));
            Console.WriteLine("");
        }

    }
    public class Circle
    {
        public string Model { get; set; }
        private double radius;

        public double getRadius()
        {
            return radius;
        }
        public void setRadius(double val)
        {
            radius = val;
        }
        // default constructors
        public Circle()
        {
            radius = 1.0;
            Console.Write(radius);
        }
        public Circle(double radius)
        {
            this.radius = radius;

        }

        public void GetDiameter(double radius)
        {
            double diameter = 2 * radius;
            Console.WriteLine(diameter);
        }

        public void getCircumference(double radius)
        {
            double circumference = 2 * Constants.PI * radius;
            Console.Write(circumference);
        }
    }
    public static class SimpleProgram
    {
         public static void Main(string[] args)
        {
            // Intialization of c
            double c;
            // Intialization of f
            double f = 98.6;
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            double[] array2 = new double[] { 1.5, 2.5, 3.5, 4.5, 5.5, 6.5, 7.5, 8.5, 9.5 };

            // Converting the Fahrenheit Scale to Celsius Scale
            c = (f - 32) * 5 / 9;
            // Temp Conversion
            Console.WriteLine("\nThe conversion of the Fahrenheit Scale to Celsius Scale: " + c + "°C");
            // Instantiate the circle object
            var circle = new Circle();
            circle.setRadius(5.0);
            Console.WriteLine("");
            //  Instantiate the array object
            var array3 = new getArray();
            array3.GetArrayInt();
            array3.getArrayDouble();
            getArray.BinarySearchIterative(array, 3);


            
        }
    
    }
}
