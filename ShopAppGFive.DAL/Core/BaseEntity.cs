

namespace ShopAppGFive.DAL.Core
{
    public abstract class BaseEntity
    {
        public DateTime creation_date { get; set; } = DateTime.Now;
        public int creation_user { get; set; } = 1;
        public DateTime? modify_date { get; set; }
        public int? modify_user { get; set; }
        public int? delete_user { get; set; }
        public DateTime? delete_date { get; set; }
        public bool deleted { get; set; } = false;
    }
}
