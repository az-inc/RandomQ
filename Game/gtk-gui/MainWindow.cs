
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;
	private global::Gtk.Image image2;
	private global::Gtk.Button button6;
	private global::Gtk.Button button5;
	private global::Gtk.Button button4;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("RandomQ\n");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed ();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.image2 = new global::Gtk.Image ();
		this.image2.Name = "image2";
		this.image2.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("Game.TitleV2.png");
		this.fixed1.Add (this.image2);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.image2]));
		w1.X = 14;
		w1.Y = 12;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.button6 = new global::Gtk.Button ();
		this.button6.CanFocus = true;
		this.button6.Name = "button6";
		this.button6.UseUnderline = true;
		this.button6.Label = global::Mono.Unix.Catalog.GetString ("RAGE QUIT");
		this.fixed1.Add (this.button6);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.button6]));
		w2.X = 487;
		w2.Y = 16;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.button5 = new global::Gtk.Button ();
		this.button5.CanFocus = true;
		this.button5.Name = "button5";
		this.button5.UseUnderline = true;
		this.button5.Label = global::Mono.Unix.Catalog.GetString ("Credits");
		this.fixed1.Add (this.button5);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.button5]));
		w3.X = 425;
		w3.Y = 16;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.button4 = new global::Gtk.Button ();
		this.button4.CanFocus = true;
		this.button4.Name = "button4";
		this.button4.UseUnderline = true;
		this.button4.Label = global::Mono.Unix.Catalog.GetString ("Start");
		this.fixed1.Add (this.button4);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.button4]));
		w4.X = 307;
		w4.Y = 15;
		this.Add (this.fixed1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 561;
		this.DefaultHeight = 191;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.button6.Clicked += new global::System.EventHandler (this.OnButton6Clicked);
		this.button4.Clicked += new global::System.EventHandler (this.OnButton4Clicked);
	}
}
