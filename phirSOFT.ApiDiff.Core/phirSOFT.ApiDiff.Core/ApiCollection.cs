using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace phirSOFT.ApiDiff.Core
{
    public class ApiCollection<T> : IReadOnlyCollection<T>
    {
        private readonly ICollection<T> _collection 
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int Count { get; }

        public Api
    }
}
