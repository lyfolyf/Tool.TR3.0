using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lead.Tool.TesetReal3
{
    public partial class PrimConfigControl : UserControl
    {
        TesetReal_Tool _prim = null;

        public PrimConfigControl()
        {
            InitializeComponent();
        }

        public PrimConfigControl(TesetReal_Tool prim, PrimOutputControl output) : this()
        {
            _prim = prim;
            if (output != null)
            {
                output.Dock = DockStyle.Fill;
                this.panel1.Controls.Add(output);
            }
        }

        private void PrimConfigControl_Load(object sender, EventArgs e)
        {
            if (_prim == null)
            {
                this.Enabled = false;
            }
            _prim.LogicControl.updateMsg -= LogicControl_updateMsg;
            _prim.LogicControl.updateMsg += LogicControl_updateMsg;
            tboxFileName.Text = _prim.Config.FilePath;
            lbName.Text = _prim._Name;
        }

        private bool LogicControl_updateMsg(string strArgs)
        {
            this.Invoke((MethodInvoker)delegate
            {
                rtbox.Text += strArgs + "\r\n";
                rtbox.SelectionStart = rtbox.Text.Length;
                rtbox.ScrollToCaret();
                if (rtbox.Lines.Length > 300)
                {
                    rtbox.Clear();
                }
            });
            return true;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = false;
            dlg.Filter = "Task File|*.task";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                tboxFileName.Text = dlg.FileName;
                _prim.Config.FilePath = dlg.FileName;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                _prim.LoadTaskFile(_prim.Config.FilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
