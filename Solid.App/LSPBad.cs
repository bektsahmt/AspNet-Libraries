using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.App.LSPBad
{
	public abstract class BasePhone
	{
		public void Call()
		{
			Console.WriteLine("Arama Yapıldı");
		}
		public abstract void TakePhoto();
	}

	public class Iphone : BasePhone
	{
		public override void TakePhoto()
		{
			Console.WriteLine("Fotoğraf Çekildi");
		}
	}

	public class Nokia3310 : BasePhone
	{
		public override void TakePhoto()
		{
			throw new NotImplementedException();
		}
	}
}
