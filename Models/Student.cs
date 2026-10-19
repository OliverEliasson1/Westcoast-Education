namespace Westcoast_Education;

public class Student() : Person
{
    public required string PersonalIdentityNumber { get; set; }
    public required Address Address { get; set; }

    public override string ToString()
    {
        return $"{base.ToString()}\nPersonnummer: {PersonalIdentityNumber}\nAdress: {Address}";
    }
}