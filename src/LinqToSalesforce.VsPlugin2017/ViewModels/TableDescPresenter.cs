using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using LinqToSalesforce.VsPlugin2017.Annotations;

namespace LinqToSalesforce.VsPlugin2017.ViewModels
{
    public class TableDescPresenter : INotifyPropertyChanged
    {
        private bool _selected;

        public bool Selected
        {
            get => _selected;
            set
            {
                _selected = value;
                OnPropertyChanged();
            }
        }

        public TableDescPresenter(Rest.TableDesc table)
        {
            Table = table;

            var fields = table.Fields.Select(f => new FieldDescPresenter
            {
                Field = f,
                Selected = false
            }).ToList();

            Fields = new ObservableCollection<FieldDescPresenter>(fields);
        }

        public Rest.TableDesc Table { get; }
        public ObservableCollection<FieldDescPresenter> Fields { get; }

        public ICommand ToggleSelect => new RelayCommand(() =>
        {
            Selected = !Selected;
        });

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}