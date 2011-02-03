using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using Autodesk.Revit.Attributes;

namespace RevitSaveReminder
{
    /// <summary>
    /// Application class for registering the save reminder event handlers with Revit. 
    /// by Rod Howarth (http://www.rodhowarth.com)
    /// </summary>
   [Regeneration(RegenerationOption.Automatic)]
    public class Application : IExternalApplication
    {
        /// <summary>
        /// Registers the event for synchronizing with central
        /// </summary>
        /// <param name="application"></param>
        /// <returns></returns>
        public Result OnStartup(UIControlledApplication application)
        {
            application.ControlledApplication.DocumentSynchronizedWithCentral += ControlledApplication_DocumentSynchronizedWithCentral;
            return Result.Succeeded;
        }

        /// <summary>
        /// Shows the dialog box 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ControlledApplication_DocumentSynchronizedWithCentral(object sender, Autodesk.Revit.DB.Events.DocumentSynchronizedWithCentralEventArgs e)
        {
            //Save to Central Complete
            SaveComplete saveCompleteForm = new SaveComplete();
            saveCompleteForm.ShowDialog();
        }

        /// <summary>
        /// Remove the event listener when Revit is closing. 
        /// </summary>
        /// <param name="application"></param>
        /// <returns></returns>
        public Result OnShutdown(UIControlledApplication application)
        {
            application.ControlledApplication.DocumentSynchronizedWithCentral -= ControlledApplication_DocumentSynchronizedWithCentral;
            return Result.Succeeded;
        }
    }
}
