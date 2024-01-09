namespace _4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Windown win = new Windown(2,3);
            win.DrawWindow();
            Button btn = new Button(5,6);
            btn.DrawWindow();
            ListBox lsB = new ListBox(5,6,"click me!");
            lsB.DrawWindow();
            Windown[] winArray = new Windown[3];
            winArray[0] = new Windown(1, 2);
            winArray[1] = new Button(2, 3);
            winArray[2] = new ListBox(9, 9,"kosdj");
            for(int i = 0; i < 3; i++)
            {
                winArray[i].DrawWindow();
            }

        }
    }
}