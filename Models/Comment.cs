using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiggerAsp.Models
{
    public class Comment
    {
        public int CommentId { get; set; }  // auto generated

        public string CommentActual { get; set; }

        // Member Info
        public int CommentMemberId { get; set; }  // foreign key
        public User Member { get; set; }

        // Photo Info
        public int CommentPhotoId { get; set; }  // foreign key
        public Photo Photo { get; set; }
        
    }
}
