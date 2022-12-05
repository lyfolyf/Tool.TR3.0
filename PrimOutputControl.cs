using System.Windows.Forms;
using UserControls;

namespace Lead.Tool.TesetReal3
{
    public partial class PrimOutputControl : UserControl
    {
        public Map3D Map3D
        {
            get
            {
                return this.map3D1;
            }
        }

        public ColorRuler ColorRuler
        {
            get
            {
                return this.colorRuler1;
            }
        }

        public PrimOutputControl()
        {
            InitializeComponent();
        }
    }
}
