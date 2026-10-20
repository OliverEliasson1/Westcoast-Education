using Westcoast_Education.Interface;

namespace Westcoast_Education.Models;

public class Student : Person, IHasPersonalIdentityNumber
{
    public required string PersonalIdentityNumber { get; set; }
    

    public override string ToString()
    {
        return $"{base.ToString()}\nPersonnummer: {PersonalIdentityNumber}";
    }
}