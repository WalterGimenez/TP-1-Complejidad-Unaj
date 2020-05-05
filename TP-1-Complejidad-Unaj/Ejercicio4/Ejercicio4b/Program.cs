using System;
namespace Ejercicio4b
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Creo un árbol, en este caso va a ser tipo string
            ArbolGeneral<string> raul = new ArbolGeneral<string>("raul");
            ArbolGeneral<string> ale = new ArbolGeneral<string>("ale");
            ArbolGeneral<string> nati = new ArbolGeneral<string>("nata");
            ArbolGeneral<string> seba = new ArbolGeneral<string>("seba");
            ArbolGeneral<string> mar = new ArbolGeneral<string>("marga");
            ArbolGeneral<string> kari = new ArbolGeneral<string>("kari");
            ArbolGeneral<string> jose = new ArbolGeneral<string>("pepe");
            ArbolGeneral<string> noe = new ArbolGeneral<string>("noe");
            ArbolGeneral<string> ces = new ArbolGeneral<string>("cesar");
            ArbolGeneral<string> wal = new ArbolGeneral<string>("walle");
            ArbolGeneral<string> dam = new ArbolGeneral<string>("dami");
            ArbolGeneral<string> mic = new ArbolGeneral<string>("mica");
            ArbolGeneral<string> fac = new ArbolGeneral<string>("facu");
            string nombre = "";
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
            Console.WriteLine("La raíz del árbol actual es " + raul.getDatoRaiz());
            Console.WriteLine("La altura del árbol de Raúl es " + raul.altura());
            Console.WriteLine("La raíz del árbol actual es " + mar.getDatoRaiz());
            Console.WriteLine("La altura del árbol de Margarita es " + mar.altura());
            Console.WriteLine("La raíz del árbol actual es " + jose.getDatoRaiz());
            Console.WriteLine("La altura del árbol de Pepe es " + jose.altura());

            //ejercicio 4b
            //Console.WriteLine("la raíz actual es: " + raul.getDatoRaiz());
            Console.WriteLine("ingrese el nombre a consultar");
            nombre = Console.ReadLine();
            //Console.WriteLine("El nivel que se encuentra {0} es {1}", nombre, raul.nivel(nombre));
            //Console.WriteLine("El nivel que se encuentra {0} es {1}", nombre, jose.nivel(nombre));
            Console.WriteLine("El nivel que se encuentra {0} es {1}", nombre, mar.nivel(nombre));
        }

    }
}