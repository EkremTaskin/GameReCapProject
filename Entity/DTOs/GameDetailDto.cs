using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.DTOs
{
	public class GameDetailDto : IDto
	{
		public string GameDescription { get; set; }

		public string TypeName { get; set; }

		public string LauncherName { get; set; }

		public decimal GamePrice { get; set; }
	}
}
