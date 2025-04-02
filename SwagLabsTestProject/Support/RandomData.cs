
namespace SwagLabsTestProject.Support
{
    public class CheckoutForm
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PostalCode { get; set; }
    }

    public class RandomData
    {
        public CheckoutForm GetRandomCheckoutForm()
        {
            return new CheckoutForm
            {
                FirstName = Faker.Name.FirstName(),
                LastName = Faker.Name.LastName(),
                PostalCode = Faker.Address.USZipCode()
            };
        }
    }
}
