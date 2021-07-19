using System;
using System.Globalization;
using Windows.Foundation.Metadata;

namespace AppUno.Model
{
    [CreateFromString(
      MethodName = "AppUno.Model.ModelConverter.CreateDocFromString")]
    public class Doc : Observable
    {
        private int id;
        private string title = "Test";
        private string expiration = DateTime.Now.ToString("dd-MMM-yyyy", DateTimeFormatInfo.InvariantInfo);

        public int Id
        {
            get => id;
            set
            {
                id = value;
                NotifyPropertyChanged();
            }
        }

        public string Title
        {
            get => title;
            set
            {
                title = value;
                NotifyPropertyChanged();
            }
        }

        public string Expiration
        {
            get => expiration;
            set
            {
                expiration = value;
                NotifyPropertyChanged();
            }
        }
    }
}
