using System.ComponentModel;
using System.Runtime.CompilerServices;
using LinqToSalesforce.VsPlugin2017.Annotations;

namespace LinqToSalesforce.VsPlugin2017.ViewModels
{
    public class TableDescPresenter : INotifyPropertyChanged
    {
        private bool selected;

        public bool Selected
        {
            get { return selected; }
            set
            {
                selected = value;
                OnPropertyChanged();
            }
        }

        public Rest.TableDesc Table { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}