using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
	public class LauncherManager : ILauncherService
	{
		private ILauncherDal _launcherDal;

		public LauncherManager(ILauncherDal launcherDal)
		{
			_launcherDal = launcherDal;
		}

		public void Add(Launcher launcher)
		{
			_launcherDal.Add(launcher);
		}

		public void Delete(Launcher launcher)
		{
			_launcherDal.Delete(launcher);
		}

		public List<Launcher> GetAll()
		{
			return _launcherDal.GetAll();
		}

		public Launcher GetById(int Id)
		{
			return _launcherDal.GetById(p=>p.Id == Id);
		}

		public void Update(Launcher launcher)
		{
			_launcherDal.Update(launcher);
		}
	}
}
