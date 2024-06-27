﻿using System.ComponentModel.DataAnnotations;

namespace FurnitureStore.PL.ViewModels
{
	public class UserViewModel
	{
		public string Id { get; set; }
		[Display(Name ="First Name")]
		public string FName { get; set; }
        [Display(Name = "Last Name")]
        public string LName { get; set; }


		public string Email { get; set; }


		public string PhoneNumber { get; set; }

		public IEnumerable<string> Roles { get; set; }

		public UserViewModel() 
		{
			Id = Guid.NewGuid().ToString();
		}
	}
}
