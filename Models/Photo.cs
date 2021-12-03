using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using TiggerAsp.Models;

namespace TiggerAsp.Models
{
    public class Photo
    {
        // EF Core will configure the database to generate this value
        public int PhotoId { get; set; }        

        //[Required(ErrorMessage = "Please input the full file name.")]
        public string FileName { get; set; }  // get filename automatically
        
        public string UploadedBy { get; set; }  // get uploadedby automatically
        
        public string Description { get; set; }

        //  Event Info -----------------------------------
        public string OccasionId { get; set; }  // foreign key property
        public Occasion Occasion { get; set; }

        public string Slug =>
            FileName?.Replace(' ', '-').ToLower() + '-' + OccasionId?.ToString();
    }
}
