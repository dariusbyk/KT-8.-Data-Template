using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Win32;

namespace DataTemplateDemo
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<User> Users { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Users = new ObservableCollection<User>();

            Users.Add(new User
            {
                Name = "Алексей",
                Age = 22
            });

            Users.Add(new User
            {
                Name = "Мария",
                Age = 25
            });

            Users.Add(new User
            {
                Name = "Иван",
                Age = 20
            });

            DataContext = this;
        }

        private void ChoosePhoto_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            // У каждой кнопки внутри шаблона свой пользователь.
            User user = (User)button.DataContext;

            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Title = "Выберите фотографию";
            dialog.Filter =
                "Изображения (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

            if (dialog.ShowDialog() == true)
            {
                user.PhotoPath = dialog.FileName;
            }
        }
    }
}