using Microsoft.AspNetCore.Mvc.Rendering;

namespace Sadis.Entities.ViewModels
{
    public class RoadObjectFullVM
    {
        public RoadObjectVM ObjectVM { get; set; } = null!;
        public List<RoadObjectVM> ObjectVMs { get; set; } = null!;
        public SelectList TypeObjects { get; set; } = null!;
        public SelectList Regions { get; set; } = null!;
        public SelectList Roads { get; set; } = null!;
        public SelectList ExplCategories { get; set; } = null!;
        public SelectList Statuses { get; set; } = null!;
        public SelectList BridgeTypes { get; set; } = null!;
        public SelectList BridgeMaterials { get; set; } = null!;
    }
}
