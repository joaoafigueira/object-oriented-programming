namespace GoodPracticesInOOP.BadPractices.BO
{
    public class ShoppingCart
    {
        //Here we're using a Bussines Object, where we separate the data from the behaviors
        //Causing acouplament, this goes against one of the
        //precepts of OOP: agglutinating data and information in a code unit.

        private string code { get; set; }
        private Product[] products { get; set; }


        //This is an example of an Anemic Model.
        //But which way should we go? Depends of which way best fits the needs of your application.
        //So the main point here is, if you know you're application well, you know which way to go.
    }
}
