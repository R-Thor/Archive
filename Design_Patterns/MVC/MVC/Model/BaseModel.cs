using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;

namespace MVC.Model
{
    public abstract class BaseModel
    {
        /// <SUMMARY>
        /// Event fired when the model is finished calculating/processing the data.
        /// </SUMMARY>
        public event EventHandler ModelChanged;

        #region protected members
        
        protected BackgroundWorker backgroundWorker;
        protected DataSet ds;
        
        #endregion protected members

        #region constructor
        protected BaseModel()
        {
            ds = new DataSet();
            backgroundWorker = new BackgroundWorker();

            backgroundWorker.WorkerReportsProgress = false;
            backgroundWorker.WorkerSupportsCancellation = true;
        }
        #endregion constructor

        /// <summary>
        /// GET (Retrieve)
        /// </summary>
        internal abstract void GET();
        /// <summary>
        /// POST (CREATE)
        /// </summary>
        internal abstract void POST();

        /// <summary>
        /// PUT (update all fields and use default values for any undefined fields)
        /// </summary>
        internal abstract void PUT();

        /// <summary>
        /// DELETE (Delete)
        /// </summary>
        internal abstract void DELETE();

        /// <summary>
        /// MERGE (update only the fields that are specified and changed from current version)
        /// </summary>
        internal abstract void MERGE();

        #region public methods
        /// <SUMMARY>
        /// Returns the report data.
        /// </SUMMARY>
        public DataSet QueryModel()
        {
            return ds;
        }

        public void CancelBackgroundWorker()
        {
            backgroundWorker.CancelAsync();
        }
        #endregion public methods

        #region event firing methods
        protected void Fire_ModelChanged(object sender, RunWorkerCompletedEventArgs ea)
        {
            BackgroundWorker bw = sender as BackgroundWorker;
            if (bw != null)
                bw.RunWorkerCompleted -=
            new RunWorkerCompletedEventHandler(Fire_ModelChanged);

            if (ModelChanged != null)
                ModelChanged(this, EventArgs.Empty);
        }

        //protected void Fire_ModelProgress(object sender, int percent)
        //{
        //    if (ModelProgress != null)
        //        ModelProgress(this, percent);
        //}
        #endregion event firing methods
    }
}
