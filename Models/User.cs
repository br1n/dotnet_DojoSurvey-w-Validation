using System.ComponentModel.DataAnnotations;
namespace DojoSurvey_Validation
{
    public class User
    {
        [Required(ErrorMessage="Name field cannot be blank")]
        [RegularExpression("^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$", ErrorMessage="Characters must only be letters")]
        [MinLength(2, ErrorMessage="Name must be more than 2 charatcters")]
        public string Name { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public string Language { get; set; }

        [MaxLength(20, ErrorMessage="Comment cannot be longer than 20 characters")]
        public string Comment { get; set; }
    }
}