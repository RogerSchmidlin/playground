using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Input;
using Xamarin.Forms;

namespace OpenAttachments
{
	public class VideoDetailsViewModel : Video, INotifyPropertyChanged
	{
		public ICommand GenerateViewsCommand { get; set; }

		public VideoDetailsViewModel()
		{
			GenerateViewsCommand = new Command((parameter) =>
			{
				Debug.WriteLine("Paramter: {0}", (string)parameter);
				ViewCounter++;
			}, (nothing) => { return Notes.Length > 0; });
			Name = "Just a name";
			Notes = "these are important notes";
			ViewCounter = 0;
		}

		public string Notes
		{
			get { return _Notes; }
			set
			{
				if (_Notes != value)
				{
					_Notes = value;
					PropertyChanged(this, new PropertyChangedEventArgs("Notes"));
					// Perhaps the click button must be enabled/disabled when notes are empty
					((Command)this.GenerateViewsCommand).ChangeCanExecute();
				}
			}
		}
		public string Name
		{
			get { return _Name; }
			set
			{
				if (_Name != value)
				{
					_Name = value;
					PropertyChanged(this, new PropertyChangedEventArgs("Name"));
				}
			}
		}
		public int ViewCounter
		{
			get { return _ViewCounter; }
			set
			{
				if (_ViewCounter != value)
				{
					_ViewCounter = value;
					PropertyChanged(this, new PropertyChangedEventArgs("ViewCounter"));
				}
			}
		}

		public event PropertyChangedEventHandler PropertyChanged = delegate { };

		string _Name;
		int _ViewCounter;
		string _Notes;
	}
}

