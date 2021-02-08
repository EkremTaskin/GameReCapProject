using Business.Abstract;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
	public class TypeManager : ITypeService
	{
		private ITypeDal _typeDal;

		public TypeManager(ITypeDal typeDal)
		{
			_typeDal = typeDal;
		}

		public void Add(Entity.Concrete.Type type)
		{
			_typeDal.Add(type);
		}

		public void Delete(Entity.Concrete.Type type)
		{
			_typeDal.Delete(type);
		}

		public List<Entity.Concrete.Type> GetAll()
		{
			return _typeDal.GetAll();
		}

		public Entity.Concrete.Type GetById(int Id)
		{
			return _typeDal.GetById(p => p.Id == Id);
		}

		public void Update(Entity.Concrete.Type type)
		{
			_typeDal.Update(type);
		}
	}
}
