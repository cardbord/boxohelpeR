using System;
using Microsoft.Xna.Framework;
using MonoMod.ModInterop;

namespace Celeste.Mod.boxohelpeR {
    public class boxohelpeRModule : EverestModule {
        public static boxohelpeRModule Instance { get; private set; }

        public boxohelpeRModule() {
            Instance = this;
#if DEBUG
            // debug builds use verbose logging
            Logger.SetLogLevel(nameof(boxohelpeRModule), LogLevel.Verbose);
#else
            // release builds use info logging to reduce spam in log files
            Logger.SetLogLevel(nameof(boxohelpeRModule), LogLevel.Info);
#endif
        }

        public override void Load() {
            typeof(boxohelpeRExports).ModInterop(); // TODO: delete this line if you do not need to export any functions

            // TODO: apply any hooks that should always be active
        }

        public override void Unload() {
            // TODO: unapply any hooks applied in Load()
        }
    }
}
