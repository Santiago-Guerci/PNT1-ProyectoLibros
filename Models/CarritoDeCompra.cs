using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
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
