namespace OOP.Class_x_Object
{
    public class Home
    {
        public int Size { get; set; }
        public int Floors { get; set; }
        public decimal Value { get; set; }
        public int numberVacancies { get; set; }

        // A class represents an entity of the real World,
        // anything that exists in the real world and you want
        // to represent a information structure of that, is a Class.
    }

    public class Object
    {
        public Object()
        {

            var home = new Home()
            {
                Size = 100,
                Floors = 2,
                Value = 100000,
                numberVacancies = 3
            };
        }

        // An object only exists in memory.
        // An object it is a representation of a class in memory.
    }
}
 