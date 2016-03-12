namespace _02.StringEditor.Interfaces
{
    public interface IWriter
    {
        void WriteLine(string message, params object[] @params);
    }
}