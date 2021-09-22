using Dalamud.Plugin;
using System;

namespace MinimalPluginTemplate
{
    public class Plugin : IDalamudPlugin
    {
        public string Name => "Name of the plugin";

        public Plugin(DalamudPluginInterface pluginInterface)
        {
            pluginInterface.Create<Svc>();
        }

        public void Dispose()
        {
            
        }
    }
}
