// UpperCaseDecorator.cs
using DecoratorPatternExample.AbstractClasses;
using DecoratorPatternExample.Interfaces;

namespace DecoratorPatternExample.Decorators
{
    public class UpperCaseDecorator : Decorator<string>
    {
        public UpperCaseDecorator(IComponent<string> component) : base(component) { }

        public override string GetText()
        {
            return base.GetText().ToUpper();
        }
    }
}
