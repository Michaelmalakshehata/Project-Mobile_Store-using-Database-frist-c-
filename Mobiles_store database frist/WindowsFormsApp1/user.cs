//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace main
{
    using System;
    using System.Collections.Generic;
    
    public partial class user
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public string Password { get; set; }
        public string Confirm_Password { get; set; }
        public string Check_Answer { get; set; }
        public string Answer { get; set; }
        public user(string name, int phone, string pas, string confirm_pass, string chkq, string r)
        {

            Name = name;
            Phone = phone;
            Password = pas;
            Confirm_Password = confirm_pass;
            Check_Answer = chkq;
            Answer = r;
        }
    }
}
