using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    internal class ABB
    {
        public NodoABB? NodoRaiz { get; set; }

        public ABB()
        {
            NodoRaiz = null;
        }

        public void PoblarABB(NodoABB nodoPadre, NodoABB nuevoNodo)
        {
            if (nodoPadre == null)
            {
                NodoRaiz = nuevoNodo;
                return;
            }

            if (nodoPadre.Informacion > nuevoNodo.Informacion)
            {

                // seleccionar rama izquierda
                if (nodoPadre.RamaIzquierda == null)
                {
                    nodoPadre.RamaIzquierda = nuevoNodo;
                    return;
                }
                else
                {
                    PoblarABB(nodoPadre.RamaIzquierda, nuevoNodo);
                }
            }

            if (nodoPadre.Informacion < nuevoNodo.Informacion)
            {

                // seleccionar rama derecha
                if (nodoPadre.RamaDerecha == null)
                {
                    nodoPadre.RamaDerecha = nuevoNodo;
                    return;
                }
                else
                {
                    PoblarABB(nodoPadre.RamaDerecha, nuevoNodo);
                }
            }
        }

        public NodoABB BuscarNodo(NodoABB nodoPadre, int llave)
        {
            if (nodoPadre == null)
            {
                return null;
            }
            else
            {
                if (nodoPadre.Informacion == llave)
                {
                    return nodoPadre;
                }
                else
                {
                    if (nodoPadre.Informacion >  llave)
                    {
                        return BuscarNodo(nodoPadre.RamaIzquierda, llave);
                    }
                    else
                    {
                        return BuscarNodo(nodoPadre.RamaDerecha, llave);
                    }
                }
            }

        }

        public void RecorridoInorden(NodoABB nodo)
        {
            if (nodo == null)
            {
                return;
            }
            else
            {
                RecorridoInorden(nodo.RamaDerecha);
                Console.Write($" {nodo.Informacion} ");
                RecorridoInorden(nodo.RamaIzquierda);
            }
        }
    }
}
