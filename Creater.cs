using Lead.Tool.Interface;
using Lead.Tool.Resources;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lead.Tool.TesetReal3
{
    public class TesetRealCreat : ICreat
    {
        public TesetRealCreat()
        {
            ;
        }
        public ITool GetInstance(string Name, string Path)
        {
            return new TesetReal_Tool(Name, Path);
        }

        public Image Icon
        {
            get
            {
                return (Image)ImageManager.GetImage("TestReal");
            }
        }

        public string Name
        {
            get
            {
                return "TestReal";
            }
        }
    }

}
