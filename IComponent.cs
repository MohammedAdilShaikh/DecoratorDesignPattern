// IComponent.cs
namespace DecoratorPatternExample.Interfaces
{
    public interface IComponent<T>
    {
        T GetText();
    }
}