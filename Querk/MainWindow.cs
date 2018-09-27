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

namespace Querk
{
    public partial class MainWindow : Form
    {

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        bool overriding = false;

        //Querk replacements.
        public List<QuerkReplacement> querks = new List<QuerkReplacement>();
        public List<QuerkReplacement> cFileReplacements = new List<QuerkReplacement>();
        public List<QuerkReplacement> lFileReplacements = new List<QuerkReplacement>();
        public List<QuerkReplacement> nFileReplacements = new List<QuerkReplacement>();
        public List<QuerkReplacement> capsPreset = new List<QuerkReplacement>();
        public List<QuerkReplacement> lowerPreset = new List<QuerkReplacement>();
        public List<QuerkReplacement> numberPreset = new List<QuerkReplacement>();


        /// <summary>
        /// Querk replacement.
        /// </summary>
        public class QuerkReplacement {

            public QuerkReplacement(string key, string msg) {

                if (key == msg) { enabled = false; }
                newKey = msg;

                switch (key) {

                    case "a":
                        keyId = (int)Keys.A;
                        break;

                    case "b":
                        keyId = (int)Keys.B;
                        break;

                    case "c":
                        keyId = (int)Keys.C;
                        break;

                    case "d":
                        keyId = (int)Keys.D;
                        break;

                    case "e":
                        keyId = (int)Keys.E;
                        break;

                    case "f":
                        keyId = (int)Keys.F;
                        break;

                    case "g":
                        keyId = (int)Keys.G;
                        break;

                    case "h":
                        keyId = (int)Keys.H;
                        break;

                    case "i":
                        keyId = (int)Keys.I;
                        break;

                    case "j":
                        keyId = (int)Keys.J;
                        break;

                    case "k":
                        keyId = (int)Keys.K;
                        break;

                    case "l":
                        keyId = (int)Keys.L;
                        break;

                    case "m":
                        keyId = (int)Keys.M;
                        break;

                    case "n":
                        keyId = (int)Keys.N;
                        break;

                    case "o":
                        keyId = (int)Keys.O;
                        break;

                    case "p":
                        keyId = (int)Keys.P;
                        break;

                    case "q":
                        keyId = (int)Keys.Q;
                        break;

                    case "r":
                        keyId = (int)Keys.R;
                        break;

                    case "s":
                        keyId = (int)Keys.S;
                        break;

                    case "t":
                        keyId = (int)Keys.T;
                        break;

                    case "u":
                        keyId = (int)Keys.U;
                        break;

                    case "v":
                        keyId = (int)Keys.V;
                        break;

                    case "w":
                        keyId = (int)Keys.W;
                        break;

                    case "x":
                        keyId = (int)Keys.X;
                        break;

                    case "y":
                        keyId = (int)Keys.Y;
                        break;

                    case "z":
                        keyId = (int)Keys.Z;
                        break;

                    case "A":
                        keyId = (int)Keys.A;
                        hasShift = true;
                        break;

                    case "B":
                        keyId = (int)Keys.B;
                        hasShift = true;
                        break;

                    case "C":
                        keyId = (int)Keys.C;
                        hasShift = true;
                        break;

                    case "D":
                        keyId = (int)Keys.D;
                        hasShift = true;
                        break;

                    case "E":
                        keyId = (int)Keys.E;
                        hasShift = true;
                        break;

                    case "F":
                        keyId = (int)Keys.F;
                        hasShift = true;
                        break;

                    case "G":
                        keyId = (int)Keys.G;
                        hasShift = true;
                        break;

                    case "H":
                        keyId = (int)Keys.H;
                        hasShift = true;
                        break;

                    case "I":
                        keyId = (int)Keys.I;
                        hasShift = true;
                        break;

                    case "J":
                        keyId = (int)Keys.J;
                        hasShift = true;
                        break;

                    case "K":
                        keyId = (int)Keys.K;
                        hasShift = true;
                        break;

                    case "L":
                        keyId = (int)Keys.L;
                        hasShift = true;
                        break;

                    case "M":
                        keyId = (int)Keys.M;
                        hasShift = true;
                        break;

                    case "N":
                        keyId = (int)Keys.N;
                        hasShift = true;
                        break;

                    case "O":
                        keyId = (int)Keys.O;
                        hasShift = true;
                        break;

                    case "P":
                        keyId = (int)Keys.P;
                        hasShift = true;
                        break;

                    case "Q":
                        keyId = (int)Keys.Q;
                        hasShift = true;
                        break;

                    case "R":
                        keyId = (int)Keys.R;
                        hasShift = true;
                        break;

                    case "S":
                        keyId = (int)Keys.S;
                        hasShift = true;
                        break;

                    case "T":
                        keyId = (int)Keys.T;
                        hasShift = true;
                        break;

                    case "U":
                        keyId = (int)Keys.U;
                        hasShift = true;
                        break;

                    case "V":
                        keyId = (int)Keys.V;
                        hasShift = true;
                        break;

                    case "W":
                        keyId = (int)Keys.W;
                        hasShift = true;
                        break;

                    case "X":
                        keyId = (int)Keys.X;
                        hasShift = true;
                        break;

                    case "Y":
                        keyId = (int)Keys.Y;
                        hasShift = true;
                        break;

                    case "Z":
                        keyId = (int)Keys.Z;
                        hasShift = true;
                        break;

                    case "0":
                        keyId = (int)Keys.D0;
                        break;

                    case "1":
                        keyId = (int)Keys.D1;
                        break;

                    case "2":
                        keyId = (int)Keys.D2;
                        break;

                    case "3":
                        keyId = (int)Keys.D3;
                        break;

                    case "4":
                        keyId = (int)Keys.D4;
                        break;

                    case "5":
                        keyId = (int)Keys.D5;
                        break;

                    case "6":
                        keyId = (int)Keys.D6;
                        break;

                    case "7":
                        keyId = (int)Keys.D7;
                        break;

                    case "8":
                        keyId = (int)Keys.D8;
                        break;

                    case "9":
                        keyId = (int)Keys.D9;
                        break;

                }

            }
            
            public int keyId;
            public string newKey;
            public bool hasShift = false;
            public bool enabled = true;

        }


        public MainWindow()
        {
            InitializeComponent();
            uBox.SelectedIndex = 0;
            lBox.SelectedIndex = 0;
            nBox.SelectedIndex = 0;
            UpdateQuerks();
        }

        protected override void WndProc(ref Message m)
        {
            for (int i = 0; i < querks.Count(); i++)
            {
                if (m.Msg == 0x0312 && m.WParam.ToInt32() == i + 1 && eBox.Checked && querks[i].enabled && !overriding)
                {
                    overriding = true;
                    SendKeys.Send(querks[i].newKey);
                    overriding = false;
                }
            }
            base.WndProc(ref m);
        }


        private void eBox_CheckedChanged(object sender, EventArgs e)
        {

            if (eBox.Checked)
            {
                LoadQuerks();
            }
            else {
                UnloadQuerks();
            }
            
        }


        public void LoadQuerks() {

            for (int i = 0; i < querks.Count(); i++)
            {
                int shift = 0;
                if (querks[i].hasShift) { shift = 4; }
                if (querks[i].enabled) { RegisterHotKey(this.Handle, i + 1, shift, querks[i].keyId); }
            }

        }


        public void UnloadQuerks() {

            for (int i = 0; i < querks.Count(); i++)
            {
                UnregisterHotKey(this.Handle, i + 1);
            }

        }


        public void UpdateQuerks() {

            if (eBox.Checked) {
                UnloadQuerks();
            }

            querks = new List<QuerkReplacement>();
            querks.AddRange(capsPreset);
            querks.AddRange(lowerPreset);
            querks.AddRange(numberPreset);

            if (eBox.Checked) {
                LoadQuerks();
            }

        }



        private void uBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (uBox.SelectedIndex) {

                case 0:
                    LoadFileContents(0);
                    break;

                case 1:
                    capsPreset = new List<QuerkReplacement>();
                    break;

                case 2:
                    capsPreset = CapsPreset.Blocked;
                    break;

                case 3:
                    capsPreset = CapsPreset.Circled;
                    break;

                case 4:
                    capsPreset = CapsPreset.Runic;
                    break;

                case 5:
                    capsPreset = CapsPreset.Greek;
                    break;

                case 6:
                    capsPreset = CapsPreset.Gothic;
                    break;

                case 7:
                    capsPreset = CapsPreset.Curvy;
                    break;

                case 8:
                    capsPreset = CapsPreset.Lines;
                    break;

                case 9:
                    capsPreset = CapsPreset.Upaccent;
                    break;

                case 10:
                    capsPreset = CapsPreset.Downaccent;
                    break;

                case 11:
                    capsPreset = CapsPreset.BoldCursive;
                    break;

                case 12:
                    capsPreset = CapsPreset.Bold;
                    break;

                case 13:
                    capsPreset = CapsPreset.Outline;
                    break;

            }

            UpdateQuerks();

        }
 

        private void nBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (nBox.SelectedIndex)
            {

                case 0:
                    LoadFileContents(2);
                    break;

                case 1:
                    numberPreset = new List<QuerkReplacement>();
                    break;

                case 2:
                    numberPreset = NumbersPreset.Tiny;
                    break;

                case 3:
                    numberPreset = NumbersPreset.Circled;
                    break;

                case 4:
                    numberPreset = NumbersPreset.Gypsy;
                    break;

                case 5:
                    numberPreset = NumbersPreset.Runic;
                    break;

                case 6:
                    numberPreset = NumbersPreset.Magic;
                    break;

                case 7:
                    numberPreset = NumbersPreset.Outline;
                    break;

                case 8:
                    numberPreset = NumbersPreset.Bold;
                    break;

                case 9:
                    numberPreset = NumbersPreset.BoldCurvy;
                    break;

                case 10:
                    numberPreset = NumbersPreset.FancyDinner;
                    break;

            }

            UpdateQuerks();

        }


        private void lBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (lBox.SelectedIndex)
            {

                case 0:
                    LoadFileContents(1);
                    break;

                case 1:
                    lowerPreset = new List<QuerkReplacement>();
                    break;

                case 2:
                    lowerPreset = LowersPresets.Circled;
                    break;

                case 3:
                    lowerPreset = LowersPresets.Greek;
                    break;

                case 4:
                    lowerPreset = LowersPresets.Gothic;
                    break;

                case 5:
                    lowerPreset = LowersPresets.Cave;
                    break;

                case 6:
                    lowerPreset = LowersPresets.Ancient;
                    break;

                case 7:
                    lowerPreset = LowersPresets.AccentAncient;
                    break;

                case 8:
                    lowerPreset = LowersPresets.Medieval;
                    break;

                case 9:
                    lowerPreset = LowersPresets.BoldCursive;
                    break;

                case 10:
                    lowerPreset = LowersPresets.Cursive;
                    break;

                case 11:
                    lowerPreset = LowersPresets.Bold;
                    break;

                case 12:
                    lowerPreset = LowersPresets.Outline;
                    break;

                case 13:
                    lowerPreset = LowersPresets.Tiny;
                    break;

                case 14:
                    lowerPreset = LowersPresets.UpsideDown;
                    break;

            }

            UpdateQuerks();

        }


        public void LoadFileContents(int type)
        {

            switch (type) {

                case 0:
                    capsPreset = cFileReplacements;
                    break;

                case 1:
                    lowerPreset = lFileReplacements;
                    break;

                case 2:
                    numberPreset = nFileReplacements;
                    break;

            }

        }


        private void fBox_Click(object sender, EventArgs e)
        {

            OpenFileDialog o = new OpenFileDialog();
            o.RestoreDirectory = true;
            o.Filter = "Querk Definition List|*.txt";
            o.FileName = "";
            o.ShowDialog();

            if (o.FileName != "") {

                List<string> file = new List<string>(File.ReadAllLines(o.FileName));
                cFileReplacements = new List<QuerkReplacement>();
                lFileReplacements = new List<QuerkReplacement>();
                nFileReplacements = new List<QuerkReplacement>();
                foreach (string s in file) {

                    if (char.IsUpper(s[0]))
                    {
                        cFileReplacements.Add(new QuerkReplacement(s[0].ToString(), s.Substring(2)));
                    }
                    else if (char.IsLower(s[0]))
                    {
                        lFileReplacements.Add(new QuerkReplacement(s[0].ToString(), s.Substring(2)));
                    }
                    else {
                        nFileReplacements.Add(new QuerkReplacement(s[0].ToString(), s.Substring(2)));
                    }

                }

                if (uBox.SelectedIndex == 0) {
                    LoadFileContents(0);
                }

                if (lBox.SelectedIndex == 0)
                {
                    LoadFileContents(1);
                }

                if (nBox.SelectedIndex == 0)
                {
                    LoadFileContents(2);
                }

            }

            UpdateQuerks();

        }

        private void ImportStatusForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(3000);
                this.ShowInTaskbar = false;
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon.Visible = false;
        }

    }

}
