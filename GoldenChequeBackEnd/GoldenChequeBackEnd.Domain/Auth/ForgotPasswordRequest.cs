using System.ComponentModel.DataAnnotations;

namespace GoldenChequeBackEnd.Domain.Auth
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
