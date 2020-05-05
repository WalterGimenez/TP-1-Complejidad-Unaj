using System;
using System.Collections.Generic;

namespace Ejercicio4
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
                        int altura_h = recorre.altura();
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


        public int nivel(T dato)
        {
            return 0;
        }

    }
}
