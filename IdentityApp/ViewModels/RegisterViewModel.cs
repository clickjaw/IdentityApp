using System;
using System.ComponentModel.DataAnnotations;

namespace IdentityApp.ViewModels
{
	public class RegisterViewModel
	{
		[Required]
		[EmailAddress]
		[Display(Name = "Email")]
		public string Email { get; set; }

		[Required]
		[Display(Name = "UserName")]
		public string UserName { get; set; }

		[Required]
		[StringLength(100)]
		[DataType(DataType.Password)]
		[Display(Name = "Password")]
		public string Password { get; set; }

		[DataType(DataType.Password)]
		[Display(Name = "Confirm Password")]
		[Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
		public string ConfirmPassword { get; set; }

		public string? ReturnUrl { get; set; }

	}
}

