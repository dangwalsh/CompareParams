using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Autodesk.Revit.DB;

namespace CompareParams.Classes
{
    class ClsCategory
    {
        private Dictionary<string, Category> _Cat;

        public Dictionary<string, Category> Cat
        {
            get { return _Cat; }
        }

        public ClsCategory()
        {

        }
    }
}
