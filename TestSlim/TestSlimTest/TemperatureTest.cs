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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestSlim;

namespace TestSlimTest
{
    [TestClass]
    public class TemperatureTest
    {
        [TestMethod]
        public void TemperatureValueTest()
        {
            Assert.AreEqual(293.15, new Temperature("20 C").Value);
            Assert.AreEqual(373.15, new Temperature("212 F").Value);
            Assert.AreEqual(100, new Temperature("100 K").Value);
        }

        [TestMethod]
        public void TemperatureToStringTest()
        {
            Assert.AreEqual("Temperature: 293.15 K", new Temperature("20 C").ToString());
        }

        [TestMethod]
        public void TemperatureValueInTest()
        {
            Assert.AreEqual(68, new Temperature("20 C").ValueIn("F"));
            Assert.AreEqual(100, new Temperature("212 F").ValueIn("C"));
            Assert.AreEqual(0, new Temperature("-273.15 C").ValueIn("K"));
        }

        [TestMethod, ExpectedException(typeof(FormatException))]
        public void TemperatureConstructorWrongScaleTest()
        {
            var _ = new Temperature("20 Q");
        }

        [TestMethod, ExpectedException(typeof(FormatException))]
        public void TemperatureConstructorNullFormatExceptionTest()
        {
            var _ = new Temperature(null);
        }

        [TestMethod, ExpectedException(typeof(FormatException))]
        public void TemperatureConstructorWrongValueTest()
        {
            var _ = new Temperature("1.q C");
        }

        [TestMethod, ExpectedException(typeof(FormatException))]
        public void TemperatureValueInFormatExceptionTest()
        {
            var _ = new Temperature("20 C").ValueIn("Q");
        }

        [TestMethod, ExpectedException(typeof(FormatException))]
        public void TemperatureValueInNullFormatExceptionTest()
        {
            var _ = new Temperature("20 C").ValueIn(null);
        }

        [TestMethod]
        public void TemperatureParseTest()
        {
            Assert.AreEqual(0, Temperature.Parse("0 K").Value);
        }

    }
}
