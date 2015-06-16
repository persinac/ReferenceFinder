using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Data;

namespace ReferenceFinder
{
    public class XMLUtility
    {
        List<String> listOfSPs = new List<String>();

        public void ParseXMLFile(Stream myStream)
        {
            XmlReader r = XmlReader.Create(myStream);
            bool prevElementWasName = false;
            while (r.Read())
            {
                if (r.NodeType == XmlNodeType.Element)
                {
                    if (r.Name.Equals("name"))
                    {
                        Console.WriteLine();
                        Console.WriteLine("<" + r.Name + ">");
                        prevElementWasName = true;
                    }
                    else { prevElementWasName = false; }
                }
                else if (r.NodeType == XmlNodeType.Text && prevElementWasName == true)
                {
                    Console.WriteLine("\tVALUE: " + r.Value);
                    listOfSPs.Add(r.Value);
                }
            }
        }

        public List<String> GetListOfSPs(DataTable SPsToExclude = null)
        {
            if (SPsToExclude != null)
            {
                for (int i = 0; i < listOfSPs.Count; i++)
                {
                    int toRemove = RemoveExcludedSPs(listOfSPs[i].ToString(), SPsToExclude);
                    if (toRemove > -1)
                    {
                        listOfSPs.RemoveAt(i);
                    }
                }
            }
            return listOfSPs;
        }

        private int RemoveExcludedSPs(String SPToCheck, DataTable SPsToExclude)
        {
            int index = -1;
            for (int j = 0; j < SPsToExclude.Rows.Count; j++ )
            {
                if (SPsToExclude.Rows[j][0].Equals(SPToCheck))
                {
                    index = j;
                    break;
                }
            }
            return index;
        }
    }

    public class StringValue
    {
        public StringValue(string s)
        {
            _value = s;
        }
        public string Value { get { return _value; } set { _value = value; } }
        string _value;
    }
}
