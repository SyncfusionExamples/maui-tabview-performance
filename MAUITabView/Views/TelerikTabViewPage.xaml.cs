using System.Diagnostics;

namespace MAUITabView;

public partial class TelerikTabViewPage : ContentPage
{
    Stopwatch stopwatch;
    public TelerikTabViewPage()
	{
        stopwatch = new Stopwatch();
        stopwatch.Start();
        InitializeComponent();

    }

    private void TelerikTabView_Loaded(object? sender, EventArgs e)
    {
        stopwatch.Stop();
        DisplayAlert("Time Takes loaded TabView", stopwatch.Elapsed.TotalSeconds.ToString(), "cancel");
    }

    protected override void OnAppearing()
    {
        GC.Collect();
        base.OnAppearing();
        RefreshStats();
    }

    private void RefreshStats()
    {
        double heapSize = (GC.GetTotalMemory(false)) / (1024.0 * 1024.0);
        DisplayAlert("size", heapSize.ToString(), "cancel");
        System.Diagnostics.Debug.WriteLine("~~~~~~~~~~~~~TelerikTabView Memory used: " + heapSize);
    }
}