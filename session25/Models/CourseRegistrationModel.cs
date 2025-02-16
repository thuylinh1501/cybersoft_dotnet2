using System.ComponentModel.DataAnnotations;

public class CourseRegistrationModel
{
    [Required(ErrorMessage = "Please input Full Name")]
    public string FullName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please enter a valid email address.")]
    [EmailAddress(ErrorMessage = "Invalid Email Address")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please input Phone Number")]
    [RegularExpression(@"^\d{10,12}$", ErrorMessage = "Phone number must be 10-12 digits.")]
    public string PhoneNumber { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please select a course")]
    public string SelectedCourse { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please select a learning method")]
    public string LearningMethod { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please select a start date")]
    public DateTime StartDate { get; set; }

    public string Comments { get; set; } = string.Empty;

    [Required(ErrorMessage = "You must agree to the terms and policies.")]
    public bool AgreeToTerms { get; set; } = false;
}