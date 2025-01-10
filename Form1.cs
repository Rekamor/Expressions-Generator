namespace ExpressionsWinForms;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        HideMenu();
    }

    private void expressionVisualisationButton_Click(object sender, EventArgs e)
    {
        HideMenu();
    }

    private void expressionsGenerationSettingsButton_Click(object sender, EventArgs e)
    {
        HideMenu();
    }

    private void primeNumbersInformationButton_Click(object sender, EventArgs e)
    {
        HideMenu();
    }

    private void HideMenu()
    {
        label1.Hide();
        expressionGenerateButton.Hide();
        expressionVisualisationButton.Hide();
        expressionsGenerationSettingsButton.Hide();
        primeNumbersInformationButton.Hide();
        exitButton.Hide();
    }

    private void exitButton_Click(object sender, EventArgs e)
    {
        Close();
    }
}