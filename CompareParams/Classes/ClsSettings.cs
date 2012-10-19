using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace CompareParams.Classes
{
    public class ClsSettings
    {
        private ExternalCommandData _CommandData;
        private ElementSet _ElementSet;
        private List<ClsCategory> _InstCategoryList = new List<ClsCategory>();
        private List<ClsCategory> _HostCategoryList = new List<ClsCategory>();

        public Document Doc
        {
            get { return _CommandData.Application.ActiveUIDocument.Document; }
        }

        public List<ClsCategory> InstCategoryList
        {
            get { return _InstCategoryList; }
        }

        public List<ClsCategory> HostCategoryList
        {
            get { return _HostCategoryList; }
        }

        public ClsSettings(ExternalCommandData com, ElementSet set)
        {
            _CommandData = com;
            _ElementSet = set;

            SortedDictionary<String, ClsCategory> catDict = new SortedDictionary<string, ClsCategory>();
            foreach (Category cat in Doc.Settings.Categories)
            {
                ClsCategory c = new ClsCategory(cat, this.Doc);
                if (c.InstanceElements.Count > 0) catDict.Add(cat.Name, c);
            }

            foreach (ClsCategory cat in catDict.Values)
            {
                _InstCategoryList.Add(cat);
                _HostCategoryList.Add(cat);
            }
        }
    }
}
