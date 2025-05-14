namespace EVENTEASEN_5.Models
{
    using Microsoft.AspNetCore.Http;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Venue
    {
        public int VenueID { get; set; }

        [Required]
        [StringLength(250)]
        public string NAME { get; set; }

        [Required]
        [StringLength(255)]
        public string Location { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Capacity must be greater than 0")]
        public int capacity { get; set; }

        public string ImageURL { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }
        public object Events { get; internal set; }
    }
}
