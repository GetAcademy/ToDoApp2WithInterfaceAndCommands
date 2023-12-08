namespace ToDoApp.Commands
{
    internal class MarkTaskAsDoneCommand : ICommand
    {
        private TodoApp _todoApp;
        public string Name { get; } = "Marker fullført";

        public MarkTaskAsDoneCommand(TodoApp todoApp)
        {
            _todoApp = todoApp;
        }

        public void Run()
        {
            Console.WriteLine("Hvilken oppgave vil du markere fullført? (skriv inn nr til oppgaven)");
            var taskNoStr = Console.ReadLine();
            var taskNo = Convert.ToInt32(taskNoStr);
            if (taskNo < 1 || taskNo > _todoApp.GetCount())
            {
                Console.WriteLine("Skriv inn et gyldig tall");
            }
            else
            {
                _todoApp.MarkDone(taskNo);
            }
        }
    }
}
