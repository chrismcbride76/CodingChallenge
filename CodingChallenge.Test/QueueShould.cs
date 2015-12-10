using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingChallenge.Test
{
    [TestClass]
    public class QueueShould
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ThrowWhenEmpty()
        {
            Queue<int> queue = new Queue<int>();
            queue.Dequeue();
        }


        [TestMethod]
        public void EnqueAndDeque()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            Assert.AreEqual(queue.Dequeue(), 1);
            Assert.AreEqual(queue.Dequeue(), 2);
            Assert.AreEqual(queue.Dequeue(), 3);

            queue.Enqueue(5);

            Assert.AreEqual(queue.Dequeue(), 4);
            Assert.AreEqual(queue.Dequeue(), 5);
        }
    }
}
