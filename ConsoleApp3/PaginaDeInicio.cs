using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class PaginaDeInicio
    {
        List<Libro> libros;
        List<CarritoDeCompra> carritos;
        List<Usuario> usuarios;
        public PaginaDeInicio()
        {
            libros = new List<Libro>();
            carritos = new List<CarritoDeCompra>();
            usuarios = new List<Usuario>();
        }
        public Libro buscarLibroPorGenero(Genero genero)
        {
            return null;
        }
        public Libro buscarLibroPorAutor(Autor  autor)
        {
            return null;
        }

    }
}
