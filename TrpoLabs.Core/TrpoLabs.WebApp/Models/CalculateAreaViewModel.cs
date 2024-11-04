using System.ComponentModel.DataAnnotations;

namespace TrpoLabs.WebApp.Models
{
    public class CalculateAreaViewModel
    {
        [Required(ErrorMessage = "Введите радиус.")]
        [Range(0.1, double.MaxValue, ErrorMessage = "Радиус должен быть больше нуля.")]
        public double Radio { get; set; }

        [Required(ErrorMessage = "Введите высоту.")]
        [Range(0.1, double.MaxValue, ErrorMessage = "Высота должна быть больше нуля.")]
        public double Altura { get; set; }

        public double Resultado { get; set; }
    }
}
