
// This file has been generated by the GUI designer. Do not modify.
namespace Test002Widgets
{
	public partial class OlliTextWidget
	{
		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.TextView textview1;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Test002Widgets.OlliTextWidget
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Test002Widgets.OlliTextWidget";
			// Container child Test002Widgets.OlliTextWidget.Gtk.Container+ContainerChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.textview1 = new global::Gtk.TextView();
			this.textview1.Buffer.Text = global::Mono.Unix.Catalog.GetString("abc");
			this.textview1.CanFocus = true;
			this.textview1.Name = "textview1";
			this.GtkScrolledWindow.Add(this.textview1);
			this.Add(this.GtkScrolledWindow);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}