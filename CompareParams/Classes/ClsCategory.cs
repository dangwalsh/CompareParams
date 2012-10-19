using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Autodesk.Revit.DB;

namespace CompareParams.Classes
{
    public class ClsCategory
    {
        private Category _Cat;
        private List<Element> _InstanceElements;
        private List<Element> _TypeElements;
        private List<Element> _AllElements;
        private List<ClsParameter> _InstanceParameters = new List<ClsParameter>();

        public String CatName
        {
            get { return _Cat.Name; }
        }

        public List<Element> InstanceElements
        {
            get { return _InstanceElements; }
        }

        public List<Element> TypeElements
        {
            get { return _TypeElements; }
        }

        public List<ClsParameter> InstanceParameters
        {
            get { return _InstanceParameters; }
        }

        public ClsCategory(Category cat, Document doc)
        {
            _Cat = cat;

            FilteredElementCollector col = new FilteredElementCollector(doc);

            col.OfCategoryId(cat.Id);
            //col.WhereElementIsNotElementType();

            _InstanceElements = col.ToElements().ToList();

            //col.OfCategoryId(cat.Id);
            //col.WhereElementIsElementType();

            //_TypeElements = col.ToElements().ToList();

            //_AllElements = _InstanceElements.Concat(_TypeElements).ToList();
        }

        public void GetInstanceParameters()
        {
            foreach (Element elem in _InstanceElements)
            {
                foreach (Parameter param in elem.Parameters)
                {
                    switch (param.StorageType)
                    {
                        case StorageType.Double:
                            _InstanceParameters.Add(new ClsParameter(param));
                            break;
                        case StorageType.String:
                            _InstanceParameters.Add(new ClsParameter(param));
                            break;
                        case StorageType.Integer:
                            if (param.Definition.ParameterType != ParameterType.YesNo)
                                _InstanceParameters.Add(new ClsParameter(param));
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
