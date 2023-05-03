using System.ComponentModel.DataAnnotations;

namespace eTicket_Course.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Profile Picture is required")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is required")]
        public string FullName { get; set;}

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Bio is required")]
        [StringLength(50, MinimumLength = 5, ErrorMessage ="It has to be between 50 and 5")]
        public string Bio { get; set;}

        //relationships

        public List<Actor_Movie> Actors_Movies { get; set; }


    }
}
