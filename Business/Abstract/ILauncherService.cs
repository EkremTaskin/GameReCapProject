using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
	public interface ILauncherService
	{
		List<Launcher> GetAll();
		Launcher GetById(int Id);
		void Delete(Launcher launcher);
		void Update(Launcher launcher);
		void Add(Launcher launcher);
	}
}
