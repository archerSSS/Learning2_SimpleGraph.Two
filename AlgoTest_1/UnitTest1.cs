using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using AlgorithmsDataStructures2;

namespace AlgoTest_1
{
    [TestClass]
    public class UnitTest1
    {

        /*
         *      0  0  0  1  0  0
         *      0  0  0  1  1  1
         *      0  0  0  0  0  1
         *      1  1  0  0  1  0
         *      0  1  0  1  0  0
         *      0  1  1  0  0  0
         * 
         */
        [TestMethod]
        public void TestMethod1()
        {
            int a1 = 1;
            int a2 = 2;
            int a3 = 3;
            int a4 = 4;
            int a5 = 5;
            int a6 = 6;
            int[] array = new int[4] { a1, a4, a2, a6 };

            SimpleGraph<int> graph = new SimpleGraph<int>(6);
            graph.AddVertex(1);
            graph.AddVertex(2);
            graph.AddVertex(3);
            graph.AddVertex(4);
            graph.AddVertex(5);
            graph.AddVertex(6);

            graph.AddEdge(1, 3);
            graph.AddEdge(0, 3);
            graph.AddEdge(1, 4);
            graph.AddEdge(2, 5);
            graph.AddEdge(1, 5);
            graph.AddEdge(3, 4);

            int count = 0;
            List<Vertex<int>> list = graph.DepthFirstSearch(0, 5);
            foreach (Vertex<int> ver in list)
                Assert.AreEqual(array[count++], ver.Value);

        }
    }
}
