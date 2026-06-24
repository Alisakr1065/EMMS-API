namespace Models
{
    public class Equipment
    {
        public int EquipmentId { get; set; }
        public string? EquipmentName { get; set; }
        public string? EquipmentCode { get; set; }

        public int EquipmentTypeId { get; set; }
        public string? EquipmentType { get; set; } 

        public string? Location { get; set; }
        public DateTime InstallationDate { get; set; }

        public int EquipmentStatusId { get; set; }
        public string? Status { get; set; }

        public string? Manufacturer { get; set; }
        public string? Model { get; set; }
        public string? SerialNumber { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime LastMaintenanceDate { get; set; }
    }
}
