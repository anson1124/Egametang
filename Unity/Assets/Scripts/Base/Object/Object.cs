﻿using System.ComponentModel;

namespace Model
{
	public abstract class Object: ISupportInitialize
	{
		public long Id { get; set; }

		protected Object()
		{
			Id = IdGenerater.GenerateId();
		}

		protected Object(long id)
		{
			this.Id = id;
		}

		public virtual void BeginInit()
		{
		}

		public virtual void EndInit()
		{
		}
	}
}