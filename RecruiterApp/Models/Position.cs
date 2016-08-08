using System;
using Newtonsoft.Json;
using Microsoft.WindowsAzure.MobileServices;

namespace RecruiterApp
{
	public class Position
	{
		int id;
		string name;
		string description;

		public Position()
		{
		}

		[JsonProperty(PropertyName = "positionId")]
		public int positionId { get { return this.id; } set { this.id = value; } }

		[JsonProperty(PropertyName = "positionName")]
		public string positionName { get { return this.name; } set { this.name = value; } }

		[JsonProperty(PropertyName = "positionDescription")]
		public string positionDescription { get { return this.description; } set { this.description = value; } }

	}
}

