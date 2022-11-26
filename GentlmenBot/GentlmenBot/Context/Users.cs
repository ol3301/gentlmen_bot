using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;

namespace GentlmenBot.Context
{
    public class Users
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string LineManager { get; set; }
        public string LocalPeoplePartner { get; set; }
        public DateTimeOffset NextPerfomanceReview { get; set; }
        public string EnglishCources { get; set; }
        public int EnglishCourcesCostCoverage { get; set; }
        public string PossibleMentor { get; set; }

    }
}
