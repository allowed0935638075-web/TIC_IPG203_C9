using System;

namespace Device_Maintenance_and_Repair_Center
{
    // فئة مجردة تطبق الواجهة وتحتوي دالة مجردة لحساب التكلفة
    public abstract class Appliance : IDeviceOperations
    {
        private readonly string _serialNumber; // خاصية للقراءة فقط بعد الإنشاء
        private string _clientName;
        private string _status;
        protected double baseRepairCost;

        public string SerialNumber
        {
            get { return _serialNumber; }
        }

        public string ClientName
        {
            get { return _clientName; }
            set { _clientName = value; }
        }

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
        // المُنشئ (Constructor)
        protected Appliance(string serialNumber, string clientName, double baseRepairCost)
        {
            _serialNumber = serialNumber;
            _clientName = clientName;
            this.baseRepairCost = baseRepairCost;
            _status = "Pending";
        }
        // دالة مجردة لحساب تكلفة الإصلاح (تتحقق في الفئات المشتقة)
        public abstract double CalculateRepairCost();
        // تنفيذ عمليات الواجهة
        public virtual void StartRepair()
        {
            _status = "Under Maintenance";
        }

        public abstract string GetDeviceDetails();
    }
}