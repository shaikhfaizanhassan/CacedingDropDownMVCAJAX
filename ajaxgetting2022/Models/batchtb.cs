//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ajaxgetting2022.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class batchtb
    {
        public batchtb()
        {
            this.studenttbs = new HashSet<studenttb>();
        }
    
        public int BatchID { get; set; }
        public string BatchName { get; set; }
    
        public virtual ICollection<studenttb> studenttbs { get; set; }
    }
}