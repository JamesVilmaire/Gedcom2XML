using Gedcom2XML;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestGedcom2XML
{
    
    
    /// <summary>
    ///This is a test class for Gedcom2XMLParserTest and is intended
    ///to contain all Gedcom2XMLParserTest Unit Tests
    ///</summary>
    [TestClass()]
    public class Gedcom2XMLParserTest
    {
        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        #region class variables
        bool   result;
        string gedcomDocumentName; 
        string xmlDocumentName;
       
        #endregion

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
      // [ClassInitialize()]
      // public static void MyClassInitialize(TestContext testContext)
      //  {   
       // }
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Gedcom2XMLParser Constructor
        ///</summary>
        [TestMethod()]
        public void Gedcom2XMLParserConstructorTest()
        {
            SetupTestVariables();
            Gedcom2XMLParser target = new Gedcom2XMLParser(gedcomDocumentName, xmlDocumentName);
            Assert.IsNotNull(target);
        }

        /// <summary>
        ///A test for loadGedcomData
        ///</summary>
        [TestMethod()]
        public void loadGedcomDataTest()
        {
            SetupTestVariables();
            Gedcom2XMLParser target = new Gedcom2XMLParser(gedcomDocumentName, xmlDocumentName); 
            result = target.loadGedcomData();
            Assert.IsTrue(result);  
        }

        /// <summary>
        ///A test for processGedcomDataToXML
        ///</summary>
        [TestMethod()]
        public void processGedcomDataToXMLTest()
        {
            SetupTestVariables();
            Gedcom2XMLParser target = new Gedcom2XMLParser(gedcomDocumentName, xmlDocumentName);
            target.loadGedcomData();
            result = target.processGedcomDataToXML();
            Assert.IsTrue(result); 
        }

        /// <summary>
        ///A test for saveDoc
        ///</summary>
        [TestMethod()]
        public void saveDocTest()
        {
            SetupTestVariables();
            Gedcom2XMLParser target = new Gedcom2XMLParser(gedcomDocumentName, xmlDocumentName);
            target.loadGedcomData();
            target.processGedcomDataToXML();
            result = target.saveDoc();
            Assert.IsTrue(result); 
        }
        /// <summary>
        /// Utility function to set up the test variables and reduce redundant code.
        /// </summary>
        public void SetupTestVariables()
        {// you'll want to set up these variables to point to your test environment files 
            //TODO replace with relative path solution.
            xmlDocumentName = @"outputTestXml.xml";
            gedcomDocumentName = @"C:\Users\RipTide\Documents\Visual Studio 2010\Projects\Gedcom2XML\TestGedcom2XML\bin\Debug\Royals.gdc";
        }
     
    }
}
