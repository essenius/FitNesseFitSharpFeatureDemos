// Copyright 2015-2020 Rik Essenius
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License. You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is
// distributed on an "AS IS" BASIS WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and limitations under the License.

namespace TestSlim
{
    public class MainFixture
    {
        // constructor must be public for FitSharp to instantiate the class
        public MainFixture() => SubFixture = new SubFixture();
        internal SubFixture SubFixture { get; }
    }

    public class SubFixture
    {
        // constructor can be internal as FitSharp doesn't instantiate it directly
        internal SubFixture() => SubProperty = "demo";

        internal string SubProperty { get; }
    }
}