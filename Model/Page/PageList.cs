﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace LogicCanvas.Model.Page
{
    [XmlRoot("Pages"), XmlType("Pages"), Serializable]
    public class PageList : ObservableCollection<PageItem>, ICloneable
    {
        private static ObservableCollection<T> DeepCopy<T>(IEnumerable<T> list) where T : ICloneable
        {
            return new ObservableCollection<T>(list.Select(x => x.Clone()).Cast<T>());
        }

        public object Clone()
        {
            return DeepCopy(this);
        }
    }
}
