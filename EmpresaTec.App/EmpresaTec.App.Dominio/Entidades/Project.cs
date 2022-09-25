using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace EmpresaTec.App.Dominio
{
    public class Project
    {
        [Key]
        public int projectId {get;set;}
        [MaxLength(50)]
        public string name {get;set;}
        [MaxLength(20)]
        public string code {get;set;}
        public DateTime stimatedDate {get;set;}
        [MaxLength(50)]
        public string cost {get;set;}
        public DateTime startDate {get;set;}
        [MaxLength(400)]
        public string description {get;set;}
        public int? actualStateId {get;set;}
        public ActualState actualState {get;set;}
        public int? servicesId {get;set;}
        public Services services {get;set;}
                
    }
}