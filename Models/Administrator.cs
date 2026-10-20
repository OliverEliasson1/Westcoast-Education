using System;
using Westcoast_Education.Interface;

namespace Westcoast_Education.Models;

public class Administrator : Person, IHasPersonalIdentityNumber
{
    public required string PersonalIdentityNumber { get; set; }

}
