﻿using System;
using System.Collections.Generic;

namespace ValidPeople.Web.Shared.People
{
    public class PersonViewModel
    {
        public Guid Id { get; set; }
        public NameViewModel Name { get; set; }
        public DateTime Birth { get; set; }
        public IEnumerable<ParentViewModel> Parents { get; set; }
        public CpfViewModel Cpf { get; set; }
        public EnumerationViewModel Hobby { get; set; }
        public double Revenue { get; set; }
    }
}