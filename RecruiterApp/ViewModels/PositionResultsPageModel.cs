using System;
using System.Collections.Generic;

namespace RecruiterApp
{
	public class PositionResultsPageModel
	{
		public Position positions { get; set; }
		public List<Candidate> Candidates 
		{ 
			//Testing for monica
			get 
			{
				return new List<Candidate>()
				{
					new Candidate {candidateId= 1, candidateFirstName="Monica", candidateLastName="Kenar"},
					new Candidate {candidateId=2, candidateFirstName="Eric", candidateLastName="Ruelas"},
					new Candidate {candidateId=3, candidateFirstName="Nikita", candidateLastName="Belyaev"},
					new Candidate {candidateId=4, candidateFirstName="Cristian", candidateLastName="Pintado"}
				};
			}
		}
	}
}

