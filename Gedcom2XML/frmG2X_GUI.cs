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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gedcom2XML
{
    /// <summary>
    /// Class to encapsulate the GUI functionality
    /// and drive the Gedcom2XMLParser class.
    /// </summary>
    public partial class frmG2X_GUI : Form
    {
        #region class variables
        Gedcom2XMLParser m_gdc2xml;
        string m_gedcomFile;
        string m_xmlFile;
        #endregion

        /// <summary>
        /// constructor
        /// </summary>
        public frmG2X_GUI()
        {
            InitializeComponent();
            m_gdc2xml = null;
        }
        /// <summary>
        /// Event Handler for the Gedcom File select button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectGedcomFile_Click(object sender, EventArgs e)
        {
            if (openFileGedcom.ShowDialog() == DialogResult.OK)
            {
                 tbSelectGedcom.Text = this.openFileGedcom.FileName;
                 tbStatus.Text = "Ready to begin, click 'Parse It'.";
            }
        }
        /// <summary>
        /// Event handler for the XML file select button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectXMLfile_Click(object sender, EventArgs e)
        {
            if (openFileGedcom.ShowDialog() == DialogResult.OK)
            {
                this.tbSelectXML.Text = this.openFileGedcom.FileName;
            }

                m_xmlFile = tbSelectXML.Text;
        }
        /// <summary>
        /// Event handler for the Clear button. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbSelectXML.Text = "DefaultOutput.xml";
            tbSelectGedcom.Text = string.Empty;
            tbStatus.Text = "Select a Gedcom file to parse.";
        }
        /// <summary>
        /// Event handler for the Close button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Event handler for the Parse It button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnParseIt_Click(object sender, EventArgs e)
        {
            m_xmlFile = tbSelectXML.Text;
            m_gedcomFile = tbSelectGedcom.Text;
            if (m_xmlFile != string.Empty && m_gedcomFile != string.Empty)
            {
                try
                {
                    bool result = true;
                    m_gdc2xml = new Gedcom2XMLParser(m_gedcomFile, m_xmlFile);
                    result = m_gdc2xml.loadGedcomData();
                    result = m_gdc2xml.processGedcomDataToXML();
                    result = m_gdc2xml.saveDoc();
                    if (result == false)
                        MessageBox.Show("Error while processsing the files! " +
                                        "Some or all of the content is probably not processed.");
                    if (result == true)
                        tbStatus.Text += m_gdc2xml.getStatistics() + "\n\r \n\r";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                if (m_gedcomFile == string.Empty)
                    MessageBox.Show("Please enter a valid GEDCOM format file to be parsed.");
                if (m_xmlFile == string.Empty)
                    MessageBox.Show("Please enter a valid XML file name to output to." +
                                    " Warning! An existing file of the same name will be overwritten!");
            }
        }
    }
}
