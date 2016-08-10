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

		public void switcherPhone(object sender, ToggledEventArgs e)
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
				moreInterviewerPhone.IsVisible = false;
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
				moreInterviewerFace.IsVisible = false;
			}
		}

		public void AddInterviewerTextBoxPhone(object sender, EventArgs e)
		{
			Entry anotherInterviewerPhone = new Entry();
			anotherInterviewerPhone.Placeholder = "Name of Interviewer";
			moreInterviewerPhone.Children.Add(anotherInterviewerPhone);



		}
		public void AddInterviewerTextBoxFace(object sender, EventArgs e)
		{
			Entry anotherInterviewer = new Entry();
			anotherInterviewer.Placeholder = "Name of Interviewer";
			moreInterviewerFace.Children.Add(anotherInterviewer);

		}

		public async void SendADPForm(object sender, EventArgs e)
		{
			var answer = await DisplayAlert("Alert", "Are you sure you want to send Cristian Pintado the ADP Form?", "Yes", "No");
		}
	}
}

