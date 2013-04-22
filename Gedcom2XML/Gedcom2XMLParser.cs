/*******************************************************
 * Author       - James E Vilmaire jvilmaire@hotmail.com
 * Date         - 4/20/2013
 * Copyright    - None, no copyright intended or transferred. You 
 *                may use this code for any legal purposes. 
 * Description  - This code was developed under a "Request
 *                for code sample" from Asynchrony (www.asynchrony.com)
 *                in an effort to determine qualification for employment.
 * Requirement  - This code sample addresses problem 3 of the PDF "The Pragmatic Programmers
 *                Best of Ruby Quiz" delivered with the request for code sample. 
 *********************************************************************/                

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Gedcom2XML
{
    /// <summary>
    /// Class to encapsulate the parsing of a gedcom format file
    /// and produc an output of the same information in XML format.
    /// </summary>
    class Gedcom2XMLParser
    {
        #region class member variables            
        private string m_xmlDocumentName;               // storage of the XML file name
        private string m_gedcomDocumentName;            // storage of the GEDCOM file name
        private string[] m_gedcomData;                  // array of lines from the GEDCOM file
        private const char m_delimiterChar = ' ';       //delimiter to split the lines into tokens
        private XmlDocument m_doc;                      //storage of the internal XML
       
        public XmlDocument ParsedDoc 
        {          
            get
            {
                if (m_doc != null)
                    return m_doc;
                else
                    return null;
            }
            set
            {
                if (value != null)
                m_doc = value;
            }
        }
        #endregion

        /// <summary>
        /// Constructor (string- the source file to parse, string- the utput file)
        /// </summary>
        /// <param name="xmlDocumentName"> </param>
        public Gedcom2XMLParser(string gedcomDocumentName, string xmlDocumentName)
        {
            m_xmlDocumentName = xmlDocumentName;
            m_gedcomDocumentName = gedcomDocumentName;
            m_doc = new XmlDocument();   
        }
        /// <summary>
        /// Function to save the internal XML structure to file.
        /// </summary>
        public bool saveDoc()
        {
            bool result = false;
            try
            {
                m_doc.Save(m_xmlDocumentName);
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
           
        }
        /// <summary>
        /// Class method to read the data from a gedcom file.
        /// </summary>
        public bool loadGedcomData()
        {
            bool result = false;
            try
            {
                m_gedcomData = System.IO.File.ReadAllLines(m_gedcomDocumentName);
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }
        /// <summary>
         /// function to process the Gedcom data into XML nodes and 
         /// place the nodes in the internal XMLDocument structure.
         /// </summary>
        public bool processGedcomDataToXML()
        {
            #region method level variables
            bool result = false;
            int level = 0;
            int currentlevel = 0;
            string Id = string.Empty;
            string tag = string.Empty;
            string content = string.Empty;
            string[] words;
            XmlNode newNode = null;
            XmlNode current = null;
            XmlNode rootNode = m_doc.CreateElement("Gedcom");
            #endregion
           
                m_doc.AppendChild(rootNode);
                foreach (string line in m_gedcomData)
                {
                    if (line != "")
                    {
                        // first were going to populate the ID TAG and CONTENT variables.
                        Id = string.Empty;
                        words = line.Split(m_delimiterChar);
                        level = int.Parse(words[0]);
                        if (level == 0)
                        {
                            if (words[1].StartsWith("@"))
                            { // these special cases are required to have an attribute
                                // in the tag like ID="@I1@
                                Id = words[1];
                                newNode = m_doc.CreateElement("Individual");
                                XmlAttribute attrib = m_doc.CreateAttribute("Id");
                                attrib.Value = Id;
                                newNode.Attributes.Append(attrib);
                            }
                            else
                            { // Some level 0 tags do not have the @**@ format
                                // process them without the attribute as a regular tag.
                                tag = words[1];
                                newNode = m_doc.CreateElement(tag);
                            }
                            currentlevel = 0;
                            rootNode.AppendChild(newNode);
                            current = newNode;
                            // we parsed at least one level 0 tag, so call it a success.
                            result = true;
                        }
                        else
                        {   // process levels 1 - N
                            tag = words[1];
                            for (int i = 2; i < words.Length; i++)
                            {
                                content += words[i];
                                content += " ";
                            }
                            newNode = m_doc.CreateElement(tag);
                            newNode.InnerText = content;
                            // tracking the level and the current node
                            // so that we can correctly place the node
                            // as a child to the appropriate parent. 
                            if (level == currentlevel)
                            {
                                current.ParentNode.AppendChild(newNode);
                                current = newNode;
                            }
                            if (level < currentlevel)
                            {
                                current = current.ParentNode;
                                current.ParentNode.AppendChild(newNode);
                            }

                            if (level > currentlevel)
                            {
                                current.AppendChild(newNode);
                                current = newNode;
                            }
                            currentlevel = level;
                            content = string.Empty;
                        }

                    }

                }
               
            return result;
         }
        public string getStatistics()
        {
            string returnStats = " ";
            string date = string.Empty;
            string time = string.Empty;
            int numIndividuals = 0;
            
            date = System.DateTime.Now.ToShortDateString();
            time = System.DateTime.Now.ToShortTimeString();

            returnStats = "\r\n G2X Converter run date: " + date ;
            returnStats += "\r\n G2X Converter run time: " + time;

            XmlNodeList nodeList;
            XmlNode root = m_doc.SelectSingleNode("//Gedcom");
            nodeList = root.SelectNodes("Individual");
            numIndividuals = nodeList.Count;
            returnStats += "\r\n G2X Converter processed " + numIndividuals + " Named Individuals";
            returnStats += "\r\n *************End Run*************** ";
            return returnStats;
        }
    }
}
