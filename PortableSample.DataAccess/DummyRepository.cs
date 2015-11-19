using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortableSample.Entities;

namespace PortableSample.DataAccess
{
    public class DummyRepository : BaseSqlRepository<Dummy>
    {
        public DummyRepository(ISqLiteDataContext dataContext) 
            : base(dataContext)
        {
        }
    }
}
