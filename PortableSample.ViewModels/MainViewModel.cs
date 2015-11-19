using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortableSample.DataAccess;
using PortableSample.Entities;

namespace PortableSample.ViewModels
{
    public class MainViewModel
    {
        private readonly RepositoryFactory factory;

        public MainViewModel(ISqLiteDataContext dataContext)
        {
            factory = new RepositoryFactory(dataContext);
            Dummies = new ObservableCollection<Dummy>();
        }

        public ObservableCollection<Dummy> Dummies { get; set; }

        private async void PopulateDummies()
        {
            var dummies = await factory.Dummy.FindAsync(d => d != null);
            foreach (var dummy in dummies)
            {
                Dummies.Add(dummy);
            }
        }
    }
}
