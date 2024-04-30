using System.ComponentModel.DataAnnotations;

namespace AuthSystem.DTOs
{
	public class RegisterRequest
	{
		[Required]
		public string? Username { get; set; }
		[Required]
		public string? PhoneNumber { get; set; }
		[Required]
		public string? Password { get; set; }
	}
}
