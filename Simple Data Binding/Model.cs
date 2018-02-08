using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Simple_Data_Binding
{
    class Model : INotifyPropertyChanged

    {
        // These are the properties as represented in the class
        // Holds the actual value
        private string topTextboxText_;
        private string bottomTextboxText_;
        private Brush topBoxBrush_;
        private Brush bottomBoxBrush_;

        // These are the public property accessors
        // Use everywhere else
        // Really just a set/getter for properties
        public string TopTextboxText
        {
            get { return topTextboxText_; }
            set
            {
                topTextboxText_ = value;
                try
                {
                    if (topTextboxText_.ToLower().Contains("red"))
                    {
                        TopBoxBrush = Brushes.Red;
                    }
                    else if (topTextboxText_.ToLower().Contains("blue"))
                    {
                        TopBoxBrush = Brushes.Blue;
                    }
                    else if (topTextboxText_.ToLower().Contains("green"))
                    {
                        TopBoxBrush = Brushes.Green;
                    }
                    else
                    {
                        TopBoxBrush = Brushes.White;
                    }
                }
                catch
                {

                }

                OnPropertyChanged("textbox1");

                
            }
        }
        public string BottomTextboxText
        {
            get
            {
                return bottomTextboxText_;
            }

            set
            {
                bottomTextboxText_ = value;
                try
                {
                    if (bottomTextboxText_.ToLower().Contains("red"))
                    {
                        BottomBoxBrush = Brushes.Red;
                    }
                    else if (bottomTextboxText_.ToLower().Contains("blue"))
                    {
                        BottomBoxBrush = Brushes.Blue;
                    }
                    else if (bottomTextboxText_.ToLower().Contains("green"))
                    {
                        BottomBoxBrush = Brushes.Green;
                    }
                    else
                    {
                        BottomBoxBrush = Brushes.White;
                    }
                }
                catch
                {

                }

                OnPropertyChanged("textbox1");
            }
        }

        public Brush TopBoxBrush
        {
            get { return topBoxBrush_; }
            set
            {
                topBoxBrush_ = value;
                OnPropertyChanged("TopBoxBrush");
            }
        }
        public Brush BottomBoxBrush
        {
            get { return bottomBoxBrush_; }
            set
            {
                bottomBoxBrush_ = value;
                OnPropertyChanged("BottomBoxBrush");

            }
        }

        public Model()
        {
            TopTextboxText = "Welcome";
            BottomTextboxText = "Hi There";
        }


#region Data Binding Stuff
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
#endregion
    }
}
