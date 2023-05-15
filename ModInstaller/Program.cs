using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.IO;
using System.Windows.Forms;

class Program
{
    static void Main()
    {
        // Get the current directory
        string currentDirectory = Directory.GetCurrentDirectory();

        // Create a new form
        Form form = new Form();

        // Get all .ini files in the current directory
        string[] iniFiles = Directory.GetFiles(currentDirectory, "*.ini");

        // Create a button for each .ini file
        foreach (string iniFile in iniFiles)
        {
            // Create a new button
            Button button = new Button();

            // Set the button's text to the .ini file's name without the extension
            button.Text = Path.GetFileNameWithoutExtension(iniFile);

            // Add an event handler to the button's Click event
            button.Click += (sender, e) => {
                // 7z archive and unzip the corresponding .ini file
                SevenZip.SevenZipCompressor compressor = new SevenZip.SevenZipCompressor();
                compressor.CompressFiles(iniFile + ".7z", iniFile);
                compressor.ExtractArchive(iniFile + ".7z", currentDirectory);
            };

            // Add the button to the form
            form.Controls.Add(button);
        }

        // Show the form
        Application.Run(form);
    }
}