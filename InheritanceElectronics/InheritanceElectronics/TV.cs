namespace InheritanceElectronics
{
    class TV : ElectronicEquipment
    {
        public ScreenTypes ScrType { get; set; }
        public int ScreenSize { get; set; }
        public bool HasRemoteControl { get; set; }

        public override int ElectricityConsuption()
        {
            return Voltage * Power;
        }
    }
}
