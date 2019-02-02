// Copyright 2015-2019 Rik Essenius
//
//   Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file 
//   except in compliance with the License. You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software distributed under the License 
//   is distributed on an "AS IS" BASIS WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and limitations under the License.

using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;

namespace TestSlim
{
    [SuppressMessage("ReSharper", "UnusedMember.Global", Justification = "FitSharp interface spec"),
     SuppressMessage("ReSharper", "MemberCanBePrivate.Global", Justification = "FitSharp interface spec"),
     SuppressMessage("ReSharper", "CollectionNeverUpdated.Global", Justification = "FitSharp interface spec"),
     SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global", Justification = "FitSharp interface spec")]
    public class ArrayTest
    {
        public Collection<Collection<string>> ArrayOfArrays { get; set; }

        public Collection<string> Array { get; set; }

        public string ArrayField(int index) => Array[index];

        public string ArrayOfArraysField(int index1, int index2) => ArrayOfArrays[index1][index2];
    }
}