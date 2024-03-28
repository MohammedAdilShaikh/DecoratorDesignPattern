// ConcreteComponent.cs
using DecoratorPatternExample.Interfaces;

namespace DecoratorPatternExample.ConcreteClasses
{
    public class ConcreteComponent : IComponent<string>
    {
        public string GetText()
        {
            return "This is the base text.";
        }
    }
}