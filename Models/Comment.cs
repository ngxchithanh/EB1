//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EHiHiBook.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comment
    {
        public int CommentID { get; set; }
        public string Content { get; set; }
        public Nullable<int> MembershipID { get; set; }
        public Nullable<int> BookID { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual Membership Membership { get; set; }
    }
}