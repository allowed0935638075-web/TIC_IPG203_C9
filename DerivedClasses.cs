namespace Device_Maintenance_and_Repair_Center
{
    // 1. الثلاجة
    public class Refrigerator : Appliance
    {
        public bool HasFreezerIssue { get; set; }

        public Refrigerator(string serialNumber, string clientName, double baseRepairCost, bool hasFreezerIssue)
            : base(serialNumber, clientName, baseRepairCost)
        {
            HasFreezerIssue = hasFreezerIssue;
        }

        public override double CalculateRepairCost()
        {
            return HasFreezerIssue ? baseRepairCost + 50.0 : baseRepairCost;
        }

        public override string GetDeviceDetails()
        {
            return $"[Refrigerator] - S/N: {SerialNumber} | Client: {ClientName} | Status: {Status} | Cost: ${CalculateRepairCost()}";
        }
    }

    // 2. الغسالة
    public class WashingMachine : Appliance
    {
        public int DrumCapacity { get; set; }

        public WashingMachine(string serialNumber, string clientName, double baseRepairCost, int drumCapacity)
            : base(serialNumber, clientName, baseRepairCost)
        {
            DrumCapacity = drumCapacity;
        }

        public override double CalculateRepairCost()
        {
            return DrumCapacity > 8 ? baseRepairCost + 40.0 : baseRepairCost;
        }

        public override string GetDeviceDetails()
        {
            return $"[Washing Machine] - S/N: {SerialNumber} | Client: {ClientName} | Status: {Status} | Cost: ${CalculateRepairCost()}";
        }
    }

    // 3. المكيف
    public class AirConditioner : Appliance
    {
        public bool NeedsGasRecharge { get; set; }

        public AirConditioner(string serialNumber, string clientName, double baseRepairCost, bool needsGasRecharge)
            : base(serialNumber, clientName, baseRepairCost)
        {
            NeedsGasRecharge = needsGasRecharge;
        }

        public override double CalculateRepairCost()
        {
            return NeedsGasRecharge ? baseRepairCost + 75.0 : baseRepairCost;
        }

        public override string GetDeviceDetails()
        {
            return $"[Air Conditioner] - S/N: {SerialNumber} | Client: {ClientName} | Status: {Status} | Cost: ${CalculateRepairCost()}";
        }
    }
}