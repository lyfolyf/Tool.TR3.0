using Lead.Tool.Interface;
using Lead.Tool.XML;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicControl;
using IControllerInterface;
using CommonStruct.Communicate;

namespace Lead.Tool.TesetReal3
{
    public class TesetReal_Tool : ITool
    {
        public Config _config;
        public string _path = "";
        public string _Name = "";
        private PrimConfigControl _configUI;
        private PrimOutputControl _debugUI;
        private IToolState _State = IToolState.ToolMin;

        private ILogicControl _logicControl = null;
        public  TesetReal_Tool(string Name, string path)
        {
            _Name = Name;
            _path = path;
            if (File.Exists(path))
            {
                _config = (Config)XmlSerializerHelper.ReadXML(path, typeof(Config));
            }
            else
            {
                _config = new Config();
            }
            _configUI = new PrimConfigControl();
            _debugUI = new PrimOutputControl();

            _logicControl = new LogicController();
            _logicControl.Graph3D = _debugUI.Map3D;
            _logicControl.ColorRuler3D = _debugUI.ColorRuler;

        }

        #region Common
        public IToolState State
        {
            get { return _State; }
        }

        public Control ConfigUI
        {
            get
            {
                return _configUI;
            }
        }

        public Control DebugUI
        {
            get
            {
                return _debugUI;
            }
        }

        public void Init()
        {

            _State = IToolState.ToolInit;
        }

        public void Start()
        {
            _State = IToolState.ToolRunning;
        }

        public void Terminate()
        {
            _State = IToolState.ToolTerminate;
            return;
        }
        #endregion

        public ILogicControl LogicControl
        {
            get { return _logicControl; }
        }

        public Config Config
        {
            get { return _config; }
        }

        public bool LoadTaskFile(string fileName = "")
        {
            if (string.IsNullOrEmpty(fileName))
            {
                if (!File.Exists(_config.FilePath))
                {
                    return false;
                }
                return _logicControl.OpenMeasureTask(_config.FilePath);
            }
            else
            {
                if (!File.Exists(fileName))
                {
                    return false;
                }
                return _logicControl.OpenMeasureTask(fileName);
            }
        }

        public void FillPointCloud(int index, PointCloudData pointCloudData)
        {
            var Re= _logicControl.FillSingleInputPrimData(index, pointCloudData);

            if (!Re)
            {
                throw new Exception("编号为"+ index+"的点云设置到TestReal错误");
            }
        }

        public OutputPrimData Run()
        {
            OutputPrimData outputPrimData = null;
            _logicControl.TaskRun(out outputPrimData);
            return outputPrimData;
        }
    }

}
