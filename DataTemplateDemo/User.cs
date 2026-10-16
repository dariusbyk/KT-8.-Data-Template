using System.ComponentModel;

namespace DataTemplateDemo
{
    public class User : INotifyPropertyChanged
    {
        public string Name { get; set; } = "";
        public int Age { get; set; }

        private string photoPath = "";

        public string PhotoPath
        {
            get
            {
                return photoPath;
            }
            set
            {
                photoPath = value;
                OnPropertyChanged(nameof(PhotoPath));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(
                    this,
                    new PropertyChangedEventArgs(propertyName)
                );
            }
        }
    }
}