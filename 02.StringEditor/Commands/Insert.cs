namespace _02.StringEditor.Commands
{
    using System;
    using System.Linq;
    using Attributes;
    using Interfaces;
    using Models;
    using Utils;

    [Command]
    public class Insert : ICommand
    {
        public string Execute(string @params, IStringEditor stringEditor)
        {
            var splitted = @params.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var result = stringEditor.Insert(int.Parse(splitted[0]), splitted[1])
                ? Constants.CommandSuccess
                : Constants.CommandFailure;

            return result;
        }
    }
}