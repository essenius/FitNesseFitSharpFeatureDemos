// Copyright 2015-2019 Rik Essenius
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License. You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is
// distributed on an "AS IS" BASIS WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and limitations under the License.

using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;

namespace TestSlim
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public class TestQuery
    {
        private readonly int _max;

        public TestQuery(int maxNumber) => _max = maxNumber;

        public Collection<object> Query()
        {
            var rowList = new Collection<object>();
            for (var i = 1; i <= _max; i++)
            {
                rowList.Add(new Collection<object> {new Collection<object> {"n", i}, new Collection<object> {"2n", 2 * i}});
            }
            return rowList;
        }
    }
}