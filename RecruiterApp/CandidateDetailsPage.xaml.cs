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

		public void switcherFace2Face(object sender, ToggledEventArgs e)
		{
			if (e.Value == true)
			{
				interviewerNameFace.IsVisible = true;
				AddInterviewerFace2Face.IsVisible = true;
				moreInterviewerFace.IsVisible = true;
				SavePhoneButton.IsVisible = true;
			}
			else {
				interviewerNameFace.IsVisible = false;
				AddInterviewerFace2Face.IsVisible = false;
				moreInterviewerFace.IsVisible = false;
				DeleteInterviewerFace.IsVisible = false;
				SavePhoneButton.IsVisible = false;

			}
		}

		public void DeleteInterviewerTextBoxFace(object sender, EventArgs e)
		{
			var countInterviewers = moreInterviewerFace.Children.Count;

			if (countInterviewers > 0)
			{
				moreInterviewerFace.Children.RemoveAt(moreInterviewerFace.Children.Count - 1);

				if (countInterviewers == 1)
				{
					DeleteInterviewerFace.IsVisible = false;

				}
			}
		}


		public void Face2FaceChange(object sender, TextChangedEventArgs e)
		{
			var value = sender as Editor;
			if (value.Text.Equals(""))
			{
				SavePhoneButton.IsVisible = false;
			}
			else
			{
				SavePhoneButton.IsVisible = true;
			}
		}

		public void AddInterviewerTextBoxFace(object sender, EventArgs e)
		{
			Entry anotherInterviewer = new Entry();
			anotherInterviewer.Placeholder = "Name of Interviewer";
			moreInterviewerFace.Children.Add(anotherInterviewer);

			var countTextBoxes = moreInterviewerFace.Children.Count;

			if (countTextBoxes > 0)
			{
				DeleteInterviewerFace.IsVisible = true;
			}



		}

		// Phone Interview Portion

		public void switcherPhone(object sender, ToggledEventArgs e)
		{
			if (e.Value == true)
			{
				//DisplayAlert("Alert", "You have selected" + e.Value, "OK");
				interviewerNamePhone.IsVisible = true;
				AddInterviewer.IsVisible = true;
				moreInterviewerPhone.IsVisible = true;
				//DeleteInterviewer.IsVisible = true;
			}
			else {
				interviewerNamePhone.IsVisible = false;
				AddInterviewer.IsVisible = false;
				DeleteInterviewer.IsVisible = false;
				moreInterviewerPhone.IsVisible = false;
			}
		}

		public void AddInterviewerTextBoxPhone(object sender, EventArgs e)
		{
			Entry anotherInterviewerPhone = new Entry();
			anotherInterviewerPhone.Placeholder = "Name of Interviewer";
			moreInterviewerPhone.Children.Add(anotherInterviewerPhone);

			var countTextBoxes = moreInterviewerPhone.Children.Count;

			if (countTextBoxes > 0)
			{
				DeleteInterviewer.IsVisible = true;
			}
		}

		public void DeleteInterviewerTextBoxPhone(object sender, EventArgs e)
		{
			var countInterviewers = moreInterviewerPhone.Children.Count;

			if (countInterviewers > 0)
			{
				moreInterviewerPhone.Children.RemoveAt(moreInterviewerPhone.Children.Count - 1);

				if (countInterviewers == 1)
				{
					DeleteInterviewer.IsVisible = false;

				}

			}
		}

		public void SavePhoneInterview(object sender, EventArgs e)
		{
		}

		public async void SendADPForm(object sender, EventArgs e)
		{
			var answer = await DisplayAlert("Alert", "Are you sure you want to send Cristian Pintado the ADP Form?", "Yes", "No");

			if (answer)
			{
			}

		}
	}
}

