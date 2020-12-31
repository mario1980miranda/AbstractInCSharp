using System;
using System.Collections.Generic;
using System.Globalization;
using AbstractInCSharp.Entities;
using AbstractInCSharp.Entities.Enums;

namespace AbstractInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.Write("Entrez avec la quantite de figures géométriques: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Données de la forme #{i}");
                Console.Write("Rectangle ou cercle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Quelle est la couleur (Noir/Rouge/Bleu)? ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (ch == 'r')
                {
                    Console.Write("Largeur: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    
                    Console.Write("Hauteur: ");
                    double heigth = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Rectangle(width, heigth, color));
                }
                else
                {
                    Console.Write("Rayon: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    
                    list.Add(new Circle(radius, color));
                }
            }
            Console.WriteLine();
            Console.WriteLine("Zones de formes géométriques");

            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
