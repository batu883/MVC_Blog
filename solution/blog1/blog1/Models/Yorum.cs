//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace blog1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Yorum
    {
        public int YorumID { get; set; }
        public string YorumcuAd { get; set; }
        public string YorumcuMail { get; set; }
        public string Yorumİçerik { get; set; }
        public Nullable<int> PostYorumdakiID { get; set; }
    
        public virtual postlar postlar { get; set; }
    }
}
