using Systam;
using Gtk;

public class Bar()
{
  // This is how to create a public string.
	public string foo = "derp";
	
	// To use it in another class you must do:
	Bar sample = new Bar();
	string derp = sample.foo; //sample.foo is how you call the string
	
	// to make a string able to be used across classes without
	// initializing a new class is to make it static, like so:
	public static string staticString = "value";
	
	// you can call this value like this:
	private string satstr = Bar.staticString;
	
	// The following is a property:
	private int _sampleProp;
	public int sampleProp
	{
	  get
	  {
	    return _sampleProp;
	  }
	  set
	  {
	    _sampleProp = value;
	  }
	}
	// if you want the property to be readonly, then remove the set method
	
	public Bar()
	{
	  //class initialization
	  Console.WriteLine(Bar.staticString);
	  
	  derp = sample.foo;
	  Console.WriteLine(derp);
	  Console.WriteLine(sample.foo);
	}
}
