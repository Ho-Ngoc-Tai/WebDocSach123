using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebDocSach.Models
{
    public class Follow
    {
        public int Id { get; set; }
        public Book Book { get; set; }
        [Required]
        public int IdBook { get; set; }
        public ApplicationUser Followee { get; set; }
        [Required]
        [StringLength(255)]
        public string FolloweeId { get; set; }
    }
}