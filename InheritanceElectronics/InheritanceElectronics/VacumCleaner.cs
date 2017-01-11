namespace InheritanceElectronics
{
    class VacumCleaner : ElectronicEquipment
    {
        public string Nasadka { get; set; }
        public int VacumBlowPower { get; set; } //power rate //քաշել, փչել
        public string BodyColor { get; set; }

        public override int ElectricityConsuption()
        {
            return Voltage * Power * VacumBlowPower;
        }
    }
}
