using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalorian.Entity
{
    public class ClE_User : IEnumerable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
