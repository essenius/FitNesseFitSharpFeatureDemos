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
using System.Globalization;

namespace TestSlim
{
    [SuppressMessage("ReSharper", "MemberCanBePrivate.Global"), SuppressMessage("ReSharper", "UnusedMember.Global"),
     SuppressMessage("ReSharper", "UnusedMember.Local")]
    public class Temperature
    {
        private const double AbsZeroInC = -273.15;
        private const double AbsZeroInF = -459.67;
        private const int Digits = 10;

        public Temperature(string input)
        {
            var scale = input?.Substring(input.Length - 1).ToUpperInvariant();
            var temperature = Convert.ToDouble(input?
                .Substring(0, input.Length - 1).Trim(), CultureInfo.InvariantCulture);
            switch (scale)
            {
                case "F":
                    Value = Math.Round((temperature - AbsZeroInF) * 5 / 9, Digits);
                    break;
                case "C":
                    Value = temperature - AbsZeroInC;
                    break;
                case "K":
                    Value = temperature;
                    break;
                default:
                    throw new FormatException("Expected a double, ending with F, C or K");
            }
        }

        public double Value { get; }
        public static Temperature Parse(string input) => new Temperature(input);
        public override string ToString() => $"Temperature: {Value} K";

        internal double ValueIn(string scale)
        {
            switch (scale?.Substring(0, 1).ToUpperInvariant())
            {
                case "F":
                    return Math.Round(Value * 9 / 5 + AbsZeroInF, Digits);
                case "C":
                    return Value + AbsZeroInC;
                case "K":
                    return Value;
                default:
                    throw new FormatException($"Unrecognized scale: {scale}");
            }
        }
    }
}