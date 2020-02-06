using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AnimalSimulatorApp.Human
{
    public class People : IEnumerable<Person>
    {
        private List<Person> PersonList { get; set; }

        public IEnumerator<Person> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
