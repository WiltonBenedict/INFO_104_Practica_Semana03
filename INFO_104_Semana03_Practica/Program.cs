using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//UH, INFO-104
//Wilton Benedict,10/05/23
//Practica Semana 03
/*
 Objectivos:
1-  Ingresar 5 numeros y el sistema debe indicar cual es mayor
>>>>>>>>>Crealo como clase en la cual el objeto sea un numero

2-  un algoritmo que se ingrese el dia de la semana  con numero (1 al 7)y el sistema indique si es (Lunes, Martes,Miercoles, etc.) utilice un switch
>>>>>>>>>Crearlo como clase en la cual el objeto sea un dia.

3- un algoritmo donde se ingresa una tecla y el sistema debe indicar si es numero o una vocal o o una consonante, utilice un switch
>>>>>>>>>Crearlo como clase en la cual el objeto sea una letra
*/


namespace INFO_104_Semana03_Practica
{
    internal class Program
    {
        static bool estado = true;
        static int opc = 0;
        static void Main(string[] args)
        {
            while (estado) 
            {
                Console.WriteLine("---Practica INFO-104---\n --Semana 03--");
                Console.WriteLine("1. Numero Mayor\n2. Dia de la semana\n3. Numero,vocal o consonante\n4. Salida");
                opc = int.Parse(Console.ReadLine());
                if(opc == 1) { Numeros(); }
                else if(opc == 2) { DiaSemana(); }
                else if(opc == 3) { Caracter(); }
                else if(opc == 4) { estado = false; }
                else { Console.WriteLine("Dato ingresado invalido. Intente de nuevo"); }
            }
        }

        static void Numeros()
        {
            int[] numero = new int[5];
            int numeroMayor = 0, numeroMenor = 0;
            int x = 1;
            Console.WriteLine("--Numero Mayor--");
            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine($"Ingrese el valor {x}:");
                int temp = int.Parse( Console.ReadLine() );
                numero[i] = temp;
                x++;
            }
            Valores objValor = new Valores();
            numeroMayor = objValor.ValorMayor(numero);
            numeroMenor = objValor.ValorMenor(numero);

            Console.WriteLine($"Numero mayor: {numeroMayor}\nNumero menor: {numeroMenor}");

        }

        static void DiaSemana()
        {
            bool estadoL= true;
            int dia = 0;
            Console.WriteLine("--Dia Semana--");
            while ( estadoL ) 
            {
                Console.WriteLine("Ingrese un valor del 1 al 7: ");
                dia = int.Parse( Console.ReadLine() );
                if(dia < 1 || dia > 7)
                {
                    Console.WriteLine("Dato invalido. Intente de nuevo");
                }
                else
                {
                    Semana objDia;
                    objDia = new Semana();
                    string actual = objDia.CalculoDia( dia );
                    Console.WriteLine($"El dia es: {actual}");
                    Console.ReadLine();
                }

                Console.WriteLine("Desea volver al menu (1 para confirmar): ");
                int select = int.Parse(Console.ReadLine());
                if(select == 1) { estadoL = false; Console.WriteLine("Redirigiendo..."); }
                else {  estadoL = true; }
            }
        }

        static void Caracter()
        {
            Console.WriteLine("--Numero, vocal o consonante--");
            Console.WriteLine("Ingrese un caracter: ");
            string valor = Console.ReadLine();
            Caracteres objCaracter = new Caracteres();
            string tipo = objCaracter.Letra(valor);
            Console.WriteLine($"El caracter es de tipo: {tipo}");
        }
   
    }

    class Caracteres
    {
        public string Letra(string valor)
        {
            string temp = valor.ToUpper();
            switch (temp)
            {
                case "A":
                    return "Vocal";
                case "E":
                    return "Vocal";
                case "I":
                    return "Vocal";
                case "O":
                    return "Vocal";
                case "U":
                    return "Vocal";
                case "1":
                    return "Numero";
                case "2":
                    return "Numero";
                case "3":
                    return "Numero";
                case "4":
                    return "Numero";
                case "5":
                    return "Numero";
                case "6":
                    return "Numero";
                case "7":
                    return "Numero";
                case "9":
                    return "Numero";
                case "0":
                    return "Numero";
                case "Q":
                    return "Consonante";
                case "W":
                    return "Consonante";
                case "R":
                    return "Consonante";
                case "T":
                    return "Consonante";
                case "Y":
                    return "Consonante";
                case "P":
                    return "Consonante";
                case "S":
                    return "Consonante";
                case "D":
                    return "Consonante";
                case "F":
                    return "Consonante";
                case "G":
                    return "Consonante";
                case "H":
                    return "Consonante";
                case "J":
                    return "Consonante";
                case "K":
                    return "Consonante";
                case "L":
                    return "Consonante";
                case "Z":
                    return "Consonante";
                case "X":
                    return "Consonante";
                case "C":
                    return "Consonante";
                case "V":
                    return "Consonante";
                case "B":
                    return "Consonante";
                case "N":
                    return "Consonante";
                case "M":
                    return "Consonante";
                default:
                    return "Especial";
            }
        }
    }

    class Semana
    {
        public string CalculoDia(int dia)
        {
            switch (dia)
            {
                case 1:
                    return "Lunes";
                case 2:
                    return "Martes";
                case 3:
                    return "Miercoles";
                case 4:
                    return "Jueves";
                case 5:
                    return "Viernes";
                case 6:
                    return "Sabado";
                case 7:
                    return "Domingo";
                default:
                    return "Sin dia especificado";
            }
        }
    }

    class Valores
    {
        int x = 0, y = 0;
        public int ValorMayor(int[] numero)
        {
            int mayor = numero[x];
            while(x <5)
            {
                if (numero[x] > mayor) { mayor = numero[x];  }
                x++;
            }
            return mayor;
        }

        public int ValorMenor(int[] numero)
        {
            int menor = numero[y];
            while(y <5) 
            { 
                if (numero[y] < menor) { menor = numero[y];  }
                y++;
            }
            return menor;
        }
    }

}
