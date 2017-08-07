

namespace Patterns.Example.Prototype
{
    /// <summary>
    /// Поверхневе копіювання (Shallow copy) копіює тільки прямі поля класу і залишає ті ж посилання, якщо поле було reference-типу, 
    /// нова копія буде створена тільки якщо поле було value-типу. 
    /// 
    /// Глибоке копіювання (Deep copy) копіює ціле дерево об'єктів, таким чином об'єкти отримають різні фізичні адреси в купі (heap). 
    /// </summary>
    public class CalendarPrototype
    {
        public virtual CalendarPrototype Clone()
        {
            var copyOfPrototype = (CalendarPrototype) this.MemberwiseClone();
            return copyOfPrototype;
        }
    }
}
