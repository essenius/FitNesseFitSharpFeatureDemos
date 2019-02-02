﻿// Copyright 2015-2019 Rik Essenius
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
using System.Linq;

namespace TestSlim
{
    [SuppressMessage("Microsoft.Design", "CA1053:StaticHolderTypesShouldNotHaveConstructors", Justification = "FitSharp can't find static classes"),
     SuppressMessage("ReSharper", "UnusedMember.Global")]
    public class EchoFixture
    {
        public static object EchoNull => null;
        public static object Echo(object input) => input;

        public static string Concat(Collection<string>input) => input.Aggregate(string.Empty, (current, entry) => current + entry);
    }
}