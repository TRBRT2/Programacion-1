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


                    if (peso <= 5 && peso >= 2)
                    {

                        switch (activiedad)
                        {
                            case 1:
                                Console.WriteLine("Su perro debe comer entre 60 y 115 gramos de alimento.");
                                break;
                            case 2:
                                Console.WriteLine("Su perro debe comer entre 55 y 100 gramos.");
                                break;
                            case 3:
                                Console.WriteLine("Su perro debe comer entre 45 y 85 gramos.");
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
                    break;
                    break;
            }
            Console.WriteLine("Si desea volver a utilizar el programa escriba 1\n si quiere cerrar el programa escriba 2");
            a = Console.ReadLine();
            continuar = Convert.ToInt32(a);

            Console.Clear();


        } while (continuar != 2);





    }
}

