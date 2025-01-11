namespace Tridy
{
    public abstract class Shape
    {
        public abstract void Draw();
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            // vykreslení kruhu
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape(); // nelze, protože z abstraktní třídy nejde vytvořit objekt
            Shape circle = new Circle(); // lze, protože se jedná o instanci třídy Circle
            circle.Draw();
        }
    }
}


