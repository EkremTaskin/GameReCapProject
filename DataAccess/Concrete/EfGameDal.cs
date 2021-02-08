using Core.DataAccess.EfEntityRepository;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete
{
	public class EfGameDal : EfEntityRepositoryBase<Game, GameManagementContext>, IGameDal
	{
		public List<GameDetailDto> GetGameDetails()
		{
			using (GameManagementContext context = new GameManagementContext())
			{
				var result = from g in context.Games
							 join l in context.Launchers
							 on g.LauncherId equals l.Id
							 join t in context.Types
							 on g.TypeId equals t.Id
							 select new GameDetailDto
							 {
								 TypeName = t.Name,
								 LauncherName = l.Name,
								 GamePrice = g.Price,
								 GameDescription = g.Description
							 };

				return result.ToList();
			}
		}
	}
}
