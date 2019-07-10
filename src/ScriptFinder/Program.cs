using System;

namespace ScriptFinder {
    class Program {

        static void Main(string[] args) {
            var asm = typeof(KFontend.KFrontendClass).Assembly;
            foreach (var item in asm.GetManifestResourceNames()) {
                Console.WriteLine(item);
            }
        }
    }
}
