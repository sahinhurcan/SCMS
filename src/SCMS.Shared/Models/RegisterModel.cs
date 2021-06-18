﻿using System.ComponentModel.DataAnnotations;

namespace SCMS.Shared
{
	public class RegisterModel
	{
		[Required]
		public string Name { get; set; }
		[Required]
		[EmailAddress]
		public string Email { get; set; }
		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; }
		[Required]
		[DataType(DataType.Password)]
		[Compare("Password", ErrorMessage = "Passwords do not match")]
		public string PasswordConfirm { get; set; }
	}
}
