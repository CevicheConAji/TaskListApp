using System.Collections.ObjectModel;
using System.Windows.Input;
using TaskListApp.Models;
using TaskListApp.Views;

namespace TaskListApp.ViewModels
{
    public class MainPageViewModel
    {
        public ObservableCollection<TodoItem> Items { get; set; }
        public ICommand AddItemCommandNewWindow { get; }
        public ICommand DeleteItemCommand { get; }

        public MainPageViewModel()
        {
            Items = new ObservableCollection<TodoItem>
            {
                new TodoItem { Title = "Aprender .NET MAUI", IsCompleted = false },
                new TodoItem { Title = "Diseñar una aplicación con .NET MAUI", IsCompleted = true }
            };

            AddItemCommandNewWindow = new Command(async () =>
            {
                var navigationParameter = new Dictionary<string, object>
    {
        { "pItems", Items }
    };
                await Shell.Current.GoToAsync("AddItemNewWindow", navigationParameter);
            });
            ;
            DeleteItemCommand = new Command<TodoItem>((item) =>
            {
                if (item != null)
                {
                    Items.Remove(item);
                }
            });



        }
    }
}
