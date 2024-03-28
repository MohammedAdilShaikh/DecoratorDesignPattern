// ColorDecorator.cs
using DecoratorPatternExample.AbstractClasses;
using DecoratorPatternExample.Interfaces;

namespace DecoratorPatternExample.Decorators
{
    public class ColorDecorator : Decorator<string>
    {
        public ColorDecorator(IComponent<string> component) : base(component) { }

        public override string GetText()
        {
            return $"\u001b[31m{base.GetText()}\u001b[0m"; // Color the text in red
        }
    }
}
