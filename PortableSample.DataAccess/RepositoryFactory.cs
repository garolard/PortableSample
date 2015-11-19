using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortableSample.DataAccess
{
    public class RepositoryFactory
    {
        private ISqLiteDataContext DataContext { get; set; }

        public RepositoryFactory(ISqLiteDataContext dataContext)
        {
            DataContext = dataContext;
        }

        public DummyRepository Dummy
        {
            get
            {
                var repo = new DummyRepository(DataContext);
                repo.InitializeAsync().Wait();
                return repo;
            }
        }
    }
}
