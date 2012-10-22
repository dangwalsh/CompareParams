using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Autodesk.Revit.DB;

namespace CompareParams.Classes
{
    public class ClsParameter
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
            set { SetValue(value); }
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
        /// Get the value of the parameter
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
        /// <summary>
        /// Set the value of the parameter
        /// </summary>
        /// <param name="value">object</param>
        void SetValue(object value)
        {
            if (_Parameter.IsReadOnly) return;

            try
            {
                switch (_Parameter.StorageType)
                {
                    case StorageType.Double:
                        _Parameter.SetValueString(value as string);
                        break;

                    case StorageType.ElementId:
                        _Parameter.Set(value as ElementId);
                        break;

                    case StorageType.Integer:
                        _Parameter.SetValueString(value as string);
                        break;

                    case StorageType.None:
                        _Parameter.SetValueString(value as string);
                        break;

                    case StorageType.String:
                        _Parameter.Set(value as string);
                        break;

                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
