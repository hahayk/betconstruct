This Project demonstartes the usage of inheritance.
It contians base class <b>ElectronicEquipment</b> that has some properties and <b>ElectricityConsuption()</b> function that should have all electronic equipments.
There are 2 classes (VacumCleaner and TV) which are inherited from base and are overriden <b>ElectricityConsuption()</b> function.
Below is the code snipet of the base class:

```C#
    class ElectronicEquipment
    {
        public string Purpose { get; set; }
        public int Price { get; set; }
        public int Power { get; set; } //Amper
        public int Voltage { get; set; } //110-220V
        public int Mass { get; set; } //KG

        public virtual int ElectricityConsuption() { return 0; } //Watt
    }
```

and the example of usage of inherited class

```C#
            TV t = new TV();
            t.ScreenSize = 60;
            t.Purpose = "Leisure";
            t.HasRemoteControl = true;
            t.Price = 800;
            t.ScrType = ScreenTypes.OldBigScreen;
            t.Power = 10;
            t.Voltage = 110;
            int powerConsuption = t.ElectricityConsuption();
```