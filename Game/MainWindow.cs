using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	public void OnButton4Clicked (object sender, EventArgs e)
	{

		Application.Init ();
		GameWindow win = new GameWindow ();
		win.Show ();
		Application.Run ();


	}

	protected void OnButton6Clicked (object sender, EventArgs e)
	{
		Application.Quit ();

	}
}
