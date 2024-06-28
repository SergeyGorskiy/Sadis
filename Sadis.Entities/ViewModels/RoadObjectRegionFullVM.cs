using Microsoft.AspNetCore.Mvc.Rendering;

namespace Sadis.Entities.ViewModels
{
    public class RoadObjectRegionFullVM
    {
        public RoadObjectRegionVM RegionVM { get; set; } = null!;
        public List<RoadObjectRegionVM> RegionVMs { get; set; } = null!;
        public SelectList ClimateZones { get; set; } = null!;
    }
}
