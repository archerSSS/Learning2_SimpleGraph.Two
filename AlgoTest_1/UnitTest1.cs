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
        public void TestGraphSearch_1()
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

        [TestMethod]
        public void TestGraphSearch_2()
        {
            int a1 = 1;
            int a2 = 2;
            int a3 = 3;
            int a4 = 4;
            int a5 = 5;
            int a6 = 6;
            int a7 = 7;
            int a8 = 8;
            int a9 = 9;
            int a10 = 10;
            int[] array = new int[] { a4, a1, a7, a9 };

            SimpleGraph<int> graph = GetSimpleGraph();

            int count = 0;
            List<Vertex<int>> list = graph.DepthFirstSearch(3, 8);
            foreach (Vertex<int> ver in list)
                Assert.AreEqual(array[count++], ver.Value);

        }


        /*
         * 
         *      0   0   0   1   0   0   1   0   0   0
         *      
         *      0   0   0   1   1   1   0   1   0   0
         *      
         *      0   0   0   0   0   1   0   0   1   0
         *      
         *      1   1   0   0   0   0   0   0   0   0
         *      
         *      0   1   0   0   0   0   0   0   0   0
         *      
         *      0   1   1   0   0   0   0   1   0   1
         *      
         *      1   0   0   0   0   0   0   0   1   0
         *      
         *      0   1   0   0   0   1   0   0   0   0
         *      
         *      0   0   0   0   0   0   1   0   0   1
         *      
         *      0   0   1   0   0   1   0   0   1   0
         * 
         * 
         */
        private SimpleGraph<int> GetSimpleGraph()
        {
            SimpleGraph<int> graph = new SimpleGraph<int>(10);
            graph.AddVertex(1);
            graph.AddVertex(2);
            graph.AddVertex(3);
            graph.AddVertex(4);
            graph.AddVertex(5);
            graph.AddVertex(6);
            graph.AddVertex(7);
            graph.AddVertex(8);
            graph.AddVertex(9);
            graph.AddVertex(10);

            graph.AddEdge(0, 3);
            graph.AddEdge(0, 6);
            graph.AddEdge(1, 3);
            graph.AddEdge(1, 4);
            graph.AddEdge(1, 5);
            graph.AddEdge(1, 7);
            graph.AddEdge(2, 5);
            graph.AddEdge(2, 8);
            graph.AddEdge(5, 7);
            graph.AddEdge(5, 9);
            graph.AddEdge(6, 8);
            graph.AddEdge(8, 9);

            return graph;
        }
    }
}
