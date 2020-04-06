﻿using System.Threading.Tasks;

namespace Wabbajack.CLI.Verbs
{
    public abstract class AVerb
    {
        public int Execute()
        {
            if (!CLIUtils.HasValidArguments(this))
                CLIUtils.Exit("The provided arguments are not valid! Check previous messages for more information", -1);

            return Run().Result;
        }

        protected abstract Task<int> Run();

    }
}
