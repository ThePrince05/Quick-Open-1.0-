using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quick_Open__1._0_
{
    public partial class Main : Form
    {
        private string appDataFolder;
        private string quickOpenFolder;
        private string directoryFilePath;

        // hotkey registration
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private const int HOTKEY_ID = 1; // Identifier for the hotkey
        private const uint MOD_CTRL = 0x0002;
        private const uint MOD_ALT = 0x0001;
        private const uint VK_F = 0x46; // Virtual Key for 'F'

        // A flag to check if the hotkey was registered successfully
        private bool hotkeyRegistered = false;


        // Import user32.dll for draggable
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int iParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;


        // tray menu
        private ContextMenuStrip trayMenu;
        public Main()
        {
            InitializeComponent();

            // Register the Ctrl+Alt+F hotkey
            hotkeyRegistered = RegisterHotKey(this.Handle, HOTKEY_ID, MOD_CTRL | MOD_ALT, VK_F);
           
            // Optionally, notify the user if registration failed
            if (!hotkeyRegistered)
            {
              MessageBox.Show("Hotkey registration failed.", "Failure",
              MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            // Set the form's icon
            this.Icon = new System.Drawing.Icon("quick low.ico");

            // Get AppData folder path and set paths for the folder and file
            appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            quickOpenFolder = Path.Combine(appDataFolder, "Quick Open");
            directoryFilePath = Path.Combine(quickOpenFolder, "directory.txt");

            // Ensure the directory and file exist
            EnsureDirectoryAndFileExist();


            // Initialize context menu for NotifyIcon
            trayMenu = new ContextMenuStrip();
            trayMenu.Items.Add("Open", null, OpenSetUp);
            trayMenu.Items.Add("Exit", null, ExitApp);

            //Attach the context menu to the NotifyIcon
            notifyIcon1.ContextMenuStrip = trayMenu;
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;

            // Listen for the hotkey message
            if (m.Msg == WM_HOTKEY && m.WParam.ToInt32() == HOTKEY_ID)
            {
                // Action when Ctrl+Alt+F is pressed
                OpenApplication();
            }

            base.WndProc(ref m);
        }

        private void OpenApplication()
        {
            // Specify the path of the application you want to open
            System.Diagnostics.Process.Start("C:\\Program Files\\BraveSoftware\\Brave-Browser\\Application\\brave.exe");

            /* string path = ReadDirectoryPath();

            try
            {
                // Specify the path to the program you want to open
                Process.Start(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops, something went wrong on: " + ex.Message);
            }
            */
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Unregister the hotkey when the form is closed
            UnregisterHotKey(this.Handle, HOTKEY_ID);
        }

        // Method to restore the application from the tray
        private void OpenSetUp(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void ExitApp(object sender, EventArgs e)
        {

            notifyIcon1.Visible = false;

            try
            {
                // Unregister the hotkey when the form is closed
                if (hotkeyRegistered)
                {
                    UnregisterHotKey(this.Handle, HOTKEY_ID);
                }

                // Avoid recursion by preventing the event from triggering again
                base.FormClosing -= Main_FormClosing;

                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops, something went wrong on: " + ex.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // This method ensures the folder and file exist, and creates them if necessary
        private void EnsureDirectoryAndFileExist()
        {
            try
            {
                // Check if the "Quick Open" folder exists; if not, create it
                if (!Directory.Exists(quickOpenFolder))
                {
                    Directory.CreateDirectory(quickOpenFolder);
                    // MessageBox.Show("Quick Open folder created at: " + quickOpenFolder);  
                }

                // Check if the "directory.txt" file exists; if not, create it
                if (!File.Exists(directoryFilePath))
                {
                    File.Create(directoryFilePath).Close(); // Create the file and close the stream
                                                            // MessageBox.Show("Directory file created at: " + directoryFilePath);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Oops, something went wrong on: " + ex.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        // This method writes a new directory path to the "directory.txt" file
        private void SaveDirectoryPath(string newPath)
        {
            try
            {
                // Overwrite the file with the new directory path
                File.WriteAllText(directoryFilePath, newPath);
                MessageBox.Show("Directory path saved to: " + directoryFilePath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops, something went wrong on: " + ex.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ReadDirectoryPath()
        {
            try
            {
                // Check if the file exists before reading it
                if (File.Exists(directoryFilePath))
                {

                    // Read all text from the file
                    string directoryPath = File.ReadAllText(directoryFilePath);

                    // Check if the file is empty or contains only whitespace
                    if (string.IsNullOrWhiteSpace(directoryPath))
                    {
                        MessageBox.Show("Please configure program settings.", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return null;
                    }

                    // Return the directory path if the file has content
                    return directoryPath;

                }
                else
                {
                    MessageBox.Show("Oops, Something went wrong on: Directory File does not exist.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops, something went wrong on: " + ex.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void panel_main_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);

            // When the left mouse button is pressed, drag the window
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
