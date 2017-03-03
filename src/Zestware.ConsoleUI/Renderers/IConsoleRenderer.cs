namespace Zestware.ConsoleUI.Renderers
{
    public interface IConsoleRenderer<T>
    {
         void Render(T TObject);
    }
}