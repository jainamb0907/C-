using System;
using System.Runtime.InteropServices;

namespace LSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Apple apple = new Orange();
            Console.WriteLine(apple.GetColor()); //print Orange
            */

            IFruit fruit = new Orange();
            Console.WriteLine($"Color of Orange: {fruit.GetColor()}");
            fruit = new Apple();
            Console.WriteLine($"Color of Apple: {fruit.GetColor()}");
            Console.ReadKey();
        }
    }

    public interface IFruit //Fruit can be any type and any color
    {
        string GetColor();
    }

    public class Apple : IFruit
    {
        public string GetColor()
        {
            return "Red";
        }
    }

    public class Orange : IFruit
    {
        public string GetColor()
        {
            return "Orange";
        }
    }
    /*
    public class Apple
    {
        public virtual string GetColor()
        {
            return "Red";
        }
    }
    public class Orange : Apple
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }
    */
}
