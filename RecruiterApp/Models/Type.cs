using System;
using Newtonsoft.Json;
namespace RecruiterApp
{
	public class Type
	{
		int id;
		string name;

		[JsonProperty(PropertyName = "Typed")]
		public int Typed { get { return this.id; } set { this.id = value; } }

		[JsonProperty(PropertyName = "TypeName")]
		public string TypeName { get { return this.name; } set { this.name = value; } }
	}
}

