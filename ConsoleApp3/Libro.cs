namespace ConsoleApp3
{
    internal class Libro
    {
        int idLibro, cantPaginas;
        float precio;
        String nombre;
        Autor autor;
        Editorial editorial;
        Genero genero;

        public Libro (int idLibro, int cantPaginas, float precio, string nombre, Autor autor, Editorial editorial, Genero genero)
        {
            this.idLibro = idLibro;
            this.cantPaginas = cantPaginas;
            this.precio = precio;
            this.nombre = nombre;
            this.autor = autor;
            this.editorial = editorial;
            this.genero = genero;
        }


        
        
    }
}