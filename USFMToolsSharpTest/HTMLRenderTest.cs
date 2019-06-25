using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Collections.Generic;
using System.IO;
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

        public class TestCase
        {
            public dynamic expected;
            public dynamic actual;
            public bool isSingleSpaced;
            public bool hasOneColumn;
            public bool isTextJustified;
            public bool isL2RDirection;
            public string GetLicenseInfo()
            {
                // Identifies License within Directory 
                string ULB_License_Doc = "insert_ULB_License.html";
                FileInfo f = new FileInfo(ULB_License_Doc);
                string fullname = f.FullName;
                string licenseHTML = "";

                if (File.Exists(ULB_License_Doc) == true)
                {

                    using (FileStream fs = File.OpenRead(fullname))
                    {
                        byte[] b = new byte[32 * 1024];
                        UTF8Encoding temp = new UTF8Encoding(true);
                        while (fs.Read(b, 0, b.Length) > 0)
                        {
                            licenseHTML += (temp.GetString(b));
                        }
                    }
                }
                return licenseHTML;
            }
            public string GetFooterInfo()
            {
                // Format --  June 13, 2019 11:42
                string dateFormat = System.DateTime.Now.ToString("MM/dd/yyyy HH:mm");
                StringBuilder footerHTML = new StringBuilder();
                footerHTML.AppendLine("<div class=FooterSection> ");
                footerHTML.AppendLine("<table id='hrdftrtbl' border='0' cellspacing='0' cellpadding='0'>");
                footerHTML.AppendLine("<tr><td>");
                footerHTML.AppendLine("<div style='mso-element:footer' id=f1>");
                footerHTML.AppendLine("<p class=MsoFooter></p>");
                footerHTML.AppendLine(dateFormat);
                footerHTML.AppendLine("<span style=mso-tab-count:1></span>");
                footerHTML.AppendLine("  <span style='mso-field-code: PAGE '></span><span style='mso-no-proof:yes'></span></span>");
                footerHTML.AppendLine("  <span style=mso-tab-count:1></span>");
                footerHTML.AppendLine("  <img alt=\"Creative Commons License\" style=\"border-width:0\" src=\"https://i.creativecommons.org/l/by-sa/4.0/88x31.png\" />");
                footerHTML.AppendLine("</p>");
                footerHTML.AppendLine("   </div>");
                footerHTML.AppendLine("</td></tr>");
                footerHTML.AppendLine("</table>");
                footerHTML.AppendLine("</div>");
                return footerHTML.ToString();
            }
            public TestCase(string e, string a, bool isSingleSpaced, bool hasOneColumn, bool isTextJustified, bool isL2RDirection)
            {
                this.isSingleSpaced = isSingleSpaced;
                this.hasOneColumn = hasOneColumn;
                this.isTextJustified = isTextJustified;
                this.isL2RDirection = isL2RDirection;


                StringBuilder output = new StringBuilder();


                output.AppendLine(e);
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
                Assert.AreEqual(test.expected, test.actual.contains());
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

        [TestMethod]
        public void TestVerseRender()
        {
            TestCase[] tests =
            {
                new TestCase("<span class=\"verse\"><span class=\"versemarker\">200</span>Genesis</span>",render.Render(parser.ParseFromString("\\v 200 Genesis")),true,true,false,true),
                //new TestCase("<span class=\"verse\"><span class=\"versemarker\">0</span></span>",render.Render(parser.ParseFromString("\\v 0")),true,true,false,true),
                new TestCase("<span class=\"verse\"><span class=\"versemarker\">0</span>fff</span>",render.Render(parser.ParseFromString("\\v 0 fff")),true,true,false,true),
                new TestCase("<div class=\"chapter\"><span class=\"chaptermarker\">1</span><span class=\"verse\"><span class=\"versemarker\">1</span>asdfasdf</span></div>",render.Render(parser.ParseFromString("\\c 1  \\v 1 asdfasdf")),true,true,false,true)
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
            TestCase[] tests =
            {
                new TestCase("<span class=\"versemarker\">26</span>This is a footnote<span class=\"footnotecaller\">1</span>",render.Render(parser.ParseFromString("\\v 26 This is a footnote \\f + \\f*")),true,true,false,true),
                //new TestCase("<span class=\"verse\"><span class=\"versemarker\">0</span></span>",render.Render(parser.ParseFromString("\\v 0")),true,true,false,true),
                new TestCase("<span class=\"verse\"><span class=\"versemarker\">0</span>fff</span>",render.Render(parser.ParseFromString("\\v 0 fff")),true,true,false,true),
                new TestCase("<div class=\"chapter\"><span class=\"chaptermarker\">1</span><span class=\"verse\"><span class=\"versemarker\">1</span>asdfasdf</span></div>",render.Render(parser.ParseFromString("\\c 1  \\v 1 asdfasdf")),true,true,false,true)
            };
            List<TestCase> TestUSFM = new List<TestCase>(tests);

            foreach (TestCase test in TestUSFM)
            {
                Assert.AreEqual(test.expected, test.actual);
            }
        }
        [TestMethod]
        public void TestUnknownMarkerRender()
        {
            TestCase[] tests =
            {
                new TestCase("",render.Render(parser.ParseFromString("\\yy")),true,true,false,true),
                new TestCase("<div class=\"header\">1 John</div>",render.Render(parser.ParseFromString("\\h 1 John \\test")),true,true,false,true),
                new TestCase("",render.Render(parser.ParseFromString("\\123 sdfgsgdfg")),true,true,false,true)
            };
            List<TestCase> TestUSFM = new List<TestCase>(tests);

            foreach (TestCase test in TestUSFM)
            {
                Assert.AreEqual(test.expected, test.actual);
            }
        }

    }
}
