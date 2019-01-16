using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSC_CustomListClass
{
    public class BaseList : IEnumerable
    {
 
        public int _capacity;

        public virtual IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

 }

