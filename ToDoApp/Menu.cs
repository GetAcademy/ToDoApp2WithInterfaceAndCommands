using ToDoApp.Commands;

namespace ToDoApp
{
    internal class Menu
    {
        private readonly ICommand[] _commands;
        private readonly TodoApp _todoApp;

        public Menu()
        {
            _todoApp = new TodoApp();
            _commands = new ICommand[]
            {
                new AddTaskCommand(_todoApp),
                new MarkTaskAsDoneCommand(_todoApp),
            };
        }

        public void Run()
        {
            while (true)
            {
                Console.Clear();
                _todoApp.Show();
                var cmdNo = GetCmd();
                var index = cmdNo - 1;
                var command = _commands[index];
                command.Run();
            }
        }

        private int GetCmd()
        {
            Console.WriteLine("Hva vil du gjøre? ");

            for (var index = 0; index < _commands.Length; index++)
            {
                var command = _commands[index];
                var commandNo = index + 1;
                Console.WriteLine(commandNo + ": " + command.Name);
            }
            var cmdNo = Console.ReadLine();
            return Convert.ToInt32(cmdNo);
        }
    }
}
