using System;
using Xunit;
using XmlValidator;

namespace XmlValidator.Tests
{
    public class SimpleXmlValidatorTests
    {
        [Fact]
        public void TestValidXml()
        {
            Assert.Equal("Valid", SimpleXmlValidator.DetermineXml("<Design><Code>hello world</Code></Design>"));
        }

        [Fact]
        public void TestInvalidXmlExtraClosingTag()
        {
            Assert.Equal("Invalid", SimpleXmlValidator.DetermineXml("<Design><Code>hello world</Code></Design><People>"));
        }

        [Fact]
        public void TestInvalidXmlMisnested()
        {
            Assert.Equal("Invalid", SimpleXmlValidator.DetermineXml("<People><Design><Code>hello world</People></Code></Design>"));
        }

        [Fact]
        public void TestInvalidXmlAttributes()
        {
            Assert.Equal("Invalid", SimpleXmlValidator.DetermineXml("<People age=\"1\">hello world</People>"));
        }

        [Fact]
        public void TestInvalidXmlSuffix()
        {
            Assert.Equal("Invalid", SimpleXmlValidator.DetermineXml("<People>hello world</People"));
        }

        [Fact]
        public void TestInvalidNonXmlString1()
        {
            Assert.Equal("Invalid", SimpleXmlValidator.DetermineXml("1"));
        }

        [Fact]
        public void TestInvalidNonXmlStringA()
        {
            Assert.Equal("Invalid", SimpleXmlValidator.DetermineXml("<aA"));
        }

        [Fact]
        public void TestInvalidNonXmlStringHash()
        {
            Assert.Equal("Invalid", SimpleXmlValidator.DetermineXml("#"));
        }
    }
}
