﻿using Core.DataAccess.EfEntityRepository;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
	public class EfLauncherDal : EfEntityRepositoryBase<Launcher ,GameManagementContext >,ILauncherDal
	{
	}
}
