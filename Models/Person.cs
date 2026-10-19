namespace Westcoast_Education;

public abstract class Person
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }
    public required string PhoneNumber { get; set; }

    public override string ToString()
    {
        return $"Förnamn: {FirstName}\nEfternamn: {LastName}\nEmail: {Email}\nTelefon: {PhoneNumber}";
    }
}
