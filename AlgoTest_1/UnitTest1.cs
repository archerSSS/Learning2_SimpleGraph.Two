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

        // -- Поиск первого попавшегося пути от одной точки к другой.
        // -- Для примера взят граф 10х10.
        //
        [TestMethod]
        public void TestGraphSearch_2()
        {
            int a1 = 1;
            int a4 = 4;
            int a7 = 7;
            int a9 = 9;
            int[] array = new int[] { a4, a1, a7, a9 };

            SimpleGraph<int> graph = GetSimpleGraph();

            int count = 0;
            List<Vertex<int>> list = graph.DepthFirstSearch(3, 8);
            foreach (Vertex<int> ver in list)
                Assert.AreEqual(array[count++], ver.Value);
        }

        // -- Измененный вариант предыдущего теста.
        // -- Поиск пути с теми же аргументами, удалено ребро между вершинами (0, 6)
        //
        [TestMethod]
        public void TestGraphSearch_3()
        {
            int a2 = 2;
            int a3 = 3;
            int a4 = 4;
            int a6 = 6;
            int a9 = 9;
            int[] array = new int[] { a4, a2, a6, a3, a9 };

            SimpleGraph<int> graph = GetSimpleGraph();
            graph.RemoveEdge(0, 6);

            int count = 0;
            List<Vertex<int>> list = graph.DepthFirstSearch(3, 8);
            foreach (Vertex<int> ver in list)
                Assert.AreEqual(array[count++], ver.Value);
        }
        
        // Урезанное количество рёбер.
        //
        [TestMethod]
        public void TestGraphSearch_4()
        {
            int a2 = 2;
            int a4 = 4;
            int[] array = new int[] { 0, a4, a2, a4, 0 };

            SimpleGraph<int> graph = GetSimpleGraph();
            graph.RemoveEdge(0, 6);
            graph.RemoveEdge(1, 5);
            graph.RemoveEdge(2, 5);
            graph.RemoveEdge(5, 9);
            graph.RemoveEdge(6, 8);

            int count = 0;
            List<Vertex<int>> list = graph.DepthFirstSearch(3, 8);
            Assert.AreEqual(0, list.Count);
            foreach (Vertex<int> ver in list)
                Assert.AreEqual(array[count++], ver.Value);
        }

        // Поиск некоторого пути.
        //
        [TestMethod]
        public void TestGraphSearch_5()
        {
            int[] array = new int[] { 8, 2, 4, 1, 7, 9, 3, 6 };

            SimpleGraph<int> graph = GetSimpleGraph();

            int count = 0;
            List<Vertex<int>> list = graph.DepthFirstSearch(7, 5);
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
         *      0   0   1   0   0   0   1   0   0   1
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
