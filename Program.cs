using System;

namespace dev_homework04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\r\n"); 
            Console.WriteLine("********"); 
            Console.WriteLine("Vamos a preparar un Sandwich");
            Console.WriteLine("\n"); 
            Console.WriteLine("Agregamos el Pan");
            Console.WriteLine("¿Deseas mayonesa o crema?");
            var capaUno = Console.ReadLine();
            Console.WriteLine("¿Deseas Jamón de Pavo o Pierna?");
            var capaDos = Console.ReadLine();
            Console.WriteLine("¿Deseas Lechuga?");
            var capaTres = Console.ReadLine();
            Console.WriteLine("¿Deseas jitomate?");
            var capaCuatro = Console.ReadLine();
            Console.WriteLine("¿Deseas queso");
            var capaCinco = Console.ReadLine();
            string [] sandwich = new string [8];
            
            sandwich[0] = "Tapa arriba";
            
            if(capaUno == "mayonesa"){
                sandwich[1] = "mayonesa";
            }  
            else if( capaUno == "crema"){
                sandwich[1] = "crema";
            }
            
            if( capaDos == "pavo"){
                sandwich[2] = "pavo";
            }  
            else if( capaDos == "pierna"){
                sandwich[2] = "pierna";
            }
            
            if( capaTres == "si"){
                sandwich[3] = "lechuga";
            }  
            else if( capaTres == "no"){
                sandwich[3] = "";
            }
            
            if( capaCuatro == "si"){
                sandwich[4] = "jitomate";
            }  
            else if( capaCuatro == "no"){
                sandwich[4] = "";
            }
            
            if( capaCinco == "si"){
                sandwich[5] = "queso";
            }
            else if( capaCinco == "no"){
                sandwich[5] = "";
            }
             sandwich[6] = "Tapa de abajo";

            Console.WriteLine("\r\n"); 
            Console.WriteLine("**********");   

            for(int indice = 0; indice < 8; indice++){
                if(!string.IsNullOrEmpty(sandwich[indice]))
                    Console.WriteLine(sandwich [indice]);
                    
            } Console.WriteLine("**********");


        }
    }
}
