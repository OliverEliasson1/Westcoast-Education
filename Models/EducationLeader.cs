using Westcoast_Education.Interface;

namespace Westcoast_Education.Models;

public class EducationLeader : Teacher, IHasPersonalIdentityNumber
{
    public required string PersonalIdentityNumber { get; set; }
    public required DateOnly EmploymentDate { get; set; }

    public override string ToString()
    {
        return $"{base.ToString()}\nPersonnummer: {PersonalIdentityNumber}\nAnställningsdatum: {EmploymentDate}";
    }
}
