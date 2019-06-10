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

using System;
using System.Diagnostics.CodeAnalysis;

namespace TestSlim
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public class ParameterTypes
    {
        public static int AddTo(int input1, int input2) => input1 + input2;
        public static byte BitwiseNegate(byte input) => Convert.ToByte(input ^ 0xff);
        public static string ConcatAnd(string first, string second) => first + second;
        public static decimal DecimalAddTo(decimal input1, decimal input2) => input1 + input2;
        public static double DoubleAddTo(double input1, double input2) => input1 + input2;
        public static object Echo(object input) => input;
        public static bool HasValue(int? input) => input.HasValue;
        public static bool Negate(bool input) => !input;
        public static int Negate(int input) => -input;

        public static object NegateObject(object input)
        {
            if (input == null) return "anything but null";
            if (long.TryParse(input.ToString(), out var l)) return -l;
            if (bool.TryParse(input.ToString(), out var b)) return !b;
            return "not " + input;
        }

        public static int? NullableInt(int? input) => input;
        public static double ReciprocalOf(double input) => 1 / input;
    }
}