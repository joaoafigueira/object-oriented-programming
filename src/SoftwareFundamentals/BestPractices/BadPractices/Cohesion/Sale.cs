namespace BestsPracticesInOOP.BadPractices.Cohesion
{
    public class Sale
    {
        private string clientName;
        private string clientCpf;
        private string deliveryAddress;
        private int cep;
        //private Debt payment;
        //private Product[] products;
        private string sellersName;
        private double sellerComission;
    }

    // This is a example of Bad Cohesion because the class above have
    // many characteristics that do not directly concern itself
}
