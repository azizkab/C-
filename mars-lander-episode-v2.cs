using System;

class Player
{
    static void Main(string[] args)
    {
        // Lecture des données d'initialisation : on les lit mais on ne les utilise pas à ce niveau
        int surfaceN = int.Parse(Console.ReadLine());
        for (int i = 0; i < surfaceN; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int landX = int.Parse(inputs[0]);
            int landY = int.Parse(inputs[1]);
        }

        // Boucle de jeu
        while (true)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int X = int.Parse(inputs[0]);
            int Y = int.Parse(inputs[1]);
            int hSpeed = int.Parse(inputs[2]); // vitesse horizontale
            int vSpeed = int.Parse(inputs[3]); // vitesse verticale
            int fuel = int.Parse(inputs[4]);   // quantité de carburant
            int rotate = int.Parse(inputs[5]); // angle actuel
            int power = int.Parse(inputs[6]);  // puissance actuelle

            int newPower;

            // Si vitesse verticale est trop rapide (en chute), on augmente la puissance
            if (vSpeed <= -40)
            {
                newPower = 4;
            }
            else if (vSpeed <= -30)
            {
                newPower = 3;
            }
            else if (vSpeed <= -20)
            {
                newPower = 2;
            }
            else if (vSpeed <= -10)
            {
                newPower = 1;
            }
            else
            {
                newPower = 0; // sinon on peut laisser tomber un peu
            }

            // Toujours angle à 0 pour ce niveau
            Console.WriteLine("0 " + newPower);
        }
    }
}
