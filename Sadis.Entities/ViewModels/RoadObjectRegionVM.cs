using System.ComponentModel.DataAnnotations;

namespace Sadis.Entities.ViewModels
{
    public class RoadObjectRegionVM
    {
        public int C_REGION { get; set; }
        [Required(ErrorMessage = "Введите наименование региона")]
        public string N_REGION { get; set; } = null!;
        [Required(ErrorMessage = "Введите коэффициент")]
        public double COEF_SALARY { get; set; }
        [Required(ErrorMessage = "Выберите климатическую зону")]
        public int C_CLIMAT_ZONE { get; set; }
        public string? N_CLIMAT_ZONE { get; set; }
    }
}
