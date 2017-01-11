namespace InheritanceElectronics
{
    class ElectronicEquipment
    {
        public string Purpose { get; set; }
        public int Price { get; set; }
        public int Power { get; set; } //Amper
        public int Voltage { get; set; } //110-220V
        public int Mass { get; set; } //KG

        public virtual int ElectricityConsuption() { return 0; } //Watt
    }
}
