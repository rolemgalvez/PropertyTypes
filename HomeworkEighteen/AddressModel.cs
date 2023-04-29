namespace HomeworkEighteen
{
    public class AddressModel
    {
        public string Street { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string FullAddress
        {
            get
            {
                return $"{Street}, {Address}, {City}, {State}, {ZipCode}";
            }
        }

        public AddressModel()
        {

        }

        public AddressModel(string zipCode)
        {
            ZipCode = zipCode;
        }
    }
}
