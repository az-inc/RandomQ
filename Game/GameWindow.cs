using System;
using Gtk;

public partial class GameWindow: Gtk.Window
{
	//this class contains most of the game code as well becuase i couldent get the public methods to work (and yes i tried)
	public GameWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
		txt.LabelProp = "Welcome to randomq click on the continue button to continue";
		o1.Label = "continue";
		o2.Label = "Nope";
		o3.Label = "Nope";
		o4.Label = "Nope";

		int plc;
		int option;
		Random mainr = new Random();
		int itm1 = mainr.Next(0, 100);
		plc = mainr.Next(1, 11);
		if (plc == 1) {
			place = " forest";
		}
		if (plc == 2) {
			place = " dungeon";
		}
		if (plc == 3) {
			place = " lair";
		}
		if (plc == 4) {
			place = " house";
		}
		if (plc == 5) {
			place = " plain";
		}
		if (plc == 6) {
			place = " battle field";
		}
		if (plc == 7) {
			place = " moantian";
		}
		if (plc == 8) {
			place = " Snow cover forest";
		}
		if (plc == 9) {
			place = " The surface a small inahbitable planetoid";
		}
		if (plc == 10) {
			place = " Back ally way of a city";
		}


		itm1 = mainr.Next(1, 11);
		if (itm1 == 1) {
			r2 = " Sword";
		}
		if (itm1 == 2) {
			r2 = " Rubber Duck";
		}
		if (itm1 == 3) {
			r2 = " Hat";
		}
		if (itm1 == 4) {
			r2 = " Phone";
		}
		if (itm1 == 5) {
			r2 = " Gun";
		}
		if (itm1 == 6) {
			r2 = " Snowman";
		}
		if (itm1 == 7) {
			r2 = " Ranbow Maker";
		}
		if (itm1 == 8) {
			r2 = " Google Glass... Oh wait nvm i dont have those";
		}
		if (itm1 == 9) {
			r2 = " Helmet";
		}
		if (itm1 == 10) {
			r2 = " Cat";
		}

		option = mainr.Next(1, 11);
		if (option == 1) {
			r2 = "Run";
		}
		if (option == 2) {
			r2 = "Jump";
		}
		if (option == 3) {
			r2 = " Hat";
		}
		if (option == 4) {
			r2 = " Phone";
		}
		if (option == 5) {
			r2 = " Gun";
		}
		if (option == 6) {
			r2 = " Snowman";
		}
		if (option == 7) {
			r2 = " Ranbow Maker";
		}
		if (option == 8) {
			r2 = " Google Glass... Oh wait nvm i dont have those";
		}
		if (option == 9) {
			r2 = " Helmet";
		}
		if (option == 10) {
			r2 = " Cat";
		}

	}


	protected void OnO1Clicked (object sender, EventArgs e)
	{
		txt.LabelProp = "I found myself in a "+ place + " with my trusty " + r2 + "";
		o1.Label = "blank";
		o2.Label = "blank";
		o3.Label = "blank";
		o4.Label = "blank";
	}
	public readonly string place = "loading";

	public readonly string r2 = "loading";





		
	}




