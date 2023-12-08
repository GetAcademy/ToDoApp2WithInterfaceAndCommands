namespace ToDoApp.Commands
{
    internal interface ICommand
    {
        string Name { get; }
        void Run();
    }
}
