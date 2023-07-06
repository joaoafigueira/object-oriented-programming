using System.Data;
using System.Data.SqlClient;

namespace SOLID.SRP.SRP.Solution
{
    public class CustomerRepository
    {
        public void AddCustomer(Customer customer)
        {
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "MyConnectionString";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO CUSTOMER (NAME,EMAIL,CPF,REGISTRATIONDATE) VALUES (@name,@email,@cpf,@regDate))";

                cmd.Parameters.AddWithValue("name", customer.Name);
                cmd.Parameters.AddWithValue ("email", customer.Email);
                cmd.Parameters.AddWithValue ("cpf", customer.Cpf);
                cmd.Parameters.AddWithValue ("regDate", customer.RegistrationDate);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
