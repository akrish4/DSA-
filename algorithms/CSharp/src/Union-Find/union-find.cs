using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Algorithms.UnionFind
{
    public class UnionFind
    {
        public static int MAXN = 1000001;
        private static int[] father = new int[MAXN];
        private static int[] size = new int[MAXN];
        // the stack is used to store all the node along the backtracking path
        private static int[] stack = new int[MAXN];

        public static int n;

        public static void Build()
        {
            for (int i = 0; i <= n; i++)
            {
                father[i] = i;
                size[i] = 1;
            }
        }

        public static int Find(int x)
        {
            int top = 0;
            while (father[x] != x)
            {
                stack[top++] = x;
                x = father[x];
            }
            for (int i = 0; i < top; i++)
            {
                father[stack[i]] = x;
            }
            return x;
        }

        public static bool IsSameSet(int u, int v)
        {
            return Find(u) == Find(v);
        }

        public static void Union(int u, int v)
        {
            int x = Find(u);
            int y = Find(v);
            if (x != y)
            {
                if (size[x] >= size[y])
                {
                    father[y] = x;
                    size[x] += size[y];
                }
                else
                {
                    father[x] = y;
                    size[y] += size[x];
                }
            }
        }
    }
}