﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinearDataStructures;

namespace UnitTestProject1
{
    [TestClass]
    public class QueueTests
    {
        [TestMethod]
        public void TestEnqueue()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(11);
            Assert.AreEqual(1, queue.Count);
            queue.Enqueue(12);
            Assert.AreEqual(2, queue.Count);
        }
        [TestMethod]
        public void TestDequeue()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(11);
            queue.Enqueue(12);
            int element = queue.Dequeue();
            Assert.AreEqual(1, queue.Count);
            Assert.AreEqual(11, element);
            element = queue.Dequeue();
            Assert.AreEqual(0, queue.Count);
            Assert.AreEqual(12, element);
        }
        [TestMethod]
        public void TestStringsQueue()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Szymon");
            Assert.AreEqual("Szymon", queue.Dequeue());
        }
    }
}
