using System.ComponentModel.DataAnnotations;

namespace Sadis.Entities.ViewModels
{
    public class RoadObjectVM
    {
        public int C_OBJECT { get; set; }
        public int? C_BRIDGE_OBJECT { get; set; }
        [Required(ErrorMessage = "Выберите тип объекта")]
        //[Range(1, int.MaxValue, ErrorMessage = "Выберите тип объекта")]
        public int C_TYPE_OBJECT { get; set; }
        public string? N_TYPE_OBJECT { get; set; }
        [Required(ErrorMessage = "Выберите регион")]
        //[Range(1, int.MaxValue, ErrorMessage = "Выберите регион")]
        public int C_REGION { get; set; }
        public string? N_REGION { get; set; }
        [Required(ErrorMessage = "Выберите дорогу")]
        //[Range(1, int.MaxValue, ErrorMessage = "Выберите дорогу")]
        public int C_ROAD { get; set; }
        public string? N_ROAD { get; set; }
        [Required(ErrorMessage ="Введите наименование объекта")]
        public string N_OBJECT { get; set; } = null!;
        [Required(ErrorMessage = "Введите код")]
        public string CODE { get; set; } = null!;
        public double? BEGKM { get; set; }
        public double? ENDKM { get; set; }
        public string? BEGKM_STOLB { get; set; }
        public string? ENDKM_STOLB { get; set; }
        public string? N_EXPL_CATEGORY { get; set; }
        public bool ENABLED_FOR_JORNAL { get; set; }
        public string? ENABLED_FOR_JORNAL_STR { get; set; }
        public string? NAME_ROAD { get; set; }
        public int? C_STATUS_OBJECT { get; set; }
        [Required(ErrorMessage = "Выберите эксплуатационную категорию")]
        //[Range(1, int.MaxValue, ErrorMessage = "Выберите эксплуатационную категорию")]
        public int C_EXPL_CATEGORY { get; set; }
        public int? C_TYPE_BRIDGE { get; set; }
        public int? C_BRIDGE_MATERIAL { get; set; }
        public string? BARRIER { get; set; }
        public string? GABARIT { get; set; }
        public DateTime? DATE_LEAD_IN { get; set; }
        public DateTime? DATE_LEAD_OUT { get; set; }
        public double? LENGTH { get; set; }
        public double? MP { get; set; }
        public double? COEF { get; set; }
        public string? N_BRIDGE_LET { get; set; }
        public string? NAME_CLIMAT_ZONE { get; set; }
    }
}
