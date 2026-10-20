using System;
using Westcoast_Education.Interface;

namespace Westcoast_Education.Models;

public class EducationLeader : Person, IHasIdentityNumber
{
    public string PersonalIdentityNumber { get; set; }
}
