using System;
using Newtonsoft.Json;
namespace RecruiterApp
{
	public class CandidateResult
	{

		int id { get; set;}
	    string firstName { get; set;}
		string lastName { get; set;}

		[JsonProperty(PropertyName = "candidateId")]
		public int candidateId { get { return this.id; } set { this.id = value; } }

		[JsonProperty(PropertyName = "candidateFirstName")]
		public string candidateFirstName { get { return this.firstName; } set { this.firstName = value; } }

		[JsonProperty(PropertyName = "candidateLastName")]
		public string candidateLastName { get { return this.lastName; } set { this.lastName = value; } }

	}
}

