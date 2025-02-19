﻿// Copyright 2015-2024 Rik Essenius
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License. You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is
// distributed on an "AS IS" BASIS WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and limitations under the License.

using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestSlim;

namespace TestSlimTest;

[TestClass]
public class ParameterTypesTest
{
    [TestMethod]
    public void ParameterTypesNegateTest()
    {
        Assert.AreEqual(false, ParameterTypes.NegateObject(true));
        Assert.AreEqual("not ok", ParameterTypes.NegateObject("ok"));
        Assert.AreEqual(-1L, ParameterTypes.NegateObject(1));
        Assert.AreEqual("anything but null", ParameterTypes.NegateObject(null));
    }
}