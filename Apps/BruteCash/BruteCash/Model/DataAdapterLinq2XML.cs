using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace BruteCash.Model
{
    public class DataAdapterLinq2XML
    {
        public DataAdapterLinq2XML()
        {
            //XDocument xdoc = XDocument.Load(@".\Data\XMLFile1.xml");
            ////Run query
            //var lv1s = from lv1 in xdoc.Descendants("Address")
            //           select new
            //           {
            //               //Header = lv1.Attribute("Name").Value
            //               Header = lv1.Element("Name").Value
            //               //,
            //               //Children = lv1.Descendants("level2")
            //           };

            ////Loop through results
            ////foreach (var lv1 in lv1s)
            ////{
            ////    result.AppendLine(lv1.Header);
            ////    foreach (var lv2 in lv1.Children)
            ////        result.AppendLine("     " + lv2.Attribute("name").Value);
            ////}
        }
        
    }
}
