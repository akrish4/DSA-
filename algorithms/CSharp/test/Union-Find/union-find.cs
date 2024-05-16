using NUnit.Framework;

namespace Algorithms.Tests.UnionFind
{
    [TestFixture]
    public class UnionFind
    {
        [SetUp]
        public void Setup()
        {
            Algorithms.UnionFind.UnionFind.n = 5;
            Algorithms.UnionFind.UnionFind.Build();
        }

        [Test]
        public void Find_ShouldGetExpectedResult()
        {
            Assert.That(Algorithms.UnionFind.UnionFind.Find(1), Is.EqualTo(1));
        }

        [Test]
        public void IsSameSet_ShouldGetExpectedResult()
        {
            Assert.IsTrue(Algorithms.UnionFind.UnionFind.IsSameSet(1, 1));
            Assert.IsFalse(Algorithms.UnionFind.UnionFind.IsSameSet(1, 2));
        }

        [Test]
        public void Union_ShouldGetExpectedResult()
        {
            Algorithms.UnionFind.UnionFind.Union(1, 2);
            Assert.IsTrue(Algorithms.UnionFind.UnionFind.IsSameSet(1, 2));
        }

        [Test]
        public void UnionAndFind_ShouldGetExpectedResult()
        {
            Algorithms.UnionFind.UnionFind.Union(1, 2);
            Algorithms.UnionFind.UnionFind.Union(2, 3);
            Assert.That(Algorithms.UnionFind.UnionFind.Find(3), Is.EqualTo(Algorithms.UnionFind.UnionFind.Find(1)));
        }
    }
}