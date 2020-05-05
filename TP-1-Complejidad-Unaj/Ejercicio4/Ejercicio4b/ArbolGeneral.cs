using System;
using System.Collections.Generic;

namespace Ejercicio4b
{
    public class ArbolGeneral<T>
    {

        private NodoGeneral<T> raiz;

        public ArbolGeneral(T dato)
        {
            this.raiz = new NodoGeneral<T>(dato);
        }

        private ArbolGeneral(NodoGeneral<T> nodo)
        {
            this.raiz = nodo;
        }

        private NodoGeneral<T> getRaiz()
        {
            return raiz;
        }

        public T getDatoRaiz()
        {
            return this.getRaiz().getDato();
        }

        public List<ArbolGeneral<T>> getHijos()
        {
            List<ArbolGeneral<T>> temp = new List<ArbolGeneral<T>>();
            foreach (var element in this.raiz.getHijos())
            {
                temp.Add(new ArbolGeneral<T>(element));
            }
            return temp;
        }

        public void agregarHijo(ArbolGeneral<T> hijo)
        {
            this.raiz.getHijos().Add(hijo.getRaiz());
        }

        public void eliminarHijo(ArbolGeneral<T> hijo)
        {
            this.raiz.getHijos().Remove(hijo.getRaiz());
        }

        public bool esVacio()
        {
            return this.raiz == null;
        }

        public bool esHoja()
        {
            return this.raiz != null && this.getHijos().Count == 0;
        }

        public int altura()
        {
            int altura_final = 0;
            int altura_temp = 0;
            //pegunto si es hoja
            if (esHoja() == true)
            {
                return 0;
            }
            else
            {
                List<ArbolGeneral<T>> arbol_averigua = new List<ArbolGeneral<T>>();
                arbol_averigua = this.getHijos();
                if (arbol_averigua.Count > 0)
                {
                    //foreach(var recorre in arbol_averigua)
                    foreach (var recorre in arbol_averigua) //arbol_averigua)
                    {
                        int altura_h = recorre.altura();//recursivo a altura()
                        Console.WriteLine("Raíz " + recorre.getDatoRaiz());//Debo llamar el metodo getDatoRaiz
                        Console.WriteLine("Hijo " + altura_h);

                        if (altura_h > altura_temp)
                        {
                            altura_temp = altura_h;
                        }
                    }
                }
                if (altura_temp > altura_final)
                {
                    altura_final = altura_temp;
                }

            }
            return altura_final + 1;
        }
        //Ejercicio 4b
        /*b)nivel(Object dato):int devuelve la profundidad o nivel del dato en el árbol.
         * El nivel de un nodo es la longitud del único camino de la raíz al nodo.
         Pista: Si el nodo raíz posee el mismo dato que pasado como parámetro, se retorna 0.
         En caso contrario, se debe buscar en cuales de los subárboles hijos se encuentra el dato
         (implemente el mensaje include (Object dato) en la clase Arbol General) y se debe
         retornar 1 más el nivel que arroje enviar el mensaje nivel() al subárbol que incluye el dato
         */

        public int nivel(object dato)
        {
            int nodoprovisorio = 0;
           
            Console.WriteLine("el dato ingresado ingresado es " + dato);
            //if (dato.Equals(getDatoRaiz())) 
            if (dato == getRaiz())
            {
                //Console.WriteLine("nivel es 0");
                return 0;
            }
            else
            {
                if(nodoprovisorio >0)
                {
                    nodoprovisorio++;
                }
                //Console.WriteLine("Acá entró al foreach y el nivel es " + nodoprovisorio);
                foreach (var busca in getHijos())
                {
                    int nivel_incrementa = busca.nivel(dato);
                    Console.WriteLine("acá es el hijo " + busca.getDatoRaiz());
                    Console.WriteLine(busca.getDatoRaiz().Equals(dato));
                    //if(busca.getHijos().Equals(dato))
                    if(dato.Equals(busca.getDatoRaiz()))
                    {
                        nodoprovisorio++;
                        break;
                    }
                    else
                    {

                        nivel_incrementa = busca.nivel(dato);
                    }

                }
            }
            return nodoprovisorio++;
        }

    }
}
