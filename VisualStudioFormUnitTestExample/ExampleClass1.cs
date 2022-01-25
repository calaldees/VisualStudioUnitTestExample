using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudioFormUnitTestExample
{
    public class ExampleClass1
    {
        private int _value;
        public int value {
            get { return _value; }
        }

        public ExampleClass1(int a) {
            this._value = a + 1;
        }

    }
}
