namespace TaskListApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("AddItemNewWindow", typeof(Views.AddItemNewWindow));

        }
    }
}
