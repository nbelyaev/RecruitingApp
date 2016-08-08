using System;
using System.Collections.Generic;

namespace RecruiterApp
{
	public class PositionPageModel
	{
		public string PositionName { get; set; }


		public List<Position> Positions
		{
			get{
				return new List<Position>()
				{
					new Position() { positionId = 1, positionName = ".NET Developer" },
					new Position() { positionId = 2, positionName = "Mobile App Developer" },
					new Position() { positionId = 3, positionName = "Associate Consultant" }
				};
			}
		}
	}
}

