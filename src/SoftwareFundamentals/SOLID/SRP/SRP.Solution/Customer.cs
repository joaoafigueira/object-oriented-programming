using System;

namespace SOLID.SRP.SRP.Solution
{
    public class Customer
    {
       public int CustomerId { get; set; }
       public string Name { get; set; }
       public Email Email { get; set; }
       public CPF Cpf { get; set; }
       public DateTime RegistrationDate { get; set; }

       public bool Validate()
       {
            return Email.Validate() && Cpf.Validate();
       }
    }
}
