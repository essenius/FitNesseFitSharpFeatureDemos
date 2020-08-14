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

using System;

namespace Add
{
    public sealed class Program
    {
        public static int Main(string[] args)
        {
            if (args != null && args.Length >= 2 && long.TryParse(args[0], out var a) && long.TryParse(args[1], out var b))
            {
                Console.WriteLine(Calc.Add(a, b));
                return 0;
            }
            Console.Error.WriteLine("Need two long integers as parameters");
            return 1;
        }
    }
}
