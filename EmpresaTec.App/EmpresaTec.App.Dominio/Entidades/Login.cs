using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace EmpresaTec.App.Dominio
{
    public class Login
    {
        [Key]
        public int loginId {get;set;}
        [MaxLength(30)]
        public string email {get;set;}
        [MaxLength(20)]
        public string password {get;set;}
        public int? UserId {get;set;}
        public User user {get; set;}
        public DateTime lastConnection {get;set;} //Duda de como se pone

    }
}