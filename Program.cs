using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char choices;
            char adds;
            Console.WriteLine("Please input the Order \n Choices: \n [A] Regular Burger(Buy 1 get 1) = 40 \n [B] Cheese Burger(Buy 1 get 1) = 50 " +
                " \n [C] Hotdog(Buy 1 get 1) = 37 \n [D] Hungarian = 70 \n [E] Footlong = 56\n [F] Egg Sandwich = 20 \n Adds On \n [1] Egg = 15\n [2] Beef = 25\n [3] Cheese = 5");
            choices = char.Parse(Console.ReadLine());

            if (choices == 'A')
            {
                Console.WriteLine("Please input adds on ");
                adds = char.Parse(Console.ReadLine());

                if (adds == '1')
                {

                    Console.WriteLine("Regular Burger with Egg is being prepared \nThat would be 70 Pesos \nPlease wait");
                }
                else if (adds == '2')
                {
                    Console.WriteLine("Regular Burger with Extra Beef is being prepared \nThat would be 90 Pesos \nPlease wait");
                }
                else if (adds == '3')
                {
                    Console.WriteLine("Regular Burger with Cheese is being prepared \nThat would be 50 Pesos \nPlease wait");
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }

            }
            else
            {


                if (choices == 'B')
                {
                    Console.WriteLine("Please input adds on ");
                    adds = char.Parse(Console.ReadLine());


                    if (adds == '1')
                    {

                        Console.WriteLine("Cheese Burger with Egg is being prepared \nThat would be 60 Pesos \nPlease wait");
                    }
                    else if (adds == '2')
                    {
                        Console.WriteLine("Cheese Burger with Beef is being prepared \nThat would be 100 Pesos \nPlease wait");
                    }
                    else if (adds == '3')
                    {
                        Console.WriteLine("Cheese Burger with extra Cheese is being prepared \nThat would be 60 Pesos \nPlease wait");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }
                else
                {
                    if (choices == 'C')
                    {
                        Console.WriteLine("Hotdog is being prepared \nThat would be 37 Pesos \nPlease wait");
                    }

                    else if (choices == 'D')
                    {
                        Console.WriteLine("Hungarian is being prepared \nThat would be 70 Pesos \nPlease wait");
                    }
                    else if (choices == 'E')
                    {
                        Console.WriteLine("Hungarian is being prepared \nThat would be 56 Pesos \nPlease wait");
                    }
                    else
                    {

                    }
                    if (choices == 'F')
                    {
                        Console.WriteLine("Please input adds on ");
                        adds = char.Parse(Console.ReadLine());


                        if (adds == '1')
                        {

                            Console.WriteLine("Egg Sandwich with extra Egg is being prepared \nThat would be 60 Pesos \nPlease wait");
                        }
                        else if (adds == '2')
                        {
                            Console.WriteLine("Egg Sandwich with Beef is being prepared \nThat would be 100 Pesos \nPlease wait");
                        }
                        else if (adds == '3')
                        {
                            Console.WriteLine("Egg Sandwich with Cheese is being prepared \nThat would be 60 Pesos \nPlease wait");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input");
                        }
                    }

                }
            }
        }
    }
}