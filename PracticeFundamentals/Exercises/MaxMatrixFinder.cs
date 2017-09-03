using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeFundamentals.Exercises
{
    //Given MxN binary matrix find the largest subsquare matrix with all 1s.
    static class MaxMatrixFinder
    {
        public static int[][] testMatrix = new int[][]
        {
            new int[]{ 0,1,1 },
            new int[]{ 0,1,1 },
            new int[]{ 0,0,0 }
        };
       public static int[][] testMatrix1 = new int[][]
       {
            new int[]{ 1,1,1 },
            new int[]{ 1,1,1 },
            new int[]{ 0,0,0 }
       };
       public static int[][] testMatrix2 = new int[][]
        {
            new int[]{ 1,1,1 },
            new int[]{ 1,1,1 },
            new int[]{ 1,1,1 }
        };
        private static IEnumerable<IEnumerable<Tuple<int, int>>> GetMaxMatrix(int[][] inputMatrix)
        {
            var indecesOf1 = inputMatrix.SelectMany((r, ri) => r.Select((c, ci) => Tuple.Create(Tuple.Create(ri,ci), c)))
                .Where(tpl => tpl.Item2 == 1)
                .ToDictionary(k => k.Item1, k => k.Item2);
            var allMatrixes = new List<List<Tuple<int, int>>>();
            foreach (var tpl in indecesOf1)
            {
                var currentMatrix = new List<Tuple<int, int>>();
                //currentMatrix.Add(tpl.Key);
                var currentRowCounter = tpl.Key.Item1;
                while (currentRowCounter < inputMatrix.Length)
                {
                    var row = inputMatrix[currentRowCounter];
                    var currentColCounter = tpl.Key.Item2;
                    while (currentColCounter < row.Length)
                    {
                        var key = Tuple.Create(currentRowCounter, currentColCounter);
                        currentColCounter++;
                        if (indecesOf1.ContainsKey(key))
                            currentMatrix.Add(key);
                        else
                            break;
                    }
                    currentRowCounter++;
                }
                var rowIndexes = currentMatrix.Select(cm => cm.Item1);
                var colIndexes = currentMatrix.Select(cm => cm.Item2);
                if (!rowIndexes.Any() || !colIndexes.Any())
                    continue;
                var maxRowIndex = rowIndexes.Max();
                var minRowIndex = rowIndexes.Min();

                var maxColIndex = colIndexes.Max();
                var minColIndex = colIndexes.Min();
                var rowDifference = (maxRowIndex - minRowIndex);
                var colDifference = (maxColIndex - minColIndex);
                if (rowDifference != colDifference)
                {
                    if(colDifference<rowDifference)
                    {
                        var maxPossibleRowIndex = minRowIndex + colDifference;
                        currentMatrix = currentMatrix.Where(el => el.Item1 < maxPossibleRowIndex).ToList();
                    }
                    else
                    {
                        var maxPossibleColIndex = minColIndex + rowDifference;
                        currentMatrix = currentMatrix.Where(el => el.Item2 <= maxPossibleColIndex).ToList();
                    }
                }
                
                if (currentMatrix.Any())
                    allMatrixes.Add(currentMatrix);
            }
            if (!allMatrixes.Any())
                return null;
            var maxCount = allMatrixes.Max(mtx => mtx.Count());
            var winnerMatrixes = allMatrixes.Where(mtx => mtx.Count == maxCount);
            return winnerMatrixes;
        } 
        public static void PrintMaxMatrixes(int[][] inputMatrix)
        {
            var maxMatrixes = GetMaxMatrix(inputMatrix);
            if (maxMatrixes == null || !maxMatrixes.Any())
            {
                Console.Write("No results found.");
                return;
            }
            foreach (var matrix in maxMatrixes)
            {
                Console.WriteLine("---------");
                var rows = matrix.Select(r => string.Join(", ", string.Format($"[{r.Item1},{r.Item2}]")));
                Console.Write(string.Join("\n", rows));
                Console.WriteLine();
                Console.WriteLine("---------");

            }
        }
    }
}
