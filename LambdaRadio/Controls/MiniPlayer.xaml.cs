namespace LambdaRadio.Controls;

public partial class MiniPlayer : ContentView
{

    public MiniPlayer()
    {
        InitializeComponent();
    }

    void TapGestureRecognizer_Tapped(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
        Console.WriteLine("Show Player");
    }

    void TapGestureRecognizer_Tapped_1(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
        Console.WriteLine("Play/Pause Music");
    }

    void SwipeGestureRecognizer_Swiped(System.Object sender, Microsoft.Maui.Controls.SwipedEventArgs e)
    {
        Console.WriteLine("Show Player");
    }
}
