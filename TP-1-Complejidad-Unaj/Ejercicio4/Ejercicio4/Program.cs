using System;

namespace Ejercicio4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Creo un árbol, en este caso va a ser tipo string
            ArbolGeneral<string> raul = new ArbolGeneral<string>("Raúl");
            ArbolGeneral<string> ale = new ArbolGeneral<string>("Alejandro");
            ArbolGeneral<string> nati = new ArbolGeneral<string>("Natalia");
            ArbolGeneral<string> seba = new ArbolGeneral<string>("Sebastián");
            ArbolGeneral<string> mar = new ArbolGeneral<string>("Margarita");
            ArbolGeneral<string> kari = new ArbolGeneral<string>("Karina");
            ArbolGeneral<string> jose = new ArbolGeneral<string>("Pepe");
            ArbolGeneral<string> noe = new ArbolGeneral<string>("Noemi");
            ArbolGeneral<string> ces = new ArbolGeneral<string>("César");
            ArbolGeneral<string> wal = new ArbolGeneral<string>("Walle");
            ArbolGeneral<string> dam = new ArbolGeneral<string>("Dami");
            ArbolGeneral<string> mic = new ArbolGeneral<string>("Micaela");
            ArbolGeneral<string> fac = new ArbolGeneral<string>("Facundo");

            //IMPORTANTE, ACORDAME AGREGAR SI NO, NO GUARDA!!!!!!! (GIL)
            //creo el árbol
            raul.agregarHijo(ale);
            raul.agregarHijo(nati);
            raul.agregarHijo(seba);
            nati.agregarHijo(fac);
            ///// hijos mar
            mar.agregarHijo(kari);
            mar.agregarHijo(noe);
            mar.agregarHijo(wal);
            mar.agregarHijo(ces);
            mar.agregarHijo(jose);
            //hijos jose
            jose.agregarHijo(dam);
            jose.agregarHijo(mic);

            //hay que hacer un metodo general para imprimir la salida
            Console.WriteLine("La raíz del árbol actual es "+ raul.getDatoRaiz());
            Console.WriteLine("La altura del árbol de Raúl es " + raul.altura());
            Console.WriteLine("La raíz del árbol actual es " + mar.getDatoRaiz());
            Console.WriteLine("La altura del árbol de Margarita es " + mar.altura());
            Console.WriteLine("La raíz del árbol actual es " + jose.getDatoRaiz());
            Console.WriteLine("La altura del árbol de Pepe es " +jose.altura());
        }

    }
}
