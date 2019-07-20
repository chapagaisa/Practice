using System;
namespace HelloWorld
{
    public class Rectangle
    {
        //memeber variables
        double length;
        double width;

        public void Acceptdetails()
        {
            length = 3.4;
            width = 2.3;
        }

        public double GetArea()
        {
            double area;
            area = length * width;
            return area;
        }

        public void Display()
        {
            Console.WriteLine("Length: {0|", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());

        }


    }


}
