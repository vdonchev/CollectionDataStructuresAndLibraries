namespace _02.StringEditor.Commands
{
    using Attributes;
    using Interfaces;
    using Models;

    [Command]
    public class Print : ICommand
    {
        public string Execute(string @params, IStringEditor stringEditor)
        {
            var res = stringEditor.Print();

            return res;
        }
    }
}