using Microsoft.AspNetCore.Mvc.Rendering;
using Sadis.Entities.Models;

namespace Sadis.Entities.ViewModels
{
    public class RoadObjectsFullVM
    {
        public RoadObjectsVM ObjectVM { get; set; } = null!;
        public List<RoadObjectsVM> ObjectVMs { get; set; } = null!;
        public SelectList TypeObjects { get; set; } = null!;
        public SelectList Regions { get; set; } = null!;
        public SelectList Roads { get; set; } = null!;
        public SelectList ExplCategories { get; set; } = null!;
        public SelectList Statuses { get; set; } = null!;
        public SelectList BridgeTypes { get; set; } = null!;
        public SelectList BridgeMaterials { get; set; } = null!;
    }
}
