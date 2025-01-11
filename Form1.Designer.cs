namespace ExpressionsWinForms;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        label1 = new Label();
        expressionGenerateButton = new Button();
        expressionVisualisationButton = new Button();
        expressionsGenerationSettingsButton = new Button();
        primeNumbersInformationButton = new Button();
        closeButton = new Button();
        menuButton = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        resources.ApplyResources(label1, "label1");
        label1.Name = "label1";
        // 
        // expressionGenerateButton
        // 
        resources.ApplyResources(expressionGenerateButton, "expressionGenerateButton");
        expressionGenerateButton.Name = "expressionGenerateButton";
        expressionGenerateButton.UseVisualStyleBackColor = true;
        expressionGenerateButton.Click += button1_Click;
        // 
        // expressionVisualisationButton
        // 
        resources.ApplyResources(expressionVisualisationButton, "expressionVisualisationButton");
        expressionVisualisationButton.Name = "expressionVisualisationButton";
        expressionVisualisationButton.UseVisualStyleBackColor = true;
        expressionVisualisationButton.Click += expressionVisualisationButton_Click;
        // 
        // expressionsGenerationSettingsButton
        // 
        resources.ApplyResources(expressionsGenerationSettingsButton, "expressionsGenerationSettingsButton");
        expressionsGenerationSettingsButton.Name = "expressionsGenerationSettingsButton";
        expressionsGenerationSettingsButton.UseVisualStyleBackColor = true;
        expressionsGenerationSettingsButton.Click += expressionsGenerationSettingsButton_Click;
        // 
        // primeNumbersInformationButton
        // 
        resources.ApplyResources(primeNumbersInformationButton, "primeNumbersInformationButton");
        primeNumbersInformationButton.Name = "primeNumbersInformationButton";
        primeNumbersInformationButton.UseVisualStyleBackColor = true;
        primeNumbersInformationButton.Click += primeNumbersInformationButton_Click;
        // 
        // closeButton
        // 
        resources.ApplyResources(closeButton, "closeButton");
        closeButton.Name = "closeButton";
        closeButton.UseVisualStyleBackColor = true;
        closeButton.Click += exitButton_Click;
        // 
        // menuButton
        // 
        resources.ApplyResources(menuButton, "menuButton");
        menuButton.Name = "menuButton";
        menuButton.UseVisualStyleBackColor = true;
        menuButton.Click += menuButton_Click;
        // 
        // Form1
        // 
        AutoScaleMode = AutoScaleMode.None;
        resources.ApplyResources(this, "$this");
        Controls.Add(menuButton);
        Controls.Add(closeButton);
        Controls.Add(primeNumbersInformationButton);
        Controls.Add(expressionsGenerationSettingsButton);
        Controls.Add(expressionVisualisationButton);
        Controls.Add(expressionGenerateButton);
        Controls.Add(label1);
        FormBorderStyle = FormBorderStyle.None;
        Name = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Button expressionGenerateButton;
    private Button expressionVisualisationButton;
    private Button expressionsGenerationSettingsButton;
    private Button primeNumbersInformationButton;
    private Button closeButton;
    private Button menuButton;
}