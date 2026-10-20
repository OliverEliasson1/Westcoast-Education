using System;
using Westcoast_Education.Interface;

namespace Westcoast_Education.Models;

public class Administrator : Person, IHasIdentityNumber
{
    public string PersonalIdentityNumber { get; set; }

}
