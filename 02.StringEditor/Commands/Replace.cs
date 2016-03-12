namespace _02.StringEditor.Commands
{
    using System;
    using System.Linq;
    using Attributes;
    using Interfaces;
    using Models;
    using Utils;

    [Command]
    public class Replace : ICommand
    {
        public string Execute(string @params, IStringEditor stringEditor)
        {
            var splitted = @params.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var result = stringEditor.Replace(int.Parse(splitted[0]), int.Parse(splitted[1]), splitted[2])
                ? Constants.CommandSuccess
                : Constants.CommandFailure;

            return result;
        }
    }
}