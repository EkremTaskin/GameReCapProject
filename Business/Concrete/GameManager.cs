using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
	public class GameManager : IGameService
	{
		private IGameDal _gameDal;

		public GameManager(IGameDal gameDal)
		{
			_gameDal = gameDal;
		}

		public void Add(Game game)
		{
			_gameDal.Add(game);
		}

		public void Delete(Game game)
		{
			_gameDal.Delete(game);
		}

		public List<Game> GetAll()
		{
			return _gameDal.GetAll();
		}

		public Game GetById(int Id)
		{
			return _gameDal.GetById(p => p.Id == Id);
		}

		public List<GameDetailDto> GetGameDetails()
		{
			return _gameDal.GetGameDetails();
		}

		public void Update(Game game)
		{
			_gameDal.Update(game);
		}
	}
}
