using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Autor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdAutor { get; set; }
        public String Nombre { get; set; }
        public String Biografia { get; set; }



        public Autor(int idAutor, string nombre, string biografia)
        {
            this.IdAutor = idAutor;
            this.Nombre = nombre;
            this.Biografia = biografia;
        }
    }
}