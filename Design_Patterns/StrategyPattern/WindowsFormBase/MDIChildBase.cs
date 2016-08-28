using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormBase
{
    public abstract class MDIChildBase : Form
    { 
        ILoad LoadType { get; set; }
        IRefresh RefreshType { get; set; }
        IPersist PersistType{ get; set; }
        
        public MDIChildBase()
        {
        }
        public void RefreshData()
        {
            RefreshType.RefreshData();
        }
        public void LoadData()
        {
            LoadType.LoadData();
        }
        public void PersistData()
        {
            LoadType.PersistData();
        }

    }
}
