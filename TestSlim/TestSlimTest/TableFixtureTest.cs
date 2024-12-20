// Copyright 2015-2024 Rik Essenius
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License. You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is
// distributed on an "AS IS" BASIS WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and limitations under the License.

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestSlim;

namespace TestSlimTest;

[TestClass]
public class TableFixtureTest
{
    [TestMethod]
    public void TableFixtureDoTableTest()
    {
        var table = new List<List<string>>
        {
            new() {"pass", "Passes"},
            new() {"", "no change"},
            new() {"error:test", "problem"}
        };
        var result = TableFixture.DoTable(table);
        Assert.AreEqual("", result[0][0]);
        Assert.AreEqual("pass", result[0][1]);
        Assert.AreEqual("", result[1][0]);
        Assert.AreEqual("", result[1][1]);
        Assert.AreEqual("", result[2][0]);
        Assert.AreEqual("error:test", result[2][1]);
    }
}