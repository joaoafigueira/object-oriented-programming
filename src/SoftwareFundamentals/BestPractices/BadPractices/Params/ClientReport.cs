namespace BestsPracticesInOOP.BadPractices.Params
{
    public class ClientReport
    {

       public byte[] CustomerOrders(string clientCpf, string clientName, 
           string userLoggedName, string registeredLoggedUser, DateTime initialDate, 
           DateTime endDate, string reportType)
        {
            return null;
        }

        // The above parameters refer to classes that the system itself handles,
        // So why not use these classes?

        // The more you use disassociated params in a large quantity like above, the more coupling it creates.
        // If a new parameter arrives one day it will be complicated to add it. Nonetheless, if a class is passed as param,
        // The call to the method above it is going to be intact because the params no more it is going to be coupled
    }
}
