namespace AresPro.WinFormsUi.Helpers;

public static class ProgressBarHelper
{
    public static void Decrease(ProgressBar progressBar)
    {
        if (progressBar.Value > progressBar.Minimum)
            progressBar.Value--;
    }

    public static void Increase(ProgressBar progressBar)
    {
        if (progressBar.Value == progressBar.Maximum)
            return;

        // Progress bars have an annimation on increase that makes it seem sliggish for use with stats.
        // Since the annimation is only on increase, if we add 2 then remove 1 it will update immediatly.
        // Need to tempoarally increase maximum to allow this to work on the last increase.
        int newValue = progressBar.Value + 2;
        if (newValue > progressBar.Maximum)
        {
            progressBar.Maximum++;
            progressBar.Value = newValue;
            progressBar.Value--;
            progressBar.Maximum--;
        }
        else
        {
            progressBar.Value = newValue;
            progressBar.Value--;
        }
    }
}
