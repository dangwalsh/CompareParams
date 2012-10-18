using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Autodesk.Revit.DB;

namespace CompareParams.Classes
{
    class ClsParameter
    {
        private Parameter _Parameter;

        /// <summary>
        /// Parameter reference
        /// </summary>
        public Parameter ParameterObject
        {
            get { return _Parameter; }
        }

        /// <summary>
        /// Getter for the parameter value
        /// </summary>
        public String ValueString
        {
            get { return GetValue(); }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="p">Parameter</param>
        public ClsParameter(Parameter p)
        {
            _Parameter = p;
        }

        /// <summary>
        /// Method to return parameter value
        /// </summary>
        /// <returns>String</returns>
        String GetValue()
        {
            switch (_Parameter.StorageType)
            {
                case StorageType.Double:
                    return _Parameter.AsDouble().ToString();

                case StorageType.ElementId:
                    return _Parameter.AsElementId().ToString();

                case StorageType.Integer:
                    return _Parameter.AsInteger().ToString();

                case StorageType.None:
                    return _Parameter.AsValueString();

                case StorageType.String:
                    return _Parameter.AsString();

                default:
                    return "";
            }
        }
    }
}
