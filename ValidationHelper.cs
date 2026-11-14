using System;

namespace Device_Maintenance_and_Repair_Center
{
    public static class ValidationHelper
    {
        // خاصية ثابتة للعد والإحصاء
        public static int TotalDevicesProcessed { get; private set; }

        public static void IncrementDeviceCount()
        {
            TotalDevicesProcessed++;
        }

        // دالة ثابتة للتحقق من صحة الرقم التسلسلي
        public static bool IsValidSerialNumber(string serial)
        {
            return !string.IsNullOrWhiteSpace(serial) && serial.Length >= 4;
        }
    }
}