using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DojoExercices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DojoTests
{
    [TestClass]
    public class MirrorTests
    {
        Mirror mirror;

        [TestInitialize]
        public void Initialize()
        {
            mirror = new Mirror();
        }

        [TestMethod]
        public void MirrorLengthShouldReturn0From1()
        {
            Assert.AreEqual(mirror.MirrorLength(new int[1]{1}),0);
        }

        [TestMethod]
        public void MirrorLengthShouldReturn0From1234()
        {
            Assert.AreEqual(mirror.MirrorLength(new int[4]{1,2,3,4}),0);
        }

        [TestMethod]
        public void MirrorLengthShouldReturn3From12389321()
        {
            Assert.AreEqual(mirror.MirrorLength(new int[8] {1,2,3,8,9,3,2,1}), 3);
        }

        [TestMethod]
        public void MirrorLengthShouldReturn3From7219127()
        {
            Assert.AreEqual(mirror.MirrorLength(new int[7] { 7, 2, 1, 9, 1, 2, 7 }), 3);
        }

        [TestMethod]
        public void MaxMirrorLengthShouldBe3For21341233210012()
        {
            Assert.AreEqual(mirror.MirrorLength(new int[14] {2,1,3,4,1,2,3,3,2,1,0,0,1,2}), 3);
        }

        [TestMethod]
        public void MaxMirrorLengthShouldBe4For21340233214312()
        {
            Assert.AreEqual(mirror.MirrorLength(new int[14] { 2, 1, 3, 4, 0, 2, 3, 3, 2, 1, 4, 3, 1, 2 }), 4);
        }
    }
}
