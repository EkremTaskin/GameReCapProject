using System;
using Entity.Concrete;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
	public interface ITypeService
	{
		List<Entity.Concrete.Type> GetAll();
		Entity.Concrete.Type GetById(int Id);
		void Delete(Entity.Concrete.Type type);
		void Update(Entity.Concrete.Type type);
		void Add(Entity.Concrete.Type type);
	}
}
