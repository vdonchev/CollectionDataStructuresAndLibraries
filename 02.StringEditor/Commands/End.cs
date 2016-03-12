﻿namespace _02.StringEditor.Commands
{
    using System;
    using Attributes;
    using Interfaces;
    using Models;

    [Command]
    public class End : ICommand
    {
        public string Execute(string @params, IStringEditor stringEditor)
        {
            Environment.Exit(1);
            return string.Empty;
        }
    }
}