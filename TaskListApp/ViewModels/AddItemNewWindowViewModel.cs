using System.Collections.ObjectModel;
using System.Windows.Input;
using TaskListApp.Models;

namespace TaskListApp.ViewModels
{
    [QueryProperty(nameof(Items), "pItems")]
    public class AddItemNewWindowViewModel
    {
        public ObservableCollection<TodoItem> Items { get; set; }
        public string NewTaskTitle { get; set; }
        public bool IsCompleted { get; set; }

        public ICommand AddItemCommand { get; }
        public ICommand CancelCommand { get; }

        public AddItemNewWindowViewModel()
        {
            AddItemCommand = new Command(async () =>
            {
                if (!string.IsNullOrWhiteSpace(NewTaskTitle))
                {
                    Items.Add(new TodoItem { Title = NewTaskTitle, IsCompleted = IsCompleted });
                }
                await Shell.Current.GoToAsync("..");
            });

            CancelCommand = new Command(async () =>
            {
                await Shell.Current.GoToAsync("..");
            });
        }
    }
}
