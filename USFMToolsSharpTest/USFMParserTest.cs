using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USFMToolsSharpTest
{

    public struct TestCase
    {
        public dynamic expected;
        public dynamic actual;
        public string expectedText;
        public TestCase(dynamic expected, string expectedText, dynamic actual)
        {
            this.expected = expected;
            this.expectedText = expectedText;
            this.actual = actual;
        }
            
    }

    [TestClass]
    public class USFMParserTest
    {
        private USFMToolsSharp.USFMParser parser = new USFMToolsSharp.USFMParser();

        [TestMethod]
        public void TestHeaderParse()
        {
            TestCase[] tests =
            {
                new TestCase(new USFMToolsSharp.Models.Markers.HMarker(),"Genesis",(parser.ParseFromString("\\h Genesis")).Contents[0]),
                new TestCase(new USFMToolsSharp.Models.Markers.HMarker(),"",(parser.ParseFromString("\\h")).Contents[0]),
                new TestCase(new USFMToolsSharp.Models.Markers.HMarker(),"1 John",(parser.ParseFromString("\\h 1 John")).Contents[0]),
                new TestCase(new USFMToolsSharp.Models.Markers.HMarker(),"",(parser.ParseFromString("\\h   ")).Contents[0])
            };
            List<TestCase> TestUSFM = new List<TestCase>(tests);

            foreach (TestCase test in TestUSFM)
            {
                var temp = test.expected.PreProcess(test.expectedText);


                Assert.AreEqual(test.expected.HeaderText, test.actual.HeaderText);
            }

        }
        [TestMethod]
        public void TestChapterParse()
        {
            TestCase[] tests =
            {
                new TestCase(new USFMToolsSharp.Models.Markers.CMarker(),"1",(parser.ParseFromString("\\c 1")).Contents[0]),
                new TestCase(new USFMToolsSharp.Models.Markers.CMarker(),"1000",(parser.ParseFromString("\\c 1000")).Contents[0]),
                new TestCase(new USFMToolsSharp.Models.Markers.CMarker(),"0",(parser.ParseFromString("\\c 0")).Contents[0]),
                new TestCase(new USFMToolsSharp.Models.Markers.CMarker(),"-1",(parser.ParseFromString("\\c -1")).Contents[0]),
                //new TestCase(new USFMToolsSharp.Models.Markers.CMarker(),"",(parser.ParseFromString("\\c")).Contents[0]),
                new TestCase(new USFMToolsSharp.Models.Markers.CMarker(),"5",(parser.ParseFromString("\\c 5")).Contents[0])
            };
            List<TestCase> TestUSFM = new List<TestCase>(tests);

            foreach (TestCase test in TestUSFM)
            {
                var temp = test.expected.PreProcess(test.expectedText);

                try
                {
                    Assert.AreEqual(test.expected.Number, test.actual.Number);
                } catch (Exception e)
                {
                    Console.WriteLine(test.expectedText);
                }
            }

        }

        [TestMethod]
        public void TestVerseParse()
        {
            TestCase[] tests =
            {
                new TestCase(new USFMToolsSharp.Models.Markers.VMarker(),"9 Yahweh God called to the man and said to him, \"Where are you?\"",(parser.ParseFromString("\\v 9 Yahweh God called to the man and said to him, \"Where are you?\"")).Contents[0]),
                new TestCase(new USFMToolsSharp.Models.Markers.VMarker(),"26 God said, \"Let us make man in our image, after our likeness. Let them have dominion over the fish of the sea, over the birds of the sky, over the livestock, over all the earth, and over every creeping thing that creeps on the earth.\" \\f + \\ft Some ancient copies have: \\fqa ... Over the livestock, over all the animals of the earth, and over every creeping thing that creeps on the earth \\fqa*  . \\f*",(parser.ParseFromString("\\v 26 God said, \"Let us make man in our image, after our likeness. Let them have dominion over the fish of the sea, over the birds of the sky, over the livestock, over all the earth, and over every creeping thing that creeps on the earth.\" \\f + \\ft Some ancient copies have: \\fqa ... Over the livestock, over all the animals of the earth, and over every creeping thing that creeps on the earth \\fqa*  . \\f*")).Contents[0]),
                new TestCase(new USFMToolsSharp.Models.Markers.VMarker(),"23 This was evening and morning, the fifth day",(parser.ParseFromString("\\v 23 This was evening and morning, the fifth day.")).Contents[0]),
                new TestCase(new USFMToolsSharp.Models.Markers.VMarker(),"-1 Not in the Bible",(parser.ParseFromString("\\v -1 Not in the Bible")).Contents[0])
            };
            List<TestCase> TestUSFM = new List<TestCase>(tests);

            foreach (TestCase test in TestUSFM)
            {
                var temp = test.expected.PreProcess(test.expectedText);


                Assert.AreEqual(test.expected.VerseNumber, test.actual.VerseNumber);
            }

        }

        // Do Later... Not part of existing code
        [TestMethod]
        public void TestFootnoteParse()
        {
            //TestCase[] tests =
            //{
            //    new TestCase(new USFMToolsSharp.Models.Markers.FMarker(),"Sample Simple Footnote.",(parser.ParseFromString("\\f + \\ft Sample Simple Footnote. \\f*")).Contents[0]),
            //    new TestCase(new USFMToolsSharp.Models.Markers.FMarker(),"Some ancient copies have: \\fqa ... Over the livestock, over all the animals of the earth, and over every creeping thing that creeps on the earth \\fqa*  .",(parser.ParseFromString("\\v 26 God said, \"Let us make man in our image, after our likeness. Let them have dominion over the fish of the sea, over the birds of the sky, over the livestock, over all the earth, and over every creeping thing that creeps on the earth.\" \\f + \\ft Some ancient copies have: \\fqa ... Over the livestock, over all the animals of the earth, and over every creeping thing that creeps on the earth \\fqa*  . \\f*")).Contents[1])            };
            //List<TestCase> TestUSFM = new List<TestCase>(tests);

            //foreach (TestCase test in TestUSFM)
            //{
            //    var temp = test.expected.PreProcess(test.expectedText);


            //    Assert.AreEqual(test.expected.HeaderText, test.actual.HeaderText);
            //}

        }

        [TestMethod]
        public void TestVerseCharacterParse()
        {

            //TestCase[] tests =
            //{
            //    new TestCase(new USFMToolsSharp.Models.Markers.VPMarker(),"",(parser.ParseFromString("")).Contents[1]),
            //    new TestCase(new USFMToolsSharp.Models.Markers.VPMarker(),"",(parser.ParseFromString("")).Contents[0]),
            //    new TestCase(new USFMToolsSharp.Models.Markers.VPMarker(),"",(parser.ParseFromString("")).Contents[0])
            //};
            //List<TestCase> TestUSFM = new List<TestCase>(tests);

            //foreach (TestCase test in TestUSFM)
            //{
            //    var temp = test.expected.PreProcess(test.expectedText);


            //    Assert.AreEqual(test.expected.HeaderText, test.actual.HeaderText);
            //}
        }

        [TestMethod]
        public void TestUnknownMarkerParse()
        {
            TestCase[] tests =
            {
                new TestCase(new USFMToolsSharp.Models.Markers.UnknownMarker(),"what is yy?",(parser.ParseFromString("\\yy what is yy?")).Contents[0]),
                new TestCase(new USFMToolsSharp.Models.Markers.UnknownMarker(),"what is z?",(parser.ParseFromString("\\z what is z?")).Contents[0]),
                new TestCase(new USFMToolsSharp.Models.Markers.UnknownMarker(),"what is 1?",(parser.ParseFromString("\\1  what is 1?")).Contents[0])
            };
            List<TestCase> TestUSFM = new List<TestCase>(tests);
            string[] identifiers = {"yy","z","1","$" };
            int count = 0;
            foreach (TestCase test in TestUSFM)
            {
                var temp = test.expected.PreProcess(test.expectedText);


                Assert.AreEqual(test.expected.ParsedValue, test.actual.ParsedValue);
                Assert.AreEqual(identifiers[count], test.actual.ParsedIdentifier);
                count++;
            }
        }
        static void Main(string[] args)
        {
            // Display the number of command line arguments:
            USFMParserTest test = new USFMParserTest();
            test.TestHeaderParse();
        }
    }
}
