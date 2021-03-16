﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OCP_Principle
{
    public class PersonModel : IApplicantModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccounts AccountProcessor { get; set; } = new Accounts();

    }
}
