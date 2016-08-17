using System;
using Newtonsoft.Json;
namespace RecruiterApp
{
	public class Candidate
	{

		int id { get; set; }
		string firstName { get; set; }
		string lastName { get; set; }
		string email { get; set; }
		string street { get; set; }
		string street2 { get; set; }
		string city { get; set; }
		string zip { get; set; }
		int stateId { get; set; }
		int recruiterContactId { get; set; }
		int sourceId { get; set; }
		DateTime creationTime { get; set; }
		bool hasResume { get; set; }
		string InfoNotes { get; set; }
		string recommendedBy { get; set; }
		bool hasCompletedApplication { get; set; }
		bool hasDetailsAndReferences { get; set; }
		bool hasCompletedAdp { get; set; }
		string completedApplicationComments { get; set; }
		string detailsAndReferencesComments { get; set; }
		string verbalOfferComments { get; set; }
		string formalOfferComments { get; set; }
		string clearedBackgroundComments { get; set; }
		string sogetiResumeComments { get; set; }

		[JsonProperty(PropertyName = "candidateId")]
		public int candidateId { get { return this.id; } set { this.id = value; } }

		[JsonProperty(PropertyName = "candidateFirstName")]
		public string candidateFirstName { get { return this.firstName; } set { this.firstName = value; } }

		[JsonProperty(PropertyName = "candidateLastName")]
		public string candidateLastName { get { return this.lastName; } set { this.lastName = value; } }

		[JsonProperty(PropertyName = "candidateEmail")]
		public string candidateEmail { get { return this.email; } set { this.email = value; } }

		[JsonProperty(PropertyName = "candidateStreet")]
		public string candidateStreet { get { return this.street; } set { this.street = value; } }

		[JsonProperty(PropertyName = "candidateStreet2")]
		public string candidateStreet2 { get { return this.street2; } set { this.street2 = value; } }

		[JsonProperty(PropertyName = "candidateCity")]
		public string candidateCity { get { return this.city; } set { this.city = value; } }

		[JsonProperty(PropertyName = "candidateZip")]
		public string candidateZip { get { return this.zip; } set { this.zip = value; } }

		[JsonProperty(PropertyName = "candidateStateId")]
		public int candidateStateId { get { return this.stateId; } set { this.stateId = value; } }

		[JsonProperty(PropertyName = "candidateRecruiterContactId")]
		public int candidateRecruiterContactId { get { return this.recruiterContactId; } set { this.recruiterContactId = value; } }

		[JsonProperty(PropertyName = "candidateSourceId")]
		public int candidateSourceId { get { return this.sourceId; } set { this.sourceId = value; } }

		[JsonProperty(PropertyName = "candidateCreationTime")]
		public DateTime candidateCreationTime { get { return this.creationTime; } set { this.creationTime = value; } }

		[JsonProperty(PropertyName = "candidateHasResume")]
		public bool candidateHasResume { get { return this.hasResume; } set { this.hasResume = value; } }

		[JsonProperty(PropertyName = "candidateInfoNotes")]
		public string candidateInfoNotes { get { return this.InfoNotes; } set { this.InfoNotes = value; } }

		[JsonProperty(PropertyName = "candidateRecommendedBy")]
		public string candidateRecommendedBy { get { return this.recommendedBy; } set { this.recommendedBy = value; } }

		[JsonProperty(PropertyName = "candidateHasCompletedApplication")]
		public bool candidateHasCompletedApplication { get { return this.hasCompletedApplication; } set { this.hasCompletedApplication = value; } }

		[JsonProperty(PropertyName = "candidateDetailsAndReferences")]
		public bool candidateDetailsAndReferences { get { return this.hasDetailsAndReferences; } set { this.hasDetailsAndReferences = value; } }

		[JsonProperty(PropertyName = "candidateCompletedADP")]
		public bool candidateCompletedADP { get { return this.hasCompletedAdp; } set { this.hasCompletedAdp = value; } }

		[JsonProperty(PropertyName = "candidateApplicationComments")]
		public string candidateApplicationComments { get { return this.completedApplicationComments; } set { this.completedApplicationComments = value; } }
	
		[JsonProperty(PropertyName = "candidateDetailsAndReferencesComments")]
		public string candidateDetailsAndReferencesComments { get { return this.detailsAndReferencesComments; } set { this.detailsAndReferencesComments = value; } }
	
		[JsonProperty(PropertyName = "candidateVerbalOfferComments")]
		public string candidateVerbalOfferComments { get { return this.verbalOfferComments; } set { this.verbalOfferComments = value; } }

		[JsonProperty(PropertyName = "candidateFormalOfferComments")]
		public string candidateFormalOfferComments { get { return this.formalOfferComments; } set { this.formalOfferComments = value; } }

		[JsonProperty(PropertyName = "candidateClearedBackgroundComments")]
		public string candidateClearedBackgroundComments { get { return this.clearedBackgroundComments; } set { this.clearedBackgroundComments = value; } }

		[JsonProperty(PropertyName = "candidateSogetiResumeComments")]
		public string candidateSogetiResumeComments { get { return this.sogetiResumeComments; } set { this.sogetiResumeComments = value; } }
	}
}

