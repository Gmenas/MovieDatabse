﻿using System.Collections.Generic;

namespace MovieDatabase.Models
{
	public class Country
	{
		public Country()
		{
			this.Movies = new HashSet<Movie>();
		}

		public int Id { get; set; }

		public string Name { get; set; }

		public virtual ICollection<Movie> Movies { get; set; }

		public override string ToString()
		{
			return this.Name;
		}
	}
}