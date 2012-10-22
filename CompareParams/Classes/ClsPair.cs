using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

using Autodesk.Revit.DB;

namespace CompareParams.Classes
{
    public class ClsPair : INotifyPropertyChanged
    {
        private String _InstanceName;
        private String _HostName;
        private String _InstanceValue;
        private String _HostValue;
        private bool _IsEqual;

        public String InstanceName
        {
            get { return _InstanceName; }
        }

        public String HostName
        {
            get { return _HostName; }
        }

        public String InstanceValue
        {
            get { return _InstanceValue; }
            set
            {
                _InstanceValue = value;
                this.NotifyPropertyChanged("InstanceValue");
            }
        }

        public String HostValue
        {
            get { return _HostValue; }
            set
            {
                _InstanceValue = value;
                this.NotifyPropertyChanged("HostValue");
            }
        }

        public bool IsEqual
        {
            get { return _IsEqual; }
        }

        public ClsPair(String inst, String host, String instVal, String hostVal)
        {
            _InstanceName = inst;
            _HostName = host;
            _InstanceValue = instVal;
            _HostValue = hostVal;

            if (instVal == hostVal) _IsEqual = true;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
