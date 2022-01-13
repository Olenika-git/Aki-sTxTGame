using System;
//Petit jeu Texte en C#
namespace AventureTexte
{
    class Program
    {

        static void Main(string[] args)
        {
            bool ingame = true;

            AfficherTitre();
            AfficherRegles();


            Console.WriteLine("Je constate que tu est réveillé, je suis Démétrius, Maire de Chouville,\n " +
                "Tu as l'air sacrément amoché, tu devrais aller voir Hernest le Technisham du Village,\n" +
                "Devrais-je suivre les conseils de Démétrius ? ou quitter le village " +
                "à la recherche d'informations sur ce qui m'est arrivé ?\n" +
                "rester ou quitter ?");
            while (ingame == true)
            {
                String direction = "";

                while (direction != "rester" || direction != "quitter")
                {
                    direction = Console.ReadLine();

                    if (direction == "rester")
                    {
                        Console.WriteLine("Le Shaman vous accueille et vous invite à boire une décoction à l'odeur épouvantable," +
                            "poliment vous buvez, malheureusement vous vous êtes fait tuer lors du vol de vos organes ... Perdu");
                        ingame = false;
                        break;
                    }
                    else if (direction == "quitter")
                    {
                        Console.WriteLine("A l'entrée d'une fôret, un homme visiblement mal intentioné,\n" +
                            "Eh toi, viens par ici dit-il !\n" +
                            "s'enfuir ou aller, vers l'hommme ?");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Veuillez reformuler vôtre réponse !");
                    }
                }
                if (ingame == false)
                {
                    continue;
                }
                while (direction != "aller" || direction != "s'enfuir")
                {
                    direction = Console.ReadLine();

                    if (direction == "aller")
                    {
                        Console.WriteLine("Arrivé à la haute de l'homme, il brandit un couteau et vous le glisse sous la gorge," +
                            "malheureusement pour vous sur un coup de panique vous bougez et la lame vous tranche l'artère ... Vous êtes Mort");
                        ingame = false;
                        break;
                    }
                    if (ingame == false)
                    {
                        continue;
                    }
                    else if (direction =="s'enfuir")
                    {
                        Console.WriteLine("Vous courez à toute allure à travers les bois,\n" +
                            "vous arrivez à une énorme intersection un panneau avec énormement de direction est présent ou allez vous ?\n" +
                            "Chouville\n" +
                            "Linville\n"  +
                            "Boilville\n" +
                            "Eloville\n"  +
                            "Gaeville\n"  +
                            "Philville\n" +
                            "Damsville\n" +
                            "Morgville\n" +
                            "Sophville\n" +
                            "Saraville\n" +
                            "Juliville");
                            break;
                    }
                    else
                    {
                        Console.WriteLine("Veuillez reformuler vôtre réponse !");
                    }
                }
                if(ingame == false)
                {
                    continue;
                }

                String ville = Console.ReadLine();

                switch (ville)
                {
                    case "Chouville": Console.WriteLine("Vous êtes mordu par un chien enrager et vous mourrez de la rage"); ingame = false;  break;
                    case "Linville": Console.WriteLine("Sur la route de Linville, lors d'une pause toilette vous mourrez d'une crise cardiaque ..."); ingame = false;  break;
                    case "Boilville": Console.WriteLine("Un serpent vous mord à la cheville, après quelques minutes de marche vous devenez bleu ... et mourrez..."); ingame = false;  break;
                    case "Eloville": Console.WriteLine("Après un long voyage, vous arrivez à Eloville ! et vous vous installer dans une taverne chaleureuse, vous y rencontrez une jolie femme, et décider de passer le reste de vos jours à ses cotées"); break;
                    case "Gaeville": Console.WriteLine("Une calèche qui passait par là perd une marchandise à vôtre niveau, vous finisez écraser sous cette botte de foin ... Vous mourrez"); ingame = false;  break;
                    case "Philville": Console.WriteLine("La nuit est tombé, vous mourrez de froid."); ingame = false;  break;
                    case "Damsville": Console.WriteLine("Une meute de loup vous attaque ... hélas vous ne vivrez plus ce soir"); ingame = false;  break;
                    case "Morgville": Console.WriteLine("Une bande de brigand, vous attaque pendant vôtre sommeil, vous perdez"); ingame = false;  break;
                    case "Sophville": Console.WriteLine("Vous êtes mordu par  enrager et vous mourrez de la rage"); ingame = false; break;
                    case "Saraville": Console.WriteLine("Vous êtes mordu par une mouette folle et vous mourrez de psychose"); ingame = false; break;
                    case "Juliville": Console.WriteLine("Vous êtes mordu par un chat enrager et vous mourrez de la rage"); ingame = false; break;
                    default: Console.WriteLine("Erreur dans le Switch"); break;
                }

            }
        }
            

        static void AfficherTitre()
        {
            Console.WriteLine("Bienvenue sur TxtAventure !");
        }

        static void AfficherRegles()
        {
            Console.WriteLine("Dans ce jeu, vous devrez prendre des décisions pour voir ou cela vous mènent, Bonne Chance");
        }
    }
}