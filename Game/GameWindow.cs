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
		
		switch (plc) {
			case 1:
				place = " forest";
				break;
			case 2:
				place = " dungeon";
				break;
			case 3:
				place = " lair";
				break;
			case 4:
				place = " house";
				break;
			case 5:
				place = " plain";
				break;
			case 6:
				place = " battle field";
				break;
			case 7:
				place = " moantian";
				break;
			case 8:
				place = " Snow cover forest";
				break;
			case 9:
				place = " The surface a small inahbitable planetoid";
				break;
			case = 10:
				place = " Back ally way of a city";
				break;
			default:
				place = "error parsing place";
				break;
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
			r3 = "Run";
		}
		if (option == 2) {
			r3 = "Fly";
		}
		if (option == 3) {
			r3 = "Eat Melon Rines";
		}
		if (option == 4) {
			r3 = "Attack somthing";
		}
		if (option == 5) {
			r3 = "Look for and press all buttons";
		}
		if (option == 6) {
			r3 = "Sit Down";
		}
		if (option == 7) {
			r3 = "Steal some gold coins";
		}
		if (option == 8) {
			r3 = "use a pair Google Glass... Oh wait they are 1000$";
		}
		if (option == 9) {
			r3 = "Sit around and do nothing";
		}
		if (option == 10) {
			r3 = "Order somthing off ebay";
		}

		option = mainr.Next(1, 11);
		if (option == 1) {
			r4 = "Run";
		}
		if (option == 2) {
			r4 = "Fly";
		}
		if (option == 3) {
			r4 = "Eat Melon Rines";
		}
		if (option == 4) {
			r4 = "Attack somthing";
		}
		if (option == 5) {
			r4 = "Look for and press all buttons";
		}
		if (option == 6) {
			r4 = "Sit Down";
		}
		if (option == 7) {
			r4 = "Steal some gold coins";
		}
		if (option == 8) {
			r4 = "use a pair Google Glass... Oh wait they are 1000$";
		}
		if (option == 9) {
			r4 = "Sit around and do nothing";
		}
		if (option == 10) {
			r4 = "Order somthing off ebay";
		}

		option = mainr.Next(1, 11);
		if (option == 1) {
			r5 = "Run";
		}
		if (option == 2) {
			r5 = "Fly";
		}
		if (option == 3) {
			r5 = "Eat Melon Rines";
		}
		if (option == 4) {
			r5 = "Attack somthing";
		}
		if (option == 5) {
			r5 = "Look for and press all buttons";
		}
		if (option == 6) {
			r5 = "Sit Down";
		}
		if (option == 7) {
			r5 = "Steal some gold coins";
		}
		if (option == 8) {
			r5 = "use a pair Google Glass... Oh wait they are 1000$";
		}
		if (option == 9) {
			r5 = "Sit around and do nothing";
		}
		if (option == 10) {
			r5 = "Order somthing off ebay";
		}
	}


	protected void OnO1Clicked (object sender, EventArgs e)
	{
		txt.LabelProp = "I found myself in a "+ place + " with my trusty " + r2 + ". I decided to...";
		o1.Label = r3;
		o2.Label = r4;
		o3.Label = "use " + r2;
		o4.Label = r5;
	}
	public readonly string place = "loading";

	public readonly string r2 = "loading";

	public readonly string r3 = "loading";

	public readonly string r4 = "loading";

	public readonly string r5 = "loading";





		
	}




