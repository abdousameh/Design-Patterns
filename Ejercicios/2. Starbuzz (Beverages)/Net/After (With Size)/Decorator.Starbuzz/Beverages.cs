namespace Decorator.Starbuzz
{
	public abstract class Beverage
	{
	    public BeverageSize Size { get; set; }

	    public abstract string GetDescription();

	    public abstract double Cost();
	}
}
