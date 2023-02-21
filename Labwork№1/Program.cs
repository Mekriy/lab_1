using System;

namespace Labwork_1
{
    class ColorPoint
    {
        private int x;
        private int y;
        private int red;
        private int green;
        private int blue;

        public int X
        {
            get => x;
            set
            {
                x = value;
            }
        }
        public int Y
        {
            get => y;
            set
            {
                y = value;
            }
        }
        public int Red
        {
            get => red;
            set
            {
                if (value < 0 || value > 255)
                    throw new ApplicationException("Invalid Red Value");
                else red = value;
            }
        }
        public int Green
        {
            get => green;
            set
            {
                if (value < 0 || value > 255)
                    throw new ApplicationException("Invalid Green Value");
                else green = value;
            }
        }
        public int Blue
        {
            get => blue;
            set
            {
                if (value < 0 || value > 255)
                    throw new ApplicationException("Invalid Blue Value");
                else blue = value;
            }
        }
        public ColorPoint()
        {
            x = 0; y = 0;
            red = 0; green = 0; blue = 0;
        }
        public ColorPoint(int red, int green, int blue)
        {
            X = 0; Y = 0;
            Red = red; Green = green; Blue = blue;
        }
        public ColorPoint(int x, int y) { 
            X = x; Y = y;
            Red = 0; Green = 0; Blue = 0;
        }
        public ColorPoint(int x, int y, int red, int green, int blue)
        {
            X = x; Y = y;
            Red = red; Green = green; Blue = blue;
        }
        public void ChangeRGB(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }
        public override string ToString()
        {
            return "Information about object:\n1) Axis: " + X + ", " + Y + "\n2) RGB color code: " + Red + ", " + Green + ", " + Blue + ".";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Labwork #1");
            ColorPoint obj1 = new ColorPoint();
            ColorPoint obj2 = new ColorPoint(5, 2);
            ColorPoint obj3 = new ColorPoint(100, 100, 100);
            ColorPoint obj4 = new ColorPoint(3, 6, 255, 255, 255);
            Console.WriteLine(obj1.ToString());
            Console.WriteLine(obj2.ToString());
            Console.WriteLine(obj3.ToString());
            Console.WriteLine(obj4.ToString());
            obj1.ChangeRGB(33, 33, 33);
            Console.WriteLine(obj1.ToString());
            Console.ReadLine();
        }
    }
}
