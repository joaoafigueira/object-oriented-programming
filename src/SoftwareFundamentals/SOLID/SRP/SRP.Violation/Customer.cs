using System;
using System.Data.SqlClient;
using System.Net.Mail;

namespace SOLID.SRP.Violation
{
    // This Customer Class Violates de Single Responsability Principle because have more than one responsability.

    // This is a Customer Class, but if we need to change something about email this class that have
    // the responsability to be a customer is impacted, breaking the SRP.

    public class Customer
    {
        public int CustomerId {  get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime RegistrationDate { get; set; }

        public string AddClient()
        {
            if (!Email.Contains("@"))
                return "Client with invalid e-mail";

            if (CPF.Length != 11)
                return "Client with invalid CPF";

            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "MyConnectionString";
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO CUSTOMER (NAME, EMAIL, CPF, REGISTRATIONDATE) VALUES (@name, @email, @cpf, @regDate))";

                cmd.Parameters.AddWithValue("name", Name);
                cmd.Parameters.AddWithValue("email", Email);
                cmd.Parameters.AddWithValue("cpf", CPF);
                cmd.Parameters.AddWithValue("regDate", RegistrationDate);

                cn.Open();
                cmd.ExecuteNonQuery();
            }

            var mail = new MailMessage("company@company.com", Email);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = "Welcome.";
            mail.Body = "Congratulations! You're registered";
            client.Send(mail);

            return "Client send with success!";
        }
    }
}
