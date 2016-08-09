using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace RecruiterApp
{
	public partial class InformationAboutCandidatePage : ContentPage
	{
		public InformationAboutCandidatePage()
		{
			InitializeComponent();
			PullFromDatabase();
		}

		public void switcher_Toggled(object sender, ToggledEventArgs e)
		{
			if (e.Value == true)
			{
				//DisplayAlert("Alert", "You have selected" + e.Value, "OK");
				interviewerName.IsVisible = true;
				//Face2FaceComments.IsVisible = true;
			}
		}

		public void PullFromDatabase()
		{
		}

	}
}

