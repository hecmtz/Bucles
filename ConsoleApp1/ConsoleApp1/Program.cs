using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {




            /* 
             int i = 1;
            while (i < 101)
            {
                Console.WriteLine("Numero " + i);
                i++;
            }

            Console.ReadLine();
            */
            /*
            while (i > 0)
            {
                Console.WriteLine("Inserta un numero");
                i = Convert.ToInt32(Console.ReadLine());
            }

            //do
            //{
            //    Console.WriteLine("Inserta un numero");
            //    i = Convert.ToInt32(Console.ReadLine());
            //} while (i<0);
            
             */

            //int num , num1=0 ;
            //for (int i = 1; i <= 4; i++)
            //{
            //    Console.WriteLine("Inserta el valor del numero "+ i );
            //    num = Convert.ToInt32(Console.ReadLine());
            //    num1 = num1 + num; // se suman el valor antiguo y el nuevo


            //}
            //Console.WriteLine("La suma es: " + num1);



            /*
            for (int i = 10; i <= 20; i++)
            {
                Console.WriteLine(i+"\n" );
            }
            */

            /*
            for (int i = 20; i >= 10; i--)
            {
                Console.WriteLine(i + "\n");
            }
            */
            /*
            int i = 1 , num, sumT=0;
            double media;
            do
            {
                Console.WriteLine("Inserta el valor del numero : "+ i);
                num = Convert.ToInt32(Console.ReadLine());
                sumT = num + sumT;
                i++;
                
            } while (i <= 10);
            media = sumT / i;
            Console.Clear();
            Console.WriteLine("\n \n La media es: " + media);
            */

            /*
            int i=1 , num ,sum = 0;
            while (i != 0) 
            {
                Console.WriteLine("Inserta un numero ");
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
                i = num;
               
                if ( i < 0)
                {
                    Console.WriteLine("Se ignoran los valores negativos. ");
                }
                else
                {
                    sum = num + sum;
                }
            } 

            Console.WriteLine("La suma es: "+ sum);
            */


            /*
             string parimpar ="";
            int  par=0, impar=1;
            
           


           while (parimpar != "P"  &&  parimpar != "I" ) {
                //   parimpar == "i" ||

                Console.WriteLine("¿Qué deseas el numero par o impar ? : ");
                parimpar = (Console.ReadLine());

            }

           
                for (int i = 0; i < 100; i++)
                {


                    if (parimpar == "P" || parimpar == "p")
                    {

                        if (i % 2 == 0)
                        {
                            //par
                            par = i + 2;
                            Console.WriteLine(par);
                        }

                    }
                    else
                    {
                        if (i % 2 == 1)
                        {
                            //par
                            Console.WriteLine(impar);
                            impar = i + 2;
                        }
                        ;

                    }

                }

    */

            /*
            int edad , i=0;

            Console.WriteLine(" Ingresa tu edad : ");
            edad =Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine(" Feliz cumpleaños ");
                i++;
            } while (i < edad);

            */
            //int n ;

            //Console.WriteLine(" Ingresa un numero : ");
            //n= Convert.ToInt32(Console.ReadLine());

            /*
            for (int i = 0;  i < n; i++)
            {
              
                

                for (int j = 0; j < i; j++)
                 {

                    Console.Write(" * ");

                 }
                Console.WriteLine(" * ");
            }

    */
            // \t 


            /*
            double c , d;

            Console.Write("\t Numero \t Operación \n");
            Console.Write("***********************************************\n  \n");

            for (int b=0; b<13; b++)
            {
                Console.Write("\t "+b);

                if (b % 2 == 0)
                {
                    d = Math.Pow(b, 3);
                    Console.WriteLine("\t El cubo = " + d);

                }
                else
                {
                    c = Math.Pow(b, 2);
                    Console.WriteLine("\t El cuadrado = "+ c );
                   
                    //Console.Write("\t" + d);
                    //
                    //Console.WriteLine("\t" + b );

                }
            }

            */
            //Mostrar en pantalla diez números, siendo el primero 1 y los siguientes la suma del número anterior y 5.


            /*
              int sum =0 ;

            for (int i =1; i<=10; i++)
            {
                
                if (i == 1)
                {
                    
                    sum = i;
                    Console.WriteLine(sum);
                }
                else
                {
                    sum = sum + 5;
                    Console.WriteLine(sum);

                }
                

            } 
            */


            /*
            int n, re=0;
            Console.WriteLine(" Ingresa un numero : ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i=0; i<n; i++)
            {
                re = re + i;
                
            }
            Console.WriteLine("La suma de todos los numeros es : "+re);


            */


            /*
            int n, re = 0;
            do
            {


                Console.WriteLine(" Ingresa un numero : ");
                n = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    re = re + i;

                }
                Console.WriteLine("La suma de todos los numeros es : " + re);
                re = 0;
            } while (n != 0);
                Console.WriteLine("Gracias.");
            */


            ////////int num  ;
            ////////int num2 = 0;
            ////////int num1;

            ////////Console.WriteLine("Introduce un numero .");
            ////////num = Convert.ToInt32(Console.ReadLine());


            ////////if(num!=0) // comprueba que no sea = si es 0 termina el programas
            ////////{
            ////////    // i=num hasta que sea = 0 
            ////////    for (int i=num ; i > 0; i--)
            ////////    //      i=5     5>0   5--
            ////////    //              4>0   4--

            ////////    {
            ////////        J
            ////////        num1 = num % 10;
            ////////        Console.WriteLine(i);
            ////////        Console.WriteLine(num1);
            ////////    }
            ////////}
            ////////else
            ////////{
            ////////    Console.WriteLine("0");
            ////////    Console.WriteLine("Adios");

            ////////}
            ///
            /*
            string respuesta ;

            Console.WriteLine("Ingresa un nombre");
            respuesta = Console.ReadLine();

            for (int i = 0; i <respuesta.Length; i++)
            {
                Console.WriteLine(respuesta[i]);

            }
            */

            ////string[] respuesta; 
            ////string npalabras [];
            ////char[] charSeparators = new char[] { ',' };

            /*
            string respuesta;
            int palabras=0; 
            Console.WriteLine("Ingresa un nombre");
            respuesta =Convert.(Console.ReadLine());
            for (int i=0; i<respuesta.Length; i++)
            {
                if (respuesta[i] == ' ')
                {
                    palabras++; 
                }                    

            
            }
                
                Console.WriteLine( "La frase tiene " + palabras + " palabras ");
                

           */



            /*
            string a = "hola";
            string b= "aloh" ;
            Console.WriteLine("La string de la variable 1 es " + a );
            Console.WriteLine("La string de la variable 2 es " + b);
            a = string.Copy(b);
            Console.WriteLine("La string copiada de la var 1 a la 2 es " + a);
            */



            /*string palabra;
            Console.WriteLine("Escribe una palabra");
            palabra = Console.ReadLine();

            Console.WriteLine(palabra.ToLower());
            Console.WriteLine(palabra.ToUpper());
            Console.ReadLine();
             */

            //comprar si contiene un carater  ( manera facil abajo esta la manera con loops)
            /*
            string prueba = "cachia";
            int  contiene=0 ;

            if ( prueba.Contains('r'))
            {
                Console.WriteLine("Si la contiene");
            }
            else
            {
                Console.WriteLine("No la contiene");
            }
            */

            /*
            for (int i=0; i<prueba.Length; i++)
            { 

                if (prueba[i]== 'r'|| prueba[i] == 'r')
                {
                    contiene = 1;
                }
                                
            }
            if (contiene == 1)
            {
                Console.WriteLine("Si la contiene");
            }
            else
            {
                Console.WriteLine("No la contiene");
            }

    */

            //coger las 2 letras de enmedio.


            /*
            string palabra ="hola";
            int i;

            for (i = 0; i < palabra.Length; i++)
            {
                //COMPROBAR LA LONGITUD DE LA LETRA

            }

            if (palabra.Length%2 == 1)
            {
                i = i / 2;
                Console.WriteLine(palabra +" las letras de enmedio es " + (palabra[i]) );

                
            }
            else
            {
                i = i / 2 - 1;
                Console.WriteLine(palabra + " la letra de enmedio es " + (palabra[i]) + (palabra[i + 1]));
                
            }
            Console.ReadLine();

            */


            /*
            string frase;
            int i , digit=0;
            bool correcto=false;

            //do
            //{
            do
            {
                Console.WriteLine("Ingresa una contraseña ");
                frase = Console.ReadLine();
                //contraseniaososos

                for (i = 0; i < frase.Length; i++)
                {
                        if (char.IsDigit(frase[i]) == true)
                        {
                            digit++;

                        
                        }
                }


                if (digit > 1)
                {
                    correcto = true;
                }
                Console.WriteLine("prueba correcto es : "+ correcto );
                Console.ReadLine();

                if (frase.Length <7 || correcto != true )
                {
                        Console.WriteLine("Error contraseña con menos de 2 digitos o no es lo suficiente larga \n");
                        correcto = false;
                }
                  
            } while (frase.Length <= 8 ||  correcto != true);
          

           // } while( digit < 2);

             Console.Clear();
             Console.WriteLine("Contraseña ingresada correctamente \n Bienvenido ");
             Console.ReadLine();
            }
*/

            //Escribe un programa que al meter tres números por teclado identifique el mínimo y el máximo (usa el método correspondiente). 

            /*string fecha = DateTime.Now.ToString("MM/dd/yyyy H:mm");
            Console.WriteLine(fecha);
            Console.ReadLine();
            */
            //


            ///////////Arrays///////////
            ///////////Arrays///////////

            /*
            string nombre ="hector";
            char[] arrayNombre = nombre.ToCharArray(); // aqui convierte los valores del array en character
                                                       //asi se puede separar el string.
            Array.Reverse(arrayNombre);

           /* for (int i = 0; i < arrayNombre.Length;i++)
            {
                Console.Write(arrayNombre[i].ToString());
            }
            */


            /*
            string [] nombres = new string [3] ;

            

            for(int i=0; i<3; i++)
            {
                Console.WriteLine("Escribe el nombre : \r");
                nombres[i] = Console.ReadLine();
                
            }
            Console.Clear();
            Console.WriteLine("\n" + nombres[1]);
            Console.WriteLine("\n" + nombres[2]);
            Console.WriteLine("\n" + nombres[0]);
            */

            int[] numeros = new int[10];
            int j=20;

            for (int i=0; i<10; i++)
            {
                numeros[i]= j;
                j--;
                Console.WriteLine(numeros[i]);
            }        


            Console.ReadLine();

            
            //letras= letras.reverse;


        }
    }



    }
       
            
           
        
    

