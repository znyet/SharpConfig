using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using SharpConfig;

namespace Test
{
    [TestFixture]
    public class MyTest
    {
        [Test]
        public void ReadConfig()
        {
            string file = System.AppDomain.CurrentDomain.BaseDirectory + "\\Config.ini";
            var config = Configuration.LoadFromFile(file);
            var section = config["config"];
            string name = section["name"].StringValue;
            int sex = section["sex"].IntValue;
            Assert.Pass(name + sex);
        }


        [Test]
        public void WriteConfig()
        {
            string file = System.AppDomain.CurrentDomain.BaseDirectory + "\\Config2.ini";
            var config = new Configuration();
            var section = config["config"];
            section["name"].SetValue("李四");
            config.SaveToFile(file);
            Assert.Pass("ok");

        }
    }
}
