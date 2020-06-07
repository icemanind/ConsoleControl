using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Linq;

namespace ConsoleControl.Demo
{
    public partial class MainForm : Form
    {
        private string _currentDirectory;

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.Winapi)]
        internal static extern IntPtr GetFocus();

        public MainForm()
        {
            InitializeComponent();

            string codeBase = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
            UriBuilder uri = new UriBuilder(codeBase);
            _currentDirectory = System.IO.Path.GetDirectoryName(Uri.UnescapeDataString(uri.Path));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            consoleControl1.SetCursorPosition(0, 0);
            consoleControl1.Write("Hello World!");
            consoleControl1.SetCursorPosition(2, 15);

            consoleControl1.Write("Look at this message!", Color.Yellow, Color.Blue);

            txtCursorColumn.Text = consoleControl1.GetCursorPosition().Column.ToString();
            txtCursorRow.Text = consoleControl1.GetCursorPosition().Row.ToString();

            txtMessage.Text = @"Hello World!";

            pnlBackgroundColor.BackColor = consoleControl1.CurrentBackgroundColor;
            pnlForegroundColor.BackColor = consoleControl1.CurrentForegroundColor;

            consoleControl1.AllowInput = false;

            consoleControl2.SetCursorPosition(0, 0);
            consoleControl2.Write("Welcome to IcemanShell!");
            consoleControl2.SetCursorPosition(1, 0);
            consoleControl2.Write(string.Format("The current date and time is {0} {1}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString()));
            consoleControl2.Write();
            consoleControl2.Write("Use the command 'help' if you need help!");
            consoleControl2.SetCursorPosition(consoleControl2.GetCursorPosition().Row + 2, 0);
            ShowPrompt();

            consoleControl2.LineEntered += ConsoleControl2LineEntered;

            ActiveControl = consoleControl2;
        }

        private void ShowPrompt()
        {
            consoleControl2.Write();
            consoleControl2.Write("# ");
        }

        private void ConsoleControl2LineEntered(object sender, string line)
        {
            line = line.Trim();
            int ndx = line.IndexOf(' ');
            string cmd = ndx < 0 ? line : line.Substring(0, ndx);
            string parameters = ndx < 0 ? "" : line.Remove(0, ndx + 1);

            switch (cmd.ToLower())
            {
                case "":
                    ShowPrompt();
                    break;
                case "help":
                    ShowHelp();
                    ShowPrompt();
                    break;
                case "exit":
                    Application.Exit();
                    break;
                case "ls":
                    DoLsCommand(parameters);
                    break;
                case "echo":
                    DoEchoCommand(parameters);
                    ShowPrompt();
                    break;
                case "date":
                    DoDateCommand();
                    ShowPrompt();
                    break;
                case "pwd":
                    DoPwdCommand();
                    ShowPrompt();
                    break;
                case "cd":
                    DoCdCommand(parameters);
                    ShowPrompt();
                    break;
                default:
                    consoleControl2.Write("> Unknown Command!");
                    consoleControl2.Write();
                    ShowPrompt();
                    break;
            }
        }

        private void btnClearConsole_Click(object sender, EventArgs e)
        {
            consoleControl1.Clear();
            txtCursorColumn.Text = consoleControl1.GetCursorPosition().Column.ToString();
            txtCursorRow.Text = consoleControl1.GetCursorPosition().Row.ToString();
        }

        private void btnMoveCursor_Click(object sender, EventArgs e)
        {
            int row = int.Parse(txtCursorRow.Text);
            int column = int.Parse(txtCursorColumn.Text);

            if (row < 0 || row > 24)
            {
                MessageBox.Show("Cursor Row Must be between 0 and 24!");
                return;
            }

            if (column < 0 || column > 79)
            {
                MessageBox.Show("Cursor Column Must be between 0 and 79!");
                return;
            }

            consoleControl1.SetCursorPosition(row, column);
        }

        private void rbUnderline_CheckedChanged(object sender, EventArgs e)
        {
            ChangeCursorType();
        }

        private void rbBlock_CheckedChanged(object sender, EventArgs e)
        {
            ChangeCursorType();
        }

        private void rbNone_CheckedChanged(object sender, EventArgs e)
        {
            ChangeCursorType();
        }

        private void ChangeCursorType()
        {
            if (rbUnderline.Checked)
                consoleControl1.CursorType = CursorTypes.Underline;
            if (rbBlock.Checked)
                consoleControl1.CursorType = CursorTypes.Block;
            if (rbNone.Checked)
                consoleControl1.CursorType = CursorTypes.Invisible;
        }

        private void btnWriteMessage_Click(object sender, EventArgs e)
        {
            consoleControl1.Write(txtMessage.Text);
        }

        private void pnlBackgroundColor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlBackgroundColor_DoubleClick(object sender, EventArgs e)
        {
            colorDialog1.Color = consoleControl1.CurrentBackgroundColor;
            DialogResult dr = colorDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                pnlBackgroundColor.BackColor = colorDialog1.Color;
                consoleControl1.CurrentBackgroundColor = colorDialog1.Color;
            }
        }

        private void pnlForegroundColor_DoubleClick(object sender, EventArgs e)
        {
            colorDialog1.Color = consoleControl1.CurrentForegroundColor;
            DialogResult dr = colorDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                pnlForegroundColor.BackColor = colorDialog1.Color;
                consoleControl1.CurrentForegroundColor = colorDialog1.Color;
            }
        }

        private Control FindFocusedControl()
        {
            Control focusedControl = null;
            IntPtr focusedHandle = GetFocus();
            if (focusedHandle != IntPtr.Zero)
                focusedControl = FromHandle(focusedHandle);
            return focusedControl;
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            const int offsetX = 2;

            Bitmap b = new Bitmap(ClientSize.Width, ClientSize.Height);
            Graphics g = Graphics.FromImage(b);

            Control c1 = FindFocusedControl();

            if (c1 != null && c1.Name.StartsWith("consoleControl"))
            {
                for (int i = 1; i < 6; i++)
                {
                    Pen p = new Pen(Color.FromArgb(Math.Min(25 * (i * 2), 255), 50, 80, 255));
                    g.DrawRectangle(p, c1.Location.X - i, c1.Location.Y - i, c1.Size.Width + i + i,
                        c1.Size.Height + i + i);
                }
            }

            g.DrawLine(new Pen(Color.FromArgb(200, 200, 200)), 660 + offsetX, 3, 660 + offsetX, ClientSize.Height - 5);
            g.DrawLine(new Pen(Color.FromArgb(180, 180, 180)), 661 + offsetX, 3, 661 + offsetX, ClientSize.Height - 5);
            g.DrawLine(new Pen(Color.FromArgb(128, 128, 128)), 662 + offsetX, 3, 662 + offsetX, ClientSize.Height - 5);
            g.DrawLine(new Pen(Color.FromArgb(108, 108, 108)), 663 + offsetX, 3, 663 + offsetX, ClientSize.Height - 5);

            e.Graphics.DrawImage(b, new Point(0, 0));
            g.Dispose();
            b.Dispose();
        }

        private void consoleControl1_Enter(object sender, EventArgs e)
        {
            Refresh();
        }

        private void consoleControl1_Leave(object sender, EventArgs e)
        {
            Refresh();
        }

        private void consoleControl2_Enter(object sender, EventArgs e)
        {
            Refresh();
        }

        private void consoleControl2_Leave(object sender, EventArgs e)
        {
            Refresh();
        }

        private void ShowHelp()
        {
            consoleControl2.Write("IcemanShell is just a 'toy' shell to show off Icemanind's Console Control.");
            consoleControl2.Write();
            consoleControl2.Write("Here is a list of commands:");
            consoleControl2.Write();
            consoleControl2.Write("(Note that the commands are NOT case sensitive)");
            consoleControl2.Write();
            consoleControl2.Write();
            consoleControl2.Write("----------------------------------------------------------------------");
            consoleControl2.Write();
            consoleControl2.Write("HELP                Shows this help message");
            consoleControl2.Write();
            consoleControl2.Write("EXIT                Quits the application");
            consoleControl2.Write();
            consoleControl2.Write("LS <path>           Shows the contents of the specified directory.");
            consoleControl2.Write();
            consoleControl2.Write("ECHO [string]       Echo's the [string] to the console.");
            consoleControl2.Write();
            consoleControl2.Write("DATE                Shows the current date.");
            consoleControl2.Write();
            consoleControl2.Write("PWD                 Shows the current working directory.");
            consoleControl2.Write();
            consoleControl2.Write("CD <path>           Change the current working directory to <path>.");
            consoleControl2.Write();
        }

        private void DoLsCommand(string parameters)
        {
            string path;
            Color bgColor = consoleControl2.CurrentBackgroundColor;
            Color fgColor = consoleControl2.CurrentForegroundColor;

            if (string.IsNullOrEmpty(parameters))
            {
                path = _currentDirectory;
            }
            else
            {
                path = parameters.Trim('"');
            }

            string[] files = System.IO.Directory.GetFiles(path);
            string[] directories = System.IO.Directory.GetDirectories(path);

            consoleControl2.CurrentForegroundColor = Color.CadetBlue;
            foreach (string directory in directories.OrderBy(z => z))
            {
                string dirName = "[" + System.IO.Path.GetFileName(directory) + "]";
                consoleControl2.Write(string.Format("{0,-40}", dirName.Length > 40 ? Environment.NewLine + dirName + Environment.NewLine : dirName));
            }

            foreach (string file in files.OrderBy(z => z))
            {
                string fileName = System.IO.Path.GetFileName(file) ?? "";
                string extension = System.IO.Path.GetExtension(file) ?? "";
                switch (extension.ToLower())
                {
                    case ".exe":
                        consoleControl2.CurrentForegroundColor = Color.FromArgb(100, 255, 100);
                        break;
                    case ".dll":
                        consoleControl2.CurrentForegroundColor = Color.FromArgb(10, 165, 10);
                        break;
                    default:
                        consoleControl2.CurrentForegroundColor = Color.LightGray;
                        break;
                }
                consoleControl2.Write(string.Format("{0,-40}", fileName.Length > 40 ? Environment.NewLine + fileName + Environment.NewLine : fileName));
            }

            consoleControl2.CurrentBackgroundColor = bgColor;
            consoleControl2.CurrentForegroundColor = fgColor;

            ShowPrompt();
        }

        private void DoEchoCommand(string parameters)
        {
            consoleControl2.Write(parameters);
            consoleControl2.Write();
        }

        private void DoDateCommand()
        {
            consoleControl2.Write(string.Format("{0}", DateTime.Now.ToString("ddd MMM d HH:mm:ss K yyyy")));
            consoleControl2.Write();
        }

        private void DoPwdCommand()
        {
            consoleControl2.Write(_currentDirectory);
            consoleControl2.Write();
        }

        private void DoCdCommand(string parameters)
        {
            parameters = parameters.Trim('"');

            if (parameters.Length >= 2 && parameters[1] == ':')
            {
                if (System.IO.Directory.Exists(parameters))
                {
                    _currentDirectory = parameters;
                }
                else
                {
                    consoleControl2.Write("Invalid Directory ==> " + parameters);
                    consoleControl2.Write();
                    return;
                }
            }
            else if (parameters.Length > 0 && parameters[0] == '\\')
            {
                if (System.IO.Directory.Exists(System.IO.Path.GetPathRoot(_currentDirectory) + parameters.Remove(0, 1)))
                {
                    _currentDirectory = System.IO.Path.GetPathRoot(_currentDirectory) + parameters.Remove(0, 1);
                }
                else
                {
                    consoleControl2.Write("Invalid Directory ==> " + System.IO.Path.GetPathRoot(_currentDirectory) + parameters.Remove(0, 1));
                    consoleControl2.Write();
                    return;
                }
            }
            else if (parameters.Length > 0)
            {
                if (System.IO.Directory.Exists(_currentDirectory + "\\" + parameters))
                {
                    _currentDirectory = _currentDirectory + "\\" + parameters;
                }
                else
                {
                    consoleControl2.Write("Invalid Directory ==> " + _currentDirectory + parameters);
                    consoleControl2.Write();
                    return;
                }
            }

            _currentDirectory = _currentDirectory.Replace("\\\\", "\\");
            consoleControl2.Write(string.Format("Current Directory is now: {0}", _currentDirectory));
            consoleControl2.Write();
        }
    }
}
