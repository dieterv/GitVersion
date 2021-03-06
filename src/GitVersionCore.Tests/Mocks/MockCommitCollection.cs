using System.Collections.Generic;
using System.Linq;
using GitVersion;

namespace GitVersionCore.Tests.Mocks
{
    public class MockCommitCollection : CommitCollection
    {
        private List<Commit> Commits = new List<Commit>();

        public override IEnumerator<Commit> GetEnumerator()
        {
            if (SortedBy == CommitSortStrategies.Reverse)
                return Commits.GetEnumerator();

            return Enumerable.Reverse(Commits).GetEnumerator();
        }

        public CommitSortStrategies SortedBy { get; set; }
        public void Add(Commit item)
        {
            Commits.Add(item);
        }

        public void Clear()
        {
            Commits.Clear();
        }

        public bool Contains(Commit item)
        {
            return Commits.Contains(item);
        }

        public void CopyTo(Commit[] array, int arrayIndex)
        {
            Commits.CopyTo(array, arrayIndex);
        }

        public bool Remove(Commit item)
        {
            return Commits.Remove(item);
        }

        public int Count => Commits.Count;

        public bool IsReadOnly => false;


        public override CommitCollection QueryBy(CommitFilter commitFilter)
        {
            return this;
        }
    }
}
