using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace BandRegister.Models
{
    public class Band
    {
        //public Band(string name, string members, decimal honorarium, string genre)
        //{
        //    this.Name = name;
        //    this.Members = members;//.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        //    this.Honorarium = honorarium;
        //    this.Genre = genre;
        //}

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Members { get; set; }

        [Required]
        public decimal Honorarium { get; set; }

        [Required]
        public string Genre { get; set; }

    }
}
