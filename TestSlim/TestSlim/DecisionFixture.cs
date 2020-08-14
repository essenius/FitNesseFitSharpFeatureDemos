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
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace TestSlim
{
    public class DecisionFixture
    {
        private readonly StringBuilder _log = new StringBuilder();
        private readonly StringBuilder _table = new StringBuilder();
        private double _radius;
        private double _yCoordinate;

        public int Decimals { get; set; } = 5;

        public double X { get; private set; }

        public double Angle { get; set; }

        public double MaxAngle { get; private set; }
        public double Y() => _yCoordinate;

        public void SetR(double value) => _radius = value;

        public void Table(Collection<Collection<string>> inputTable)
        {
            _log.AppendLine("Table");
            foreach (var cell in inputTable[0])
            {
                _table.AppendLine(cell);
            }
            var index = inputTable[0].TakeWhile(header =>
                !header.Equals("Angle", StringComparison.OrdinalIgnoreCase)).Count();
            MaxAngle = inputTable.Skip(1).Select(row => Convert.ToDouble(row[index]))
                .Concat(new[] {0.0}).Max();
        }

        public void BeginTable() => _log.AppendLine("BeginTable");

        public void EndTable() => _log.AppendLine("EndTable");

        public void Execute()
        {
            _log.AppendLine($"Execute with R= {_radius} and Angle={Angle}");
            var radians = Angle / 180 * Math.PI;
            X = Math.Round(_radius * Math.Cos(radians), Decimals);
            _yCoordinate = Math.Round(_radius * Math.Sin(radians), Decimals);
        }

        public void Reset() => _log.AppendLine("Reset");
    }
}