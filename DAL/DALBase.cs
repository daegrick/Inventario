using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALBase
    {
        public string getField<T>(T name) => nameof(name);
    }
}
