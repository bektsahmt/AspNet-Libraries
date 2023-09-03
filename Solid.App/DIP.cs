using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.App.DIP
{
	public class ProductService
	{
		private readonly IRepository _repository;

		public ProductService(IRepository repository)
		{
			_repository = repository;
		}


		public List<String> GetAll()
		{
			return _repository.getAll();

		}
	}


	public class ProductRepositoryFromSqlServer:IRepository
	{
		public List<String> getAll()
		{
			return new List<String>() { "SqlServer Kalem 1", "SqlServer Kalem 2"};
		}
	}


	public interface IRepository
	{
		List<String> getAll();
	}
}
