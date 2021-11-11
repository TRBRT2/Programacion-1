using System;

public class Program
{
    public static void Main(string[] args)
    {
        
        string a ="";
        int edad = 0;
        double altura = 0.0;
        string b ="";
        
        Console.WriteLine("Hola, por favor ingresa tu nombre:");
        b = Console.ReadLine();

        Console.WriteLine("Hola {0}, cuantos años tienes?", b);
        a = Console.ReadLine();
        edad = Convert.ToInt32(a);
        
        
            if(edad >= 21)
            {
                Console.WriteLine("Disculpa {0} eres muy mayor para entrar al parque :c", b);
            }
            if(edad <= 1) 
            {  
                Console.WriteLine("Disculpa {0} demasiado joven entrar al parque :c", b);
            }
            else
            {
                Console.WriteLine("Bienvenido al parque, {0} cuanto mides? en metros", b);
                a = Console.ReadLine();
                altura = Convert.ToDouble(a);
                if(altura >= 1 && altura < 1.5)
                {
                    Console.WriteLine("{0} puedes ir a la casa embrujada, el gusanito, los carros chocones y el carrusel", b);   
                }
                else if(altura >= 1.5 && altura < 1.9)
                {
                    Console.WriteLine("{0} puedes ir a la casa embrujada, el gusanito, los carros chocones, el carrusel, el martillo y a la montaña rusa", b);  
                }
                else if(altura >= 1.9) {
                    Console.WriteLine("{0} puedes ir a la casa embrujada, el gusanito extremo, los carros chocones, el carrusel, el martillo y a la montaña rusa", b);  
                }
                else
                {
                    Console.WriteLine("{0} debido a tu estatura solo puedes ir al gusanito", b);
                }
            }
                Console.WriteLine("Espero que te diviertas mucho en el parque :D");
            Console.ReadKey();
        
    }
}


