using System;

public class Program
{
    public static void Main(string[] args)
    {

        string a = "";
        int activiedad = 0;
        double peso = 0.0;
        int continuar = 0;
        int tipo = 0;



        do
        {
            Console.WriteLine("Bienvenidos al programa de alimentacion canina .\n\n");

            Console.WriteLine("Es su perro Adulto o Cachorro?");
            Console.WriteLine("1 - Adulto");
            Console.WriteLine("2 - Cachorro");
            a = Console.ReadLine();
            tipo = Convert.ToInt32(a);

            switch (tipo)
            {
                case 1:
                    Console.WriteLine("Cual es el peso de su perro?:");
                    a = Console.ReadLine();
                    peso = Convert.ToDouble(a);

                    Console.WriteLine("Como clasificaria la actividad de su mascota?");
                    Console.WriteLine("1 - Actividad Alta");
                    Console.WriteLine("2 - Actividad Normal");
                    Console.WriteLine("3 - Actividad Baja");
                    a = Console.ReadLine();
                    activiedad = Convert.ToInt32(a);

                    if (peso < 2)
                    {
                    Console.WriteLine("Su perro es muy ligero para el sistema, para mas informacion consulte con su veterinario");
                    }
                    if (peso >= 2 && peso <=5 )
                    {
                        switch (activiedad)
                        {
                            case 1:
                                Console.WriteLine("Su perro debe comer entre 60 y 115 gramos.");
                                break;
                            case 2:
                                Console.WriteLine("Su perro debe comer entre 55 y 100 gramos.");
                                break;
                            case 3:
                                Console.WriteLine("Su perro debe comer entre 45 y 85 gramos.");
                                break;
                        }
                    }
                    if (peso >= 5 && peso <= 10)
                    {
                        switch (activiedad)
                        {
                            case 1:
                                Console.WriteLine("Su perro debe comer entre 115 y 190 gramos.");
                                break;
                            case 2:
                                Console.WriteLine("Su perro debe comer entre 110 y 170 gramos.");
                                break;
                            case 3:
                                Console.WriteLine("Su perro debe comer entre 85 y 145 gramos.");
                                break;
                        }
                    }
                    if (peso >= 10 && peso <= 15)
                    {

                        switch (activiedad)
                        {
                            case 1:
                                Console.WriteLine("Su perro debe comer entre 190 y 255 gramos.");
                                break;
                            case 2:
                                Console.WriteLine("Su perro debe comer entre 170 y 225 gramos.");
                                break;
                            case 3:
                                Console.WriteLine("Su perro debe comer entre 145 y 195 gramos.");
                                break;
                        }

                    }
                    if (peso >= 15 && peso <= 25)
                    {

                        switch (activiedad)
                        {
                            case 1:
                                Console.WriteLine("Su perro debe comer entre 255 y 380 gramos.");
                                break;
                            case 2:
                                Console.WriteLine("Su perro debe comer entre 225 y 330 gramos.");
                                break;
                            case 3:
                                Console.WriteLine("Su perro debe comer entre 195 y 285 gramos.");
                                break;
                        }

                    }
                    break;

                case 2:

                    Console.WriteLine("Cual es el peso ideal de su cachorro?:");
                    a = Console.ReadLine();
                    peso = Convert.ToDouble(a);

                    Console.WriteLine("Cuantos meses tiene su cachorro?");
                    a = Console.ReadLine();
                    activiedad = Convert.ToInt32(a);

                    if (peso <= 2)
                    {
                        if (activiedad <= 2)
                        {
                            Console.WriteLine("Su perro debe comer 50 gramos.");
                        }
                        else if (activiedad > 2 && activiedad <= 5)
                        {
                            Console.WriteLine("Su perro debe comer 60 gramos.");
                        }
                        else if (activiedad >= 6)
                        {
                            Console.WriteLine("Su perro debe comer 55 gramos.");

                        }

                    }
                    if (peso > 2 && peso <= 5)
                    {
                        if (activiedad <= 2)
                        {
                            Console.WriteLine("Su perro debe comer 95 gramos.");
                        }
                        else if (activiedad == 3 || activiedad >= 6)
                        {
                            Console.WriteLine("Su perro debe comer 110 gramos.");
                        }
                        else if (activiedad == 5 || activiedad == 4)
                        {
                            Console.WriteLine("Su perro debe comer 115 gramos.");
                        }
                    }
                    if (peso > 5 && peso <= 10)
                    {
                        if (activiedad <= 2)
                        {
                            Console.WriteLine("Su perro debe comer 155 gramos.");
                        }
                        else if (activiedad == 3 || activiedad >= 6)
                        {
                            Console.WriteLine("Su perro debe comer 185 gramos.");
                        }
                        else if (activiedad == 4)
                        {
                            Console.WriteLine("Su perro debe comer 195 gramos.");
                        }
                        else if (activiedad == 5)
                        {
                            Console.WriteLine("Su perro debe comer 190 gramos.");
                        }
                    }
                    if (peso > 10 && peso <= 17)
                    {
                        if (activiedad <= 2)
                        {
                            Console.WriteLine("Su perro debe comer 215 gramos.");
                        }
                        else if (activiedad == 3 )
                        {
                            Console.WriteLine("Su perro debe comer 265 gramos.");
                        }
                        else if (activiedad == 5 || activiedad == 4)
                        {
                            Console.WriteLine("Su perro debe comer 285 gramos.");
                        }
                        else if (activiedad >= 6)
                        {
                            Console.WriteLine("Su perro debe comer 280 gramos.");
                        }
                    }
                    if (peso > 17 && peso <= 25)
                    {
                        if (activiedad <= 2)
                        {
                            Console.WriteLine("Su perro debe comer 270 gramos.");
                        }
                        else if (activiedad == 3 )
                        {
                            Console.WriteLine("Su perro debe comer 350 gramos.");
                        }
                        else if (activiedad == 5 || activiedad == 4)
                        {
                            Console.WriteLine("Su perro debe comer 375 gramos.");
                        }
                        else if (activiedad >= 6)
                        {
                            Console.WriteLine("Su perro debe comer 370 gramos.");
                        }
                    }
                    if (peso > 25 && peso <= 32)
                    {
                        if (activiedad <= 2)
                        {
                            Console.WriteLine("Su perro debe comer 300 gramos.");
                        }
                        else if (activiedad == 3 )
                        {
                            Console.WriteLine("Su perro debe comer 400 gramos.");
                        }
                        else if (activiedad == 4)
                        {
                            Console.WriteLine("Su perro debe comer 445 gramos.");
                        }
                        else if (activiedad >= 5)
                        {
                            Console.WriteLine("Su perro debe comer 450 gramos.");
                        }
                    }
                    if (peso > 32 && peso <= 40)
                    {
                        if (activiedad <= 2)
                        {
                            Console.WriteLine("Su perro debe comer 355 gramos.");
                        }
                        else if (activiedad == 3 )
                        {
                            Console.WriteLine("Su perro debe comer 475 gramos.");
                        }
                        else if (activiedad == 4)
                        {
                            Console.WriteLine("Su perro debe comer 525 gramos.");
                        }
                        else if (activiedad >= 5)
                        {
                            Console.WriteLine("Su perro debe comer 530 gramos.");
                        }
                    }
                    if (peso > 40 && peso <= 50)
                    {
                        if (activiedad <= 2)
                        {
                            Console.WriteLine("Su perro debe comer 405 gramos.");
                        }
                        else if (activiedad == 3 )
                        {
                            Console.WriteLine("Su perro debe comer 545 gramos.");
                        }
                        else if (activiedad == 4)
                        {
                            Console.WriteLine("Su perro debe comer 610 gramos.");
                        }
                        else if (activiedad >= 5)
                        {
                            Console.WriteLine("Su perro debe comer 625 gramos.");
                        }
                    }
                    if (peso > 50 && peso <= 60)
                    {
                        if (activiedad <= 2)
                        {
                            Console.WriteLine("Su perro debe comer 450 gramos.");
                        }
                        else if (activiedad == 3 )
                        {
                            Console.WriteLine("Su perro debe comer 605 gramos.");
                        }
                        else if (activiedad >= 4)
                        {
                            Console.WriteLine("Su perro debe comer 685 gramos.");
                        }
                    }
                    if (peso > 60 && peso <= 70)
                    {
                        if (activiedad <= 2)
                        {
                            Console.WriteLine("Su perro debe comer 485 gramos.");
                        }
                        else if (activiedad >= 3 )
                        {
                            Console.WriteLine("Su perro debe comer 670 gramos.");
                        }
                    }
                    if (peso > 70 && peso <= 90)
                    {
                        {
                            Console.WriteLine("Su perro debe comer 580 gramos.");
                        }
                    }
                    break;
            }
            Console.WriteLine("Si desea volver a utilizar el programa escriba 1\nSi quiere cerrar el programa escriba 2");
            a = Console.ReadLine();
            continuar = Convert.ToInt32(a);

            Console.Clear();


        } while (continuar != 2);





    }
}

