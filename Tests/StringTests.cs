using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DojoExercices;


namespace DojoTests
{
    [TestClass]
    public class StringTests
    {
        StringExercices instance;

        [TestInitialize]
        public void initialize()
        {
            instance = new StringExercices();
        }
        
        
        [TestMethod]
        public void shouldReturnEroFromXerox()
        {
            Assert.AreEqual(instance.withoutX("xerox"),"ero");
        }

        [TestMethod]
        public void shouldReturnOxfromFox()
        {
            StringExercices instance = new StringExercices();
            Assert.AreEqual(instance.withoutX("fox"), "fo");
        }

        [TestMethod]
        public void shouldReturnPfromXP()
        {
            Assert.AreEqual(instance.withoutX("XP"), "p");
        }

        [TestMethod]
        public void shouldReturnUxaFromXuxa()
        {
            Assert.AreEqual(instance.withoutX("xuxa"), "uxa");
        }
    }
}
