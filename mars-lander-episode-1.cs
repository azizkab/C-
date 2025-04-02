using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class MarsLander
{
    public int PosX { get; set; }
    public int PosY { get; set; }
    public int HorizontalSpeed { get; set; }
    public int VerticalSpeed { get; set; }
    public int RemainingFuel { get; set; }
    public int Angle { get; set; }
    public int Thrust { get; set; }

    public MarsLander(int posX, int posY, int hSpeed, int vSpeed, int fuel, int angle, int thrust)
    {
        PosX = posX;
        PosY = posY;
        HorizontalSpeed = hSpeed;
        VerticalSpeed = vSpeed;
        RemainingFuel = fuel;
        Angle = angle;
        Thrust = thrust;
    }

    public string GetNextAction()
    {
        // Si la vitesse verticale est trop élevée, appliquer une poussée maximale pour ralentir la descente
        int thrustPower = VerticalSpeed < -39 ? 4 : 0;
        int rotationAngle = 0; // Garder l'angle droit pour l'instant

        return $"{rotationAngle} {thrustPower}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        string[] inputs;
        int pointsCount = int.Parse(Console.ReadLine()); // Nombre de points décrivant la surface

        for (int i = 0; i < pointsCount; i++)
        {
            inputs = Console.ReadLine().Split(' ');
            int x = int.Parse(inputs[0]);
            int y = int.Parse(inputs[1]);
            // La surface peut être utilisée plus tard pour déterminer la zone d’atterrissage
        }

        // Boucle principale du jeu
        while (true)
        {
            inputs = Console.ReadLine().Split(' ');
            int posX = int.Parse(inputs[0]);
            int posY = int.Parse(inputs[1]);
            int hSpeed = int.Parse(inputs[2]);
            int vSpeed = int.Parse(inputs[3]);
            int fuel = int.Parse(inputs[4]);
            int angle = int.Parse(inputs[5]);
            int thrust = int.Parse(inputs[6]);

            MarsLander lander = new MarsLander(posX, posY, hSpeed, vSpeed, fuel, angle, thrust);

            // Affiche la prochaine commande de rotation et de puissance
            Console.WriteLine(lander.GetNextAction());
        }
    }
}
