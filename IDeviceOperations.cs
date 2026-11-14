namespace Device_Maintenance_and_Repair_Center
{
    // 1. التجريد: واجهة تحتوي على العمليات الأساسية المشتركة بين الأجهزة
    public interface IDeviceOperations
    {
        void StartRepair();
        string GetDeviceDetails();
    }
}