using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
	public class Game : IEntity
	{
		public int Id { get; set; }

		public int TypeId { get; set; }

		public int LauncherId { get; set; }

		public decimal Price { get; set; }

		public string Description { get; set; }
	}
}
