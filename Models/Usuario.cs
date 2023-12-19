namespace WebApplication1.Models
{
    internal class Usuario
    {
        int id, edad;
        String nombre, dni, email;
        CarritoDeCompra carrito;
        public Usuario(int id, int edad, string nombre, string dni, string email)
        {
            this.id = id;
            this.edad = edad;
            this.nombre = nombre;
            this.dni = dni;
            this.email = email;
            this.carrito = new CarritoDeCompra();
        }
    }
}