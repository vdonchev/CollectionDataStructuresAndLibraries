namespace _02.StringEditor.Commands
{
    using System;
    using System.Linq;
    using Attributes;
    using Interfaces;
    using Models;
    using Utils;

    [Command]
    public class Delete : ICommand
    {
        public string Execute(string @params, IStringEditor stringEditor)
        {
            var splitted = @params.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var result = stringEditor.Delete(splitted[0], splitted[1])
                ? Constants.CommandSuccess
                : Constants.CommandFailure;

            return result;
        }
    }
}