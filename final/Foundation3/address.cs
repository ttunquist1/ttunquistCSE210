class Address{
    private string _streetAddress {get; set;}
    private string _city {get; set;}
    private string _state {get; set;}
    private string _country {get; set;}
    private string _zipCode {get; set;}

    public Address (string streetAddress, string city, string state, string country, string zipCode)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
        _zipCode = zipCode;
    }

    public string GetStreetAddress()
    {
        return _streetAddress;
    }
}