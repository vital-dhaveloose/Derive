﻿using Derive.src.view;

namespace Derive
{
    public partial class ThisAddIn
    {
        #region start and stop

        private void startUp(object sender, System.EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture =
                new System.Globalization.CultureInfo(
                    Application.LanguageSettings.get_LanguageID(
                        Microsoft.Office.Core.MsoAppLanguageID.msoLanguageIDUI));
            //TODO dit zet de culture in en-US ipv de verwachte culture...
        }

        private void shutDown(object sender, System.EventArgs e)
        {

        }

        #endregion

        #region ribbon

        protected override Microsoft.Office.Core.IRibbonExtensibility CreateRibbonExtensibilityObject() {
            return new Ribbon();
        }

        #endregion

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(startUp);
            this.Shutdown += new System.EventHandler(shutDown);
        }
        
        #endregion
    }
}