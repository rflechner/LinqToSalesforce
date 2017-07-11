using System.ComponentModel;
using System.Runtime.CompilerServices;
using LinqToSalesforce.VsPlugin2017.Annotations;

namespace LinqToSalesforce.VsPlugin2017.ViewModels
{
    public class FieldDescPresenter : INotifyPropertyChanged
    {
        private bool _selected;

        public bool Selected
        {
            get => !IsOptional || _selected;
            set
            {
                if (IsOptional)
                {
                    _selected = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool IsOptional => Field.Name != "Id";

        public Rest.FieldDesc Field { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}