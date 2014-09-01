namespace MonoDevelop.Jasmine
{
    using Gtk;

    using MonoDevelop.Components.Commands;
    using MonoDevelop.Ide;

    public class SayHelloHandler : CommandHandler
    {
        protected override void Run()
        {
            base.Run();
            var parentWindow = IdeApp.Workbench.RootWindow;
            MessageDialog dialog = new MessageDialog(parentWindow, DialogFlags.DestroyWithParent,
                                       MessageType.Info, ButtonsType.Ok,
                                       "Hello World!");
            dialog.Run();
            dialog.Destroy();
        }

        protected override void Update(CommandInfo info)
        {
            base.Update(info);
            info.Enabled = true;
        }
    }
}