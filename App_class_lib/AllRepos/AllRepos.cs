using App_class_lib.IAllRepos;
using App_class_lib.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_class_lib.AllRepos
{
	public class AllRepos<G> : IAllRepos<G> where G : class
	{
		T1Context _context;
		DbSet<G> _dbSet;
		public AllRepos()
		{
			_context = new T1Context();
		}
		public AllRepos(DbSet<G> dbSet, T1Context context)
		{
			this._dbSet = dbSet;
			this._context = context;
		}
		public bool CreateObj(G obj)
		{
			try
			{
				_dbSet.Add(obj);
				_context.SaveChanges();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public bool DeleteObj(dynamic id)
		{
			try
			{
				var idRemove = _context.Find(id);
					_dbSet.Remove(idRemove);
					_context.SaveChanges();
					return true;
				
			}
			catch (Exception)
			{
				return false;
			}
		}

		public ICollection<G> GetAll()
		{
			return _dbSet.ToList();
		}

		public G GetByID(dynamic id)
		{
			return _dbSet.Find(id);
		}

		public bool UpdateObj(G obj)
		{
			try
			{
				_dbSet.Update(obj);
				_context.SaveChanges();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}
	}
}
