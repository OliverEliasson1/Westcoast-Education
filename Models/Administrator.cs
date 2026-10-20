namespace Westcoast_Education.Models;

public class Administrator : EducationLeader
{
    public override string ToString()
    {
        return $"{base.ToString}\nAnställningsdatum: {EmploymentDate}";
    }
}
