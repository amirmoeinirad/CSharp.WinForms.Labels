
// Amir Moeini Rad
// September 2025

// Main Concept: Working with Labels in Windows Forms

using System;
using System.Windows.Forms;

public class LabelsDemo : Form
{
    // Constructor
    public LabelsDemo()
    {
        // This method creates and initializes the controls on the form.
        InitializeComponent();
    }


    private void InitializeComponent()
    {
        // The form's title will show the command line path used to start the application.
        // 'Text' is a property of the Form class.
        Text = Environment.CommandLine;

        // Set the starting position of the form to the center of the screen.
        // 'StartPosition' is a property of the Form class.
        StartPosition = FormStartPosition.CenterScreen;

        // Create the label controls.
        Label myDateLabel = new Label();
        Label myLabel = new Label();

        // Set the properties of the label controls.
        myLabel.Text = "This program was executed at:";
        myLabel.AutoSize = true;
        myLabel.Left = 50;
        myLabel.Top = 20;

        DateTime currDate = DateTime.Now;
        myDateLabel.Text = currDate.ToString();

        myDateLabel.AutoSize = true;
        myDateLabel.Left = 50 + myLabel.PreferredWidth + 10;
        myDateLabel.Top = 20;

        // Set the size of the form to accommodate the labels.
        Width = myLabel.PreferredWidth + myDateLabel.PreferredWidth + 110;
        Height = myLabel.PreferredHeight+ 100;

        // Add the label control to the form.
        Controls.Add(myDateLabel);
        Controls.Add(myLabel);
    }


    // The main entry point for the application.
    public static void Main(string[] args)
    {
        // Creating and showing the form.
        Application.Run(new LabelsDemo());
    }
}