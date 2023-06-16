namespace Loupedeck.WindowsDisplaySettingsPlugin.Actions
{
    using System;

    public class HDRCommand: PluginDynamicCommand
    {
        private HDRCommand()
        //public HDRCommand()
            : base(displayName: "Toggle HDR", description: "Toggle HDR on/off", groupName: "Display")
        {
        }

        protected override void RunCommand(String actionParameter)
        {
            //this.Plugin.ClientApplication.
        }
        // var colorInfo = new DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO();

        protected override String GetCommandDisplayName(String actionParameter, PluginImageSize imageSize) => $"HDR: {System.Windows.Forms.Screen.PrimaryScreen.DeviceName}";
    }
}
