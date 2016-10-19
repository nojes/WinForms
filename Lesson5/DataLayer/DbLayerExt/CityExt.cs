using DataLayer.DbLayer;

namespace DataLayer.DbLayerExt
{
    public class CityExt
    {
        public string RegionName { get; set; }
        public string CityName { get; set; }
        public virtual Region Region { get; set; }
    }
}