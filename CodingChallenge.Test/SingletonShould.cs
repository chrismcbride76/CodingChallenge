using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingChallenge.Test
{
    [TestClass]
    public class SingletonShould
    {
        [TestMethod]
        public void HaveSingleInstance()
        {
            Singleton ref1 = Singleton.Instance;
            Singleton ref2 = Singleton.Instance;

            Assert.IsTrue(ReferenceEquals(ref1, ref2));
        }
    }
}
