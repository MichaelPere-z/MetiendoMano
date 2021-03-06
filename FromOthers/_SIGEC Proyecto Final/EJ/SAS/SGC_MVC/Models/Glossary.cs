using System;
using System.Collections.Generic;

namespace SGC_MVC.Models
{
    public partial class Glossary
    {
        public Glossary()
        {
            this.Rules = new List<Rule>();
            this.Procedures = new List<Procedure>();
        }

        public int ID { get; set; }
        public string term { get; set; }
        public string definition { get; set; }
        public Nullable<System.DateTime> createDate { get; set; }
        public Nullable<System.DateTime> updateDate { get; set; }
        public int companyID { get; set; }
        public Nullable<int> createUser { get; set; }
        public virtual Company Company { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Rule> Rules { get; set; }
        public virtual ICollection<Procedure> Procedures { get; set; }
    }
}
