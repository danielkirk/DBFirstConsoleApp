//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBFirstConsoleApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Profile
    {
        public int UserId { get; set; }
        public string AspNetUserId { get; set; }
        public string Teams { get; set; }
        public string Bio { get; set; }
        public string Styles { get; set; }
        public int Experience { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual User User { get; set; }
    }
}
