namespace APIparcial.Models
{
    using System.ComponentModel.DataAnnotations;

    public enum TipoEstado
    {
        Activo,
        Inactivo

    }
    public enum Unidad
    {
        Botella,
        Metro,
        Litro,
        Caja
    }
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [Required]
        [Display(Name="Nombre del Producto")]
        public string Nombre { get; set; }

        public double Precio { get; set; }
        [Required]
        public int Cantidad { get; set; }

        [Required]
        public Unidad Unidad{ get; set; }
        [Required]
        public TipoEstado Estado { get; set; }

    }
}