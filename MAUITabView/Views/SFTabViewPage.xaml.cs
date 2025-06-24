using System.Diagnostics;

namespace MAUITabView;

public partial class SFTabViewPage : ContentPage
{
    Stopwatch stopwatch;
    public SFTabViewPage()
	{
        stopwatch = new Stopwatch();
        stopwatch.Start();
        InitializeComponent();
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
        System.Diagnostics.Debug.WriteLine("~~~~~~~~~~~~~SfTabView Memory used: " + heapSize);
    }

    private void SFTabView_Loaded(object? sender, EventArgs e)
    {
        stopwatch.Stop();
        DisplayAlert("Time Takes loaded TabView", stopwatch.Elapsed.TotalMilliseconds.ToString(), "cancel");
    }
}