using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Autodesk.Revit.DB;

namespace CompareParams.Classes
{
    public class ClsPair
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
        }

        public String HostValue
        {
            get { return _HostValue; }
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
    }
}
