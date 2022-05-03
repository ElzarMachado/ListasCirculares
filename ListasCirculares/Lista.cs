using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCirculares
{
    public class Lista
    {
        Nodo nodoInicial;
        Nodo nodoActual;

        public Lista()
        {
            nodoInicial = new Nodo();
        }
        public bool ValidaVacio()
        {
            return (nodoInicial.Sig == null);
            return (nodoInicial.Ant == null);
        }
        public void Vaciar()
        {
            nodoInicial.Sig = null;
        }
        public string RecorrerLista()
        {
            string datosLista = "";
            nodoActual = nodoInicial;
            while (nodoActual.Sig != null)
            {
                nodoActual = nodoActual.Sig;
                datosLista += $"{nodoActual.Valor}\n";
            }
            return datosLista;
        }
        public void AgregarNodo(string dato)
        {
            nodoActual = nodoInicial;
            while (nodoActual.Sig != null)
            {
                nodoActual = nodoActual.Sig;
            }
            Nodo nodoNuevo = new Nodo(dato);
            nodoActual.Sig = nodoNuevo;
            nodoNuevo.Ant = nodoActual;
        }
        public Nodo Buscar(string dato)
        {
            if (ValidaVacio() == false)
            {
                Nodo nodoBusqueda = nodoInicial;
                while (nodoBusqueda.Sig != null)
                {
                    nodoBusqueda = nodoBusqueda.Sig;
                    if (nodoBusqueda.Valor == dato)
                    {
                        return nodoBusqueda;
                    }
                }
            }
            return null;
        }
        public Nodo BuscarPorIndice(int indice)
        {
            int Indice = -1;
            if (ValidaVacio() == false)
            {
                Nodo nodoBusqueda = nodoInicial;
                while (nodoBusqueda.Sig != null)
                {
                    nodoBusqueda = nodoBusqueda.Sig;
                    Indice++;
                    if (Indice == indice)
                    {
                        return nodoBusqueda;
                    }
                }
            }
            return null;
        }
        public Nodo BuscarAnterior(string dato)
        {
            if (ValidaVacio() == false)
            {
                Nodo nodoBusqueda = nodoInicial;
                while (nodoBusqueda.Sig != null && nodoBusqueda.Sig.Valor != dato)
                {
                    nodoBusqueda = nodoBusqueda.Sig;
                    if (nodoBusqueda.Sig.Valor == dato)
                    {
                        return nodoBusqueda;
                    }
                }
            }
            return null;
        }

        public void BorrarNodo(string dato)
        {
            if (ValidaVacio() == false)
            {
                nodoActual = Buscar(dato);
                if (nodoActual != null)
                {
                    Nodo nodoAnt = BuscarAnterior(dato);
                    nodoActual.Sig.Ant = nodoActual.Ant;
                    nodoActual.Ant.Sig = nodoActual.Sig;
                }
            }
        }





    }
}