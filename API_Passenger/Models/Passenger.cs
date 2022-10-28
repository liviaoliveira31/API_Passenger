using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace API_Passenger.Models
{
    [BsonIgnoreExtraElements]
    public class Passenger     
    {       
        [StringLength(14)]
        [Required]
        public string CPF { get; set; }
        [StringLength(30)]
        [Required]
        public string Name { get; set; }     
        public char? Gender { get; set; }
        [StringLength(14)]
        public string Phone { get; set; }    
        public DateTime DtBirth { get; set; }
        public DateTime DtRegister { get; set; }
        public bool Status { get; set; }
       // public Address Address { get; set; }

    }
}
