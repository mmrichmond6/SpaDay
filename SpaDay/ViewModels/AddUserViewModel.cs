using System.ComponentModel.DataAnnotations;

namespace SpaDay.ViewModels
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Name must be between 5 and 15 characters")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Sorry, but the given password is too short. Passwords must be at least 6 characters long.")]
        [Compare(nameof(VerifyPassword), ErrorMessage = "Passwords do not match.")]
        public string Password { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Verify Password is required")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Verification of password is required")] 
        public string VerifyPassword { get; set; }


    }
}
