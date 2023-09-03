using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.App.LSPWellCoded
{

	public interface ITakePhoto
	{
		void TakePhoto();
	}


	public abstract class BasePhone
	{
		public void Call()
		{
			Console.WriteLine("Arama Yapıldı");
		}
	}

	public class Iphone : BasePhone, ITakePhoto
	{
		public void TakePhoto()
		{
			Console.WriteLine("Fotoğraf Çekildi");
		}
	}

	public class Nokia3310 : BasePhone
	{
	
	}
}
