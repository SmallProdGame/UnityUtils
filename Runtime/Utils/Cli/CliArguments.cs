using System;

namespace SmallProdGame.Utils {
    public class CliArguments {
        public static string GetArgument (string name) {
            var args = Environment.GetCommandLineArgs ();
            for (var i = 0; i < args.Length; i++)
                if (args[i] == name && args.Length > i + 1)
                    return args[i + 1];
            return null;
        }
    }
}