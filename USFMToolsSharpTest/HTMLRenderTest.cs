using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USFMToolsSharpTest
{

    [TestClass]
    public class HTMLRenderTest
    {
        private USFMToolsSharp.USFMParser parser = new USFMToolsSharp.USFMParser();
        private USFMToolsSharp.HtmlRenderer render = new USFMToolsSharp.HtmlRenderer();

        public struct TestCase
        {
            public dynamic expected;
            public dynamic actual;
            public bool isSingleSpaced;
            public bool hasOneColumn;
            public bool isTextJustified;
            public bool isL2RDirection;
            public TestCase(dynamic e, dynamic a, bool isSingleSpaced, bool hasOneColumn, bool isTextJustified, bool isL2RDirection)
            {
                this.isSingleSpaced = isSingleSpaced;
                this.hasOneColumn = hasOneColumn;
                this.isTextJustified = isTextJustified;
                this.isL2RDirection = isL2RDirection;


                StringBuilder output = new StringBuilder();
                output.AppendLine("<html>");
                output.AppendLine("<head>");
                output.AppendLine("<link rel=\"stylesheet\" href=\"style.css\">");
                output.AppendLine("</head>");

                // HTML tags can only have one class, when render to docx
                output.AppendLine($"<body class=\"{(isSingleSpaced ? "" : "double-space")}\">");
                output.AppendLine($"<div class=\"{ (hasOneColumn ? "" : "multi-column")}\">");
                output.AppendLine($"<div class=\"{ (isTextJustified ? "justified" : "")}\"> ");
                output.AppendLine($"<div class=\"{ (isL2RDirection ? "" : "rtl-direct")}\"> ");

                output.AppendLine(e);

                output.AppendLine("</div>");
                output.AppendLine("</div>");
                output.AppendLine("</div>");
                output.AppendLine("</div>");
                output.AppendLine("</body>");
                output.AppendLine("</html>");

                actual = a.Replace("\r", "").Replace("\n","");
                expected = output.ToString();
                expected = expected.Replace("\r", "").Replace("\n", "");
            }
        }

        
        [TestMethod]
        public void TestHeaderRender()
        {
            // RenderMarker(Marker input)
            TestCase[] tests =
            {
                new TestCase("<div class=\"header\">Genesis</div>",render.Render(parser.ParseFromString("\\h Genesis")),true,true,false,true),
                new TestCase("<div class=\"header\">1 John</div>",render.Render(parser.ParseFromString("\\h 1 John")),true,true,false,true),
                new TestCase("<div class=\"header\"></div>",render.Render(parser.ParseFromString("\\h")),true,true,false,true),
                new TestCase("<div class=\"header\"></div>",render.Render(parser.ParseFromString("\\h      ")),true,true,false,true)
            };
            List<TestCase> TestUSFM = new List<TestCase>(tests);

            foreach (TestCase test in TestUSFM)
            {
                Assert.AreEqual(test.expected, test.actual);
            }
        }
        [TestMethod]
        public void TestChapterRender()
        {
            TestCase[] tests =
            {
                new TestCase("<div class=\"chapter\"><span class=\"chaptermarker\">1</span></div>",render.Render(parser.ParseFromString("\\c 1")),true,true,false,true),
                new TestCase("<div class=\"chapter\"><span class=\"chaptermarker\">1000</span></div>",render.Render(parser.ParseFromString("\\c 1000")),true,true,false,true),
                new TestCase("<div class=\"chapter\"><span class=\"chaptermarker\">-1</span></div>",render.Render(parser.ParseFromString("\\c -1")),true,true,false,true),
                new TestCase("<div class=\"chapter\"><span class=\"chaptermarker\">0</span></div>",render.Render(parser.ParseFromString("\\c 0")),true,true,false,true)
            };
            List<TestCase> TestUSFM = new List<TestCase>(tests);

            foreach (TestCase test in TestUSFM)
            {
                Assert.AreEqual(test.expected, test.actual);
            }
        }

        // Finish Later
        [TestMethod]
        public void TestVerseRender()
        {
            TestCase[] tests =
            {
                new TestCase("<div class=\"header\">Genesis</div>",render.Render(parser.ParseFromString("\\h Genesis")),true,true,false,true),
                new TestCase("<div class=\"header\">1 John</div>",render.Render(parser.ParseFromString("\\h 1 John")),true,true,false,true),
                new TestCase("<div class=\"header\"></div>",render.Render(parser.ParseFromString("\\h")),true,true,false,true),
                new TestCase("<div class=\"header\"></div>",render.Render(parser.ParseFromString("\\h      ")),true,true,false,true)
            };
            List<TestCase> TestUSFM = new List<TestCase>(tests);

            foreach (TestCase test in TestUSFM)
            {
                Assert.AreEqual(test.expected, test.actual);
            }
        }
        [TestMethod]
        public void TestFootnoteRender()
        {

        }
        [TestMethod]
        public void TestUnknownMarkerRender()
        {

        }

    }
}
