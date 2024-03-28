// Program.cs
using System;
using DecoratorPatternExample.ConcreteClasses;
using DecoratorPatternExample.Decorators;
using DecoratorPatternExample.Interfaces;

namespace DecoratorPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create ConcreteComponent
            IComponent<string> component = new ConcreteComponent();

            // Create Decorators
            IComponent<string> plainDecorator = new PlainDecorator(component);
            IComponent<string> upperCaseDecorator = new UpperCaseDecorator(component);
            IComponent<string> colorDecorator = new ColorDecorator(component);

            // Print results
            Console.WriteLine("Concrete Component: " + component.GetText());
            Console.WriteLine("Plain Decorator: " + plainDecorator.GetText());
            Console.WriteLine("Upper Case Decorator: " + upperCaseDecorator.GetText());
            Console.WriteLine("Color Decorator: " + colorDecorator.GetText());
        }
    }
}
