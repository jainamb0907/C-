using System.ComponentModel.Design;

namespace LSP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Menu:
            Console.WriteLine("----User Menu----");
            Console.WriteLine(
                "Choose from the below options:\n1. Area of Reactangle\n2. Area of Square"
            );
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Shape shape = new Shape();
                Console.WriteLine("Enter general Width");
                shape.Width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter general Height");
                shape.Height = Convert.ToInt32(Console.ReadLine());

                shape.calcArea();
            }
            else if (choice == 2)
            {
                Shape shape = new Square();
                Console.WriteLine("Enter general Dimention");
                shape.Width = Convert.ToInt32(Console.ReadLine());

                shape.calcArea();
            }
            else
            {
                Console.WriteLine("Enter valid input from the Menu");
                Console.WriteLine("Do you want to Continue? press Y for Yes and N for No");
                string ch = Console.ReadLine();
                if (ch == "Y" || ch == "y")
                {
                    goto Menu;
                }
                else
                {
                    for (int i = 0; i < 1; i++)
                    {
                        break;
                    }
                }
            }
        }
    }

    class Shape : IShape
    {
        public virtual int Height { get; set; }
        public virtual int Width { get; set; }

        public virtual void calcArea()
        {
            Console.WriteLine(this.Height * this.Width);
        }
    }

    class Rectangle : Shape
    {
        public override void calcArea()
        {
            Console.WriteLine(this.Height * this.Width);
        }
    }

    class Square : Shape
    {
        private int _height;
        private int _width;
        public override int Height
        {
            get { return _height; }
            set
            {
                _height = value;
                _width = value;
            }
        }

        public override int Width
        {
            get { return _width; }
            set
            {
                _width = value;
                _height = value;
            }
        }

        public override void calcArea()
        {
            Console.WriteLine(this.Height * this.Width);
        }
    }

    public interface IShape
    {
        public void calcArea();
    }
}
