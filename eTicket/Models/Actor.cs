using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "profile picture")]
        [Required(ErrorMessage = "Profile Picture is required")]
        public string ProfilePictureURL { get; set; }
        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 chars")]
        [Display(Name = "Full name")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Biography is required")]
        [Display(Name = "Biography")]
        public string Bio { get; set; }

        //relationship
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
