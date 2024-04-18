using System;

namespace itG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe tu Mensaje");
            string Msj = Console.ReadLine();
            //string Msj = "Hola";
            Char[] Txt = Msj.ToCharArray();

            for (int i = Txt.Length-1; i>=0; i--)
            {
                Console.Write(Txt[i]);         
            }


        }
    }
}
