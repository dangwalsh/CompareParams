using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Autodesk.Revit.DB;

namespace CompareParams.Classes
{
    class ClsCategory
    {
        private Category _Cat;
        private List<Element> _InstanceElements;

        public String CatName
        {
            get { return _Cat.Name; }
        }

        public List<Element> InstanceElements
        {
            get { return _InstanceElements; }
        }

        public ClsCategory(Category cat, Document doc)
        {
            _Cat = cat;

            FilteredElementCollector col = new FilteredElementCollector(doc);

            col.OfCategoryId(cat.Id);
            col.WhereElementIsNotElementType();

            _InstanceElements = col.ToElements().ToList();
        }
    }
}
