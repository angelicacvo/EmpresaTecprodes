using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace EmpresaTec.App.Dominio
{
    public class User
    {
        [Key]
        public int userId {get; set;}
        [MaxLength(50)]
        public string name {get; set;}
        [MaxLength(30)]
        public string IdNumber {get; set;}
        [MaxLength(20)]
        public string phoneNumber {get; set;}
        [MaxLength(30)]
        public string address {get; set;}
        public int? projectId {get; set;}
        public Project project {get; set;}
        
        public List<Project> projects {get;set;}   
    }
}