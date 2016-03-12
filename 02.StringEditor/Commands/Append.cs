namespace _02.StringEditor.Commands
{
    using System;
    using Attributes;
    using Interfaces;
    using Models;
    using Utils;

    [Command]
    public class Append : ICommand
    {
        public string Execute(string @params, IStringEditor stringEditor)
        {
            var result = stringEditor.Append(@params) 
                ? Constants.CommandSuccess 
                : Constants.CommandFailure;

            return result;
        }
    }
}