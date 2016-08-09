using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace RecruiterApp
{
	public partial class CandidateDetailsPage : ContentPage
	{
		public CandidateDetailsPage()
		{
			InitializeComponent();
		}

		public void switcher_Toggled(object sender, ToggledEventArgs e)
		{
			if (e.Value == true)
			{
				//DisplayAlert("Alert", "You have selected" + e.Value, "OK");
				interviewerNamePhone.IsVisible = true;
				AddInterviewer.IsVisible = true;
				//Face2FaceComments.IsVisible = true;
			}
			else {
				interviewerNamePhone.IsVisible = false;
				AddInterviewer.IsVisible = false;
				interviewerNamePhone2.IsVisible = false;
			}
		}

		public void switcherFace2Face(object sender, ToggledEventArgs e)
		{
			if (e.Value == true)
			{
				//DisplayAlert("Alert", "You have selected" + e.Value, "OK");
				interviewerNameFace.IsVisible = true;
				AddInterviewerFace2Face.IsVisible = true;
				//Face2FaceComments.IsVisible = true;
			}
			else {
				interviewerNameFace.IsVisible = false;
				AddInterviewerFace2Face.IsVisible = false;
				interviewerNameFace2.IsVisible = false;
			}
		}

		public void AddInterviewerTextBoxPhone(object sender, EventArgs e)
		{

			interviewerNamePhone2.IsVisible = true;


		}
		public void AddInterviewerTextBoxFace(object sender, EventArgs e)
		{
			interviewerNameFace2.IsVisible = true;
		}

		public void SendADPForm(object sender, EventArgs e)
		{
			DisplayAlert("Alert", "Are you sure you want to send Cristian Pintado the ADP Form?", "Yes", "No");
		}
	}
}

