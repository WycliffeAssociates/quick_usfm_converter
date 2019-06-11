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
            public TestCase(dynamic e, dynamic a)
            {
                expected = e;
                actual = a;
            }
        }

        
        [TestMethod]
        public void TestHeaderRender()
        {
            // RenderMarker(Marker input)
        }
        [TestMethod]
        public void TestChapterRender()
        {

        }
        [TestMethod]
        public void TestVerseRender()
        {

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
