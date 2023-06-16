namespace Loupedeck.WindowsDisplaySettingsPlugin.Actions
{
    using System;
    using System.Collections.Generic;
    using WindowsDisplayAPI.DisplayConfig;
    using WindowsDisplayAPI.Native.DisplayConfig;

    public class ProjectCommand: PluginDynamicCommand
    {
        private readonly Dictionary<String, DisplayConfigTopologyId> projectOptions = new Dictionary<String, DisplayConfigTopologyId>()
        {
            { "PC only", DisplayConfigTopologyId.Internal },
            { "TV only", DisplayConfigTopologyId.External },
            { "Duplicate", DisplayConfigTopologyId.Clone },
            { "Extend", DisplayConfigTopologyId.Extend }
        };

        //private DisplayConfigTopologyId currentState;

        public ProjectCommand(): base() 
        {
            //this.currentState = PathInfo.GetCurrentTopology();
            foreach (var i in this.projectOptions)
            {
                this.AddParameter(i.Key, i.Key, "Display");
            }
        }

        protected override void RunCommand(String actionParameter)
        {
            var topology = this.projectOptions[actionParameter];

            try
            {
                PathInfo.ApplyTopology(topology, true);
            }
            catch (Exception e)
            {
                throw;
            }
            //finally 
            //{
            //    this.currentState = PathInfo.GetCurrentTopology();
            //}
                
            
        }
    }
}
