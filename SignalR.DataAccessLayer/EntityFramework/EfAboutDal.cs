using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignalR.DataAccessLayer.Concrete;
using SignalR.EntityLayer.Entites;

namespace SignalR.DataAccessLayer.EntityFramework
{
	public class EfAboutDal : GenericRepository<About>, IAboutDal
	{
		public EfAboutDal(SignalRContext context) : base(context)
		{
		}
	}
}
