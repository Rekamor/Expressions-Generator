namespace ExpressionsWinForms;

public partial class Form1 : Form
{
    string PrimesPath { get; }
    string SettingsPath { get; }

    public Form1()
    {
        InitializeComponent();

        PrimesPath = Path.GetTempPath() + "Prime Numbers.json";
        SettingsPath = Path.GetTempPath() + "Numbers Generation Settings.json";

        if (File.Exists(PrimesPath) == false)
        {
            var file = File.Create(PrimesPath);
            file.Close();
            File.WriteAllText(PrimesPath, "[2]");
        }
        if (File.Exists(SettingsPath) == false)
        {
            var file = File.Create(SettingsPath);
            file.Close();
            File.WriteAllText(SettingsPath, "");
        }

        menuButton.Hide();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        HideMenu();
        menuButton.Show();
    }

    private void expressionVisualisationButton_Click(object sender, EventArgs e)
    {
        HideMenu();
        menuButton.Show();
    }

    private void expressionsGenerationSettingsButton_Click(object sender, EventArgs e)
    {
        HideMenu();
        menuButton.Show();
    }

    private void primeNumbersInformationButton_Click(object sender, EventArgs e)
    {
        HideMenu();
        menuButton.Show();
    }

    private void HideMenu()
    {
        label1.Hide();
        expressionGenerateButton.Hide();
        expressionVisualisationButton.Hide();
        expressionsGenerationSettingsButton.Hide();
        primeNumbersInformationButton.Hide();
        closeButton.Hide();
    }

    private void exitButton_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void menuButton_Click(object sender, EventArgs e)
    {
        menuButton.Hide();
        label1.Show();
        expressionGenerateButton.Show();
        expressionVisualisationButton.Show();
        expressionsGenerationSettingsButton.Show();
        primeNumbersInformationButton.Show();
        closeButton.Show();
    }
}