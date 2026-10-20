using System;
using Westcoast_Education.Interface;

namespace Westcoast_Education.Models;

public class EducationLeader : Person, IHasPersonalIdentityNumber
{
    public required string PersonalIdentityNumber { get; set; }
}
