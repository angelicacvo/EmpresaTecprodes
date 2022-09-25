using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace EmpresaTec.App.Dominio
{
    public class Services
    {
        [Key]
        public int servicesId {get;set;}
        [MaxLength(50)]
        public string name {get;set;}
        [MaxLength(1000)]
        public string description {get;set;}

        public List<Project> projects {get;set;} 
    }
}