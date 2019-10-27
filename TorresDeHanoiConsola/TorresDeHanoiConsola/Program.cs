using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TorresDeHanoiConsola
{
    class Program
    {
        public static int segundos = 0, minutos = 0;
        public static void cronometro()
        {
            Console.SetCursorPosition(95, 1);
            Console.Write("Cronometro");
            do
            {
                string segundoss = Convert.ToString(segundos);
                string mins = Convert.ToString(minutos);
                Console.SetCursorPosition(95, 2);
                Console.Write("             ");
                Console.SetCursorPosition(98, 2);
                Console.Write(mins + "  : " + segundoss);
                segundos++;
                Thread.Sleep(1000);
                if (segundos == 60)
                {
                    segundos = 0;
                    minutos += 1;
                }
            } while (segundos < 60);

        }
        public static void menu()
        {
            Console.WriteLine("************ Torres de Hanoi **************");
            Console.WriteLine("              Menu principal");
            Console.WriteLine("           1. Reglas del Juego:");
            Console.WriteLine("           2. Juega con niveles:");
            Console.WriteLine("           3. Juega contra el tiempo:");
            Console.WriteLine("           4. Ve los Leaderboards:");
        }
        static void Main(string[] args)
        {
            int op = 0;
            string ops, disco1 = "█", disco2 = "███", disco3 = "█████", disco4 = "███████", disco5 = "███████", disco6 = "███████████";

            do
            {
                Console.Clear();
                menu();
                op = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (op)
                {

                    case 1:
                        {
                            Console.WriteLine("1. Solo se puede mover un disco cada vez y para mover otro los demás tienen que estar en postes.");
                            Console.WriteLine("2. Un disco de mayor tamaño no puede estar sobre uno más pequeño que él mismo.");
                            Console.WriteLine("3. Solo se puede desplazar el disco que se encuentre arriba en cada poste.");
                            Console.ReadKey();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("                     Sub-Menu ");
                            Console.WriteLine("           1-Nivel: Juega con 3 discos");
                            Console.WriteLine("           2-Nivel: Juega con 4 discos");
                            Console.WriteLine("           3-Nivel: Juega con 5 discos");
                            Console.WriteLine("           4-Nivel: Juega con 6 discos");
                            op = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            switch (op)
                            {
                                case 1:
                                    {
                                        //cronometro();
                                        string[] barra1 = new string[3];
                                        string[] barra2 = new string[3];
                                        string[] barra3 = new string[3];
                                        bool banderamoviento = false;
                                        int movimiento = 0, contt1 = 0, contt2 = 0, contt3 = 0, comenzar = 0;
                                        barra1[0] = disco3;
                                        barra1[1] = disco2;
                                        barra1[2] = disco1;
                                        Console.SetCursorPosition(20, 7);
                                        Console.WriteLine("Torre 1");
                                        Console.SetCursorPosition(40, 7);
                                        Console.WriteLine("Torre 2");
                                        Console.SetCursorPosition(60, 7);
                                        Console.WriteLine("Torre 3");
                                        Console.SetCursorPosition(23, 11);
                                        Console.WriteLine(barra1[2]);
                                        Console.SetCursorPosition(22, 12);
                                        Console.WriteLine(barra1[1]);
                                        Console.SetCursorPosition(21, 13);
                                        Console.WriteLine(barra1[0]);
                                        Console.SetCursorPosition(23, 16);
                                        Console.WriteLine("1");
                                        Console.SetCursorPosition(43, 16);
                                        Console.WriteLine("2");
                                        Console.SetCursorPosition(63, 16);
                                        Console.WriteLine("3");
                                        Console.SetCursorPosition(83, 16);
                                        Console.WriteLine("4: darse por vencido");
                                        do
                                        {
                                            Console.SetCursorPosition(22, 22);
                                            Console.WriteLine("Con numero indica de que torre se movera la pieza del tope");
                                            Console.SetCursorPosition(22, 23);
                                            movimiento = Convert.ToInt32(Console.ReadLine());
                                            switch (movimiento)
                                            {
                                                case 1:
                                                    {
                                                        bool vacia = true;
                                                        int espaciosocupados = 0;
                                                        for (int x = 0; x < 3; x++)
                                                        {
                                                            if (barra1[x] == null)
                                                                vacia = false;
                                                        }
                                                        if (vacia == true)
                                                        {
                                                            Console.SetCursorPosition(23, 16);
                                                            Console.WriteLine(" ");
                                                            Console.SetCursorPosition(43, 16);
                                                            Console.WriteLine("B");
                                                            Console.SetCursorPosition(63, 16);
                                                            Console.WriteLine("C");
                                                            Console.SetCursorPosition(22, 22);
                                                            Console.WriteLine("Con la letra indica a donde mover la pieza del tope");
                                                            Console.SetCursorPosition(22, 23);
                                                            ops = Console.ReadLine();
                                                            switch (ops)
                                                            {
                                                                case "B":
                                                                    {
                                                                        bool vectorvacio = false;
                                                                        for (int x = 0; x < 3; x++)
                                                                            if (barra2[x] == null)
                                                                                vectorvacio = true;
                                                                        if (vectorvacio == true)
                                                                        {
                                                                            barra1[2] = null;
                                                                            barra2[0] = disco1;
                                                                            Console.SetCursorPosition(23, 11);
                                                                            Console.WriteLine("     ");
                                                                            Console.SetCursorPosition(43, 13);
                                                                            Console.WriteLine(barra2[0]);
                                                                            Console.SetCursorPosition(23, 16);
                                                                            Console.WriteLine("1");
                                                                            Console.SetCursorPosition(43, 16);
                                                                            Console.WriteLine("2");
                                                                            Console.SetCursorPosition(63, 16);
                                                                            Console.WriteLine("3");
                                                                        }
                                                                        break;
                                                                    }
                                                                case "C":
                                                                    {
                                                                        bool vacio = false;
                                                                        for (int x = 0; x < 3; x++)
                                                                            if (barra3[x] == null)
                                                                                vacio = true;
                                                                        if (vacio == true)
                                                                        {
                                                                            barra1[2] = null;
                                                                            barra3[0] = disco1;
                                                                            Console.SetCursorPosition(23, 11);
                                                                            Console.WriteLine("     ");
                                                                            Console.SetCursorPosition(63, 13);
                                                                            Console.WriteLine(barra3[0]);
                                                                            Console.SetCursorPosition(23, 16);
                                                                            Console.WriteLine("1");
                                                                            Console.SetCursorPosition(43, 16);
                                                                            Console.WriteLine("2");
                                                                            Console.SetCursorPosition(63, 16);
                                                                            Console.WriteLine("3");
                                                                        }
                                                                        break;
                                                                    }
                                                            }
                                                        }
                                                        else
                                                        {
                                                            if (espaciosocupados == 0)
                                                            {
                                                                Console.SetCursorPosition(22, 22);
                                                                Console.WriteLine("No hay discos para mover");
                                                            }
                                                            else 
                                                            {
                                                                if(barra1[2]==null)
                                                                {
                                                                    Console.SetCursorPosition(23, 16);
                                                                    Console.WriteLine(" ");
                                                                    Console.SetCursorPosition(43, 16);
                                                                    Console.WriteLine("B");
                                                                    Console.SetCursorPosition(63, 16);
                                                                    Console.WriteLine("C");
                                                                    Console.SetCursorPosition(22, 22);
                                                                    Console.WriteLine("Con la letra indica a donde mover la pieza del tope");
                                                                    Console.SetCursorPosition(22, 23);
                                                                    ops = Console.ReadLine();
                                                                    switch (ops)
                                                                    {
                                                                        case "B":
                                                                            {
                                                                                bool vectorvacio = false;
                                                                                for (int x = 0; x < 3; x++)
                                                                                    if (barra2[x] == null)
                                                                                        vectorvacio = true;
                                                                                if (vectorvacio == true)
                                                                                {
                                                                                    barra1[1] = null;
                                                                                    barra2[0] = disco2;
                                                                                    Console.SetCursorPosition(23, 12);
                                                                                    Console.WriteLine("     ");
                                                                                    Console.SetCursorPosition(43, 13);
                                                                                    Console.WriteLine(barra2[0]);
                                                                                    Console.SetCursorPosition(23, 16);
                                                                                    Console.WriteLine("1");
                                                                                    Console.SetCursorPosition(43, 16);
                                                                                    Console.WriteLine("2");
                                                                                    Console.SetCursorPosition(63, 16);
                                                                                    Console.WriteLine("3");
                                                                                }
                                                                                break;
                                                                            }
                                                                        case "C":
                                                                            {
                                                                                bool vacio = false;
                                                                                for (int x = 0; x < 3; x++)
                                                                                    if (barra3[x] == "")
                                                                                        vacio = true;
                                                                                if (vacio == true)
                                                                                {
                                                                                    barra1[2] = null;
                                                                                    barra3[0] = disco1;
                                                                                    Console.SetCursorPosition(23, 11);
                                                                                    Console.WriteLine("     ");
                                                                                    Console.SetCursorPosition(63, 13);
                                                                                    Console.WriteLine(barra3[0]);
                                                                                    Console.SetCursorPosition(23, 16);
                                                                                    Console.WriteLine("1");
                                                                                    Console.SetCursorPosition(43, 16);
                                                                                    Console.WriteLine("2");
                                                                                    Console.SetCursorPosition(63, 16);
                                                                                    Console.WriteLine("3");
                                                                                }
                                                                                break;
                                                                            }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                        break;
                                                    }
                                                case 2:
                                                    {
                                                        bool vacia = false;
                                                        for (int x = 0; x < 3; x++)
                                                            if (barra1[x] == "")
                                                                vacia = true;
                                                        if (vacia == false)
                                                        {

                                                        }
                                                        else
                                                        {
                                                            Console.SetCursorPosition(22, 22);
                                                            Console.WriteLine("No hay discos para mover");
                                                        }
                                                        break;
                                                    }
                                            }
                                        } while (banderamoviento == false);
                                        break;
                                    }
                            }
                            break;
                        }
                }
                Console.SetCursorPosition(1, 30);
                Console.WriteLine("Desea repetir el menu? S/N:");
                ops = Console.ReadLine();
            } while ((ops == "S") || (ops == "s"));
        }
    }

}
