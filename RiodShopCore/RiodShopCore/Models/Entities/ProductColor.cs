using System;

namespace RiodShopCore.Models.Entities
{
    public class ProductColor
    {
        public int Id { get; set; }
        public string HexCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? DeletedByUserId { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
