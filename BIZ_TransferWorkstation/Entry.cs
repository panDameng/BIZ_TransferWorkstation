using Mes.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIZ_TransferWorkstation
{
    public class Entry : Mes.Core.Interface.IMesPlugin
    {
        IApplication _app = null;

        #region IMesPlugin Members

        public IApplication Application
        {
            get
            {
                return _app;
            }
            set
            {
                _app = value;
            }
        }

        public void Load()
        {
            MainForm mf = new MainForm();
            Mes.ControlsEx.Utility.FormHelper.Show(mf, _app);
        }

        public string PluginAuthor
        {
            get { return "guimeng.pan@hand-china.com"; }
        }

        public string PluginDescription
        {
            get { return "物料搬运单查询"; }
        }

        public string PluginName
        {
            get { return "物料搬运单查询"; }
        }

        public void UnLoad()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
