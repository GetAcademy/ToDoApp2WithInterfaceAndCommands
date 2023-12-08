using ToDoApp;

class Program
{
    /*
     * Objektorientering
     *  - Modellere virkeligheten, ikke alle klasser er substantiv
     *  - DRY - også gjentakelser på høyere nivå
     *  - Abstrahere og generalisere
     *  - Pakke inn kompleksitet
     *
     * Klasse for kommando
     * Lage klasse Menu med kommandoer og interface
     * Arv
     */
    static void Main(string[] args)
    {
        var menu = new Menu();
        menu.Run();
    }
}
