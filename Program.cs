using System;

public class SecretNumber {

    public static void Main() {

        // 1. Declaramos las variables que se van a emplear en el programa

        Random rndNumber = new Random();

        int secretNumber = rndNumber.Next(0,20);
        // Console.WriteLine(secretNumber);

        // 2. Introducimos un numero de intentos fijos que conforme vas fallando se autodecrementa 

        int intentos = 10;
        bool terminado = false;


        // 3. Se introduce la función en un bucle para poder acerta o fallar el numero
        // hasta agotar los intentos 

        do {

            // 4. En función de los intentos que te quedan se muestra un resultado u otro

            if (intentos == 1){
                Console.WriteLine("Para acertar el numero tienes: " + intentos + " intento");
            } else {
                Console.WriteLine("Para acertar el numero tienes: " + intentos + " intentos");
            }


            Console.WriteLine("Por favor introduce un numero comprendido entre 0, 20");
            int numberUser = Convert.ToInt32(Console.ReadLine());

            // 5. Introducimos los parametros con lo que juega el programa para acertar el numero 

            if(numberUser > secretNumber){
                Console.WriteLine("El número introducido " + numberUser + " tiene que ser menor para acertar");
                intentos--; 
            }
                    
            if(numberUser < secretNumber) {
                Console.WriteLine("El número introducido " + numberUser + " tiene que ser mayor para acertar");
                intentos--;
            }
                
            if (numberUser == secretNumber) {
                // Console.WriteLine("Enhorabuena has acertado, el numero era: " + secretNumber);
                terminado = true;
            }
            
            // Console.WriteLine(intentos);
        
        }while((intentos != 0) && (terminado == false));

        // 6. En función de los resultados obtenidos mostramos una opción u otra. 

        if ((intentos == 0) || (terminado == false) ) { 
            Console.WriteLine("Lo siento, te has quedado sin opciones, el numero era: " + secretNumber);
        }

        if (terminado == true) {
            Console.WriteLine("Enhorabuena, has acertado el número secreto era el: "  + secretNumber);
        }

        Console.WriteLine();
        Console.ReadKey();
    }
}
