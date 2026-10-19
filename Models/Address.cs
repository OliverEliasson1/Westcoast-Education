namespace Westcoast_Education;

public class Address
{
    public required string StreetAddress { get; set; }
    public required string PostalCode { get; set; }
    public required string City { get; set; }

    public override string ToString()
    {
        return $"{StreetAddress}\n{PostalCode} {City}";
    }
}