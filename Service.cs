using System;
using example.soapcore_test;

namespace soapcore_test {
    public class Service : soapcoretest {
        public bool NewOperation(string id, SampleData data) {
            return true;
        }
    }
}