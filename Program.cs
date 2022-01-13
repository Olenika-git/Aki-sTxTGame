using System;

namespace AventureTexte
{
    class Program
    {

        static void Main(string[] args)
        {
            showTitle();
            showRules();


            Console.WriteLine("Je constate que tu est réveillé, je suis Démétrius, Maire de Chouville,\n " +
                "Tu as l'air sacrément amoché, tu devrais aller voir Hernest le Technisham du Village,\n" +
                "Devrais-je suivre les conseils de Démétrius ? ou quitter le village " +
                "à la recherche d'informations sur ce qui m'est arrivé ?\n" +
                "rester ou quitter ?");

            String direction = Console.ReadLine();

            if (direction == "rester")
            {
                Console.WriteLine("Le Shaman vous accueille et vous invite à boire une décoction à l'odeur épouvantable," +
                    "poliment vous buvez, malheureusement vous vous êtes fait tuer lors du vol de vos organes ... Perdu");
            }
            else
            {

            }

        }

        static void showTitle()
        {
            Console.WriteLine("Bienvenue sur TxtAventure !");
        }

        static void showRules()
        {
            Console.WriteLine("Dans ce jeu, vous devrez prendre des décisions pour voir ou cela vous mènent, Bonne Chance");
        }
    }
}
