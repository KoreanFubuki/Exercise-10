using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10
{
    internal class Phone
    {
        private string _Company;
        private string _Model;
        private string _ReleaseDay;
        public Phone()
        {
            _Company = "Unknown";
            _Model = "Unknown";
            _ReleaseDay = "Unknown";
        }
        public Phone(string company = "Samsung", string model = "A21")
        {
            _Company = company;
            _Model = model;
            _ReleaseDay = "Unknown";
        }
        public Phone(string company = "Iphone", string model = "13 Pro Max", string releaseday = "9 November")
        {
            _Company = company;
            _Model = model;
            _ReleaseDay = releaseday;
        }
        public void Introduce()
        {
            Console.WriteLine("It is {0} created by {1}. It was released {2}.", _Model, _Company, _ReleaseDay);
        }
    }
}
