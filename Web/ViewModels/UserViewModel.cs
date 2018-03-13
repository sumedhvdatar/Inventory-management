using System.ComponentModel.DataAnnotations;
using Core.Domains;

namespace Web.ViewModels
{
    public class UserViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "UserName")]
        public string UserName { get; set; }

        [MaxLength(200)]
        [Display(Name = "Email Id")]
        public string EmailId { get; set; }

        [Display(Name = "Active")]
        public bool IsActive { get; set; }

        public UserViewModel(User user)
        {

            Id = user.Id;
            UserName = user.UserName;
            EmailId = user.EmailId;
            IsActive = user.IsActive;

        }

        public UserViewModel()
        {

        }
    }
}