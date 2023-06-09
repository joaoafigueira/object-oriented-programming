namespace GoodPracticesInOOP.GoodPractices.DomainModel
{
    public class ShoppingCart
    {
        // Below we're using a good example in OOP a Domain Model.
        // OOP preaches that we need to agroup data and behavior to
        // get less acoplament (reduce the number os classes...).

        private string code;
        private Product[] products;

        public Product[] ListProducts(Product product)
        {
            //List all the products

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

        //Above we're using the approach to just create get s and set s in the exception
        //Business Method that should be use to access the attributes.

    }
}