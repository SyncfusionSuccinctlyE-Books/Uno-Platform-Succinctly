using System;
using System.Collections.ObjectModel;
using System.Globalization;

namespace AppUno.Model
{
    public class ViewModel : Observable
    {
        private Doc _selectedDoc;
        public bool IsDocSelected => SelectedDoc != null;
        public ObservableCollection<Doc> Docs { get; }

        public ViewModel()
        {
            string now = DateTime.Now.ToString("dd-MMM-yyyy", DateTimeFormatInfo.InvariantInfo);

            Docs = new ObservableCollection<Doc>{
              new Doc { Id=1, Title="ID Card", Expiration=now},
              new Doc { Id=2, Title="Passport", Expiration=now },
              new Doc { Id=3, Title="License", Expiration=now },
            };
        }

        public Doc SelectedDoc
        {
            get { return _selectedDoc; }
            set
            {
                if (_selectedDoc != value)
                {
                    _selectedDoc = value;
                    NotifyPropertyChanged();
                    NotifyPropertyChanged(nameof(IsDocSelected));
                }
            }
        }

        public void AddDoc()
        {
            int id = new Random().Next();
            var doc = new Doc { Id = id };
            Docs.Add(doc);
            SelectedDoc = doc;
        }

        public void DeleteDoc()
        {
            var doc = SelectedDoc;
            if (doc != null)
            {
                Docs.Remove(doc);
                SelectedDoc = null;
            }
        }
    }
}

