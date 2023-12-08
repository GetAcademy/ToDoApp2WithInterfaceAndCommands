namespace ToDoApp.Commands
{
    internal class AddTaskCommand : ICommand
    {
        private TodoApp _todoApp;
        public string Name { get; } = "Legg til ny";

        public AddTaskCommand(TodoApp todoApp)
        {
            _todoApp = todoApp;
        }

        public void Run()
        {
            Console.WriteLine("skriv inn navn:");
            var name = Console.ReadLine();
            Console.WriteLine("Skriv inn når skal den være ferdig (dd/mm/yyyy):");
            DateTime dueDate;
            if (DateTime.TryParse(Console.ReadLine(), out DateTime dueDateFromUser))
            {
                dueDate = dueDateFromUser;
            }
            else
            {
                Console.WriteLine("Ugyldig datoformat. Bruker dagens dato.");
                dueDate = DateTime.Today;
            }
            _todoApp.AddTask(name, dueDate);

        }
    }
}
