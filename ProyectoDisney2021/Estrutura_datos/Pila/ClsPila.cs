using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDisney2021.Estrutura_datos.Pila
{
    public class ClsPila
    {
        public ClsNodoPila Cima;
        public int NumeroElementos;

        public ClsPila()
        {
            Cima = null;
            NumeroElementos = 0;
        }

        public Boolean PilaVacia()
        {
            return (Cima == null);
        }

        public void Push(Object pDato)
        {
            ClsNodoPila nuevo;
            nuevo = new ClsNodoPila(pDato);
            nuevo.Siguiente = Cima;
            Cima = nuevo;
            NumeroElementos++;
        }

        public Object Quitar()
        {
            if (!PilaVacia())
            {
                Object auxs;
                auxs = Cima.Dato;
                Cima = Cima.Siguiente;
                NumeroElementos--;
                return auxs;
            }
            return null;
        }

        //public string Mostrar()
        //{
        //    string[] a = new string[NumeroElementos];
        //        ClsNodoPila indice;

        //        for (indice = Cima; indice != null; indice = indice.Siguiente)
        //        {
        //            string message = ""+indice.Dato;
        //            //string caption = "MiLista";
        //            //MessageBoxButtons buttons = MessageBoxButtons.YesNo;
        //            //DialogResult result;
        //            a = message.Split(" ");
        //            //result = MessageBox.Show(message, caption, buttons);
        //        }
        //    return a[1]+a[2];

        //}

        public string Mostrar()
        {
            if (!PilaVacia())
            {
                ClsNodoPila indice;

                for (indice = Cima; indice != null; indice = indice.Siguiente)
                {
                    string message = "" + indice.Dato;
                    string caption = "MiLista";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;
                
                    result = MessageBox.Show(message, caption, buttons);
                }
            }
            return  null;

        }

    }
}
