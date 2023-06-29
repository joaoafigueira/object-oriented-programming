namespace OOP
{
    public abstract class Appliance
    {
        private readonly string _name;
        private readonly int _voltage;

        public Appliance(string name, int voltage)
        {
            _name = name;
            _voltage = voltage;
        }

        public abstract void On();

        public abstract void Off();

        // The idea behind the abstract class is to have an initial 
        // structure, where other classes that inherit from it will specialize their behavior.
    }
}
