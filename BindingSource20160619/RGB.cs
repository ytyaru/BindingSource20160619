using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace BindingSource20160619
{
    public class RGB : INotifyPropertyChanged
    {
        private int _R;
        private int _G;
        private int _B;

        public int R { get { return _R; } set { _R = value; NotifyPropertyChanged("R"); } }
        public int G { get { return _G; } set { _G = value; NotifyPropertyChanged("G"); } }
        public int B { get { return _B; } set { _B = value; NotifyPropertyChanged("B"); } }

        public event PropertyChangedEventHandler PropertyChanged = (_, __) => { };
        private void NotifyPropertyChanged(string propertyName = "")
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
