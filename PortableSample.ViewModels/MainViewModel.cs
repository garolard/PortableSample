using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using PortableSample.DataAccess;
using PortableSample.Entities;

namespace PortableSample.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly RepositoryFactory factory;

        public MainViewModel(ISqLiteDataContext dataContext)
        {
            factory = new RepositoryFactory(dataContext);
            Dummies = new ObservableCollection<Dummy>();
            PopulateDummies();
        }

        public string Name { get; set; }

        public ObservableCollection<Dummy> Dummies { get; set; }

        private Dummy _selected;
        public Dummy Selected
        {
            get { return _selected; }
            set { _selected = value; RaisePropertyChanged(); CreateItemCommand.RaiseCanExecuteChanged(); }
        }
        

        public RelayCommand CreateItemCommand => new RelayCommand(CreateItemCommandDelegate, new Func<bool>(() =>
        {
            return Selected == null;
        }));

        public ICommand DeleteItemCommand => new RelayCommand<Dummy>(DeleteItemCommandDelegate);
        

        private async void CreateItemCommandDelegate()
        {
            var item = new Dummy() { Name = this.Name };
            await factory.Dummy.SaveAsync(item);
            Name = string.Empty;
            RaisePropertyChanged(nameof(Name));
            Dummies.Clear();
            PopulateDummies();
        }

        private async void PopulateDummies()
        {
            var dummies = await factory.Dummy.FindAsync(d => d.Id != -1);
            foreach (var dummy in dummies)
            {
                Dummies.Add(dummy);
            }
        }

        private async void DeleteItemCommandDelegate(Dummy item)
        {
            await factory.Dummy.DeleteAsync(item);
            Dummies.Clear();
            PopulateDummies();
        }
    }
}
