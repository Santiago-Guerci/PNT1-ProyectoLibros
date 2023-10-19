using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class CarritoDeCompra
    {
        ArrayList listaLibros;
        public CarritoDeCompra()
        {
            listaLibros = new ArrayList();
        }

        public void agregarACarrito(ItemCarrito item)
        {
            listaLibros.Add(item);
        }
        public void vaciarCarrito()
        {
            listaLibros.Clear();
        }
        public void finalizarCompra()
        {

        }
        
    }
}
