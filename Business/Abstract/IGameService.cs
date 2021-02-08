using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
	public interface IGameService
	{
		List<Game> GetAll();
		Game GetById(int Id); 
		void Delete(Game game);
		void Update(Game game);
		void Add(Game game);

		List<GameDetailDto> GetGameDetails();
	}
}
