namespace GoodPracticesInOOP.BadPractices.BO
{
    public class ShoopingCartBO
    {
        //Below the methods are separated from the class that contains the attributes.
        //To access the ShoopingCart attributes we need to use the get and set methods from the Shooping Cart Class.
        //This behavior below causes acouplament because we need to keep creating relations and classes as our application grows, to
        //represent the Class with attributes and the class with the methods.
        //The method to program below is called as structure OOP (where programs are know to do sequence, decision and iteration)

        public Product[] ListProducts(Product product)
        {
            ////List all the products 

            return null;
        }

        public void AddProduct(Product product)
        {
            //Logic to Add A product. We need to verify if this product already exist.
        }

        public void RemoveProduct(Product product)
        {
            //Logic to remove just one product.
        }

        public void RemoveAllProductsFromShoopingCart(Product product)
        {
            //Logic to remove all the products from a shopping cart.
        }

        public void FinalizeOrder()
        {
            //Logic to create a sell from a shopping cart.
        }
    }
}
