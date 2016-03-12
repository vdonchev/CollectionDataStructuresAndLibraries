namespace _02.StringEditor.Interfaces
{
    using Models;

    public interface ICommand
    {
        string Execute(string @params, IStringEditor stringEditor);
    }
}