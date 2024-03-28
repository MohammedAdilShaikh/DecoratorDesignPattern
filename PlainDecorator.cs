// PlainDecorator.cs
using DecoratorPatternExample.AbstractClasses;
using DecoratorPatternExample.Interfaces;

namespace DecoratorPatternExample.Decorators
{
    public class PlainDecorator : Decorator<string>
    {
        public PlainDecorator(IComponent<string> component) : base(component) { }

        public override string GetText()
        {
            return "Prefix: " + base.GetText();
        }
    }
}
