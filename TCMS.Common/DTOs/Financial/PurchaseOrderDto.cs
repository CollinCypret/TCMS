using System.ComponentModel.DataAnnotations;
using TCMS.Common.DTOs.Shipment;
using TCMS.Common.enums;

namespace TCMS.Common.DTOs.Financial
{
    public class PurchaseOrderDto
    {
        public int PurchaseOrderId { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public ShipmentDirection ShipmentDirection { get; set; }
        public DateTime DateCreated { get; set; }
        public int ManifestId { get; set; }
        public ManifestDto Manifest { get; set; }
        public List<ShipmentDetailDto> Shipments { get; set; }
        public decimal ShippingCost { get; set; }
        public bool ShippingPaid { get; set; }
        public decimal TotalItemCost { get; set; }
        public decimal TotalCost { get; set; }
    }
}
