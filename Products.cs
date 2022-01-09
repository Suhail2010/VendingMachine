using System;
using System.Text;
using System.Collections.Generic;

public abstract class Products
{
	
	
		public abstract string Type { get; }
		public abstract double Price { get; }
		public abstract Product Product { get; }

		public virtual void information() { }
	}
}