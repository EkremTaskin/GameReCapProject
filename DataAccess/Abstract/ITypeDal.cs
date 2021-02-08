using System;
using Entity.Concrete;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;

namespace DataAccess.Abstract
{
	public interface ITypeDal : IEntityRepository<Entity.Concrete.Type>
	{
	}
}
