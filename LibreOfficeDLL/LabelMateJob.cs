using System;
using unoidl.com.sun.star.task;
using unoidl.com.sun.star.uno;
using unoidl.com.sun.star.frame;
using unoidl.com.sun.star.text;
using unoidl.com.sun.star.lang;

namespace LabelMateAddin
{
    public class LabelMateJob : XJobExecutor
    {
        public void trigger(string args)
        {
            try
            {
                XComponentContext xContext = uno.util.Bootstrap.bootstrap();
                XMultiComponentFactory xMCF = xContext.getServiceManager();

                XTextDocument xDoc = GetCurrentDocument(xContext);
                if (xDoc == null) return;

                XText xText = xDoc.getText();
                XTextCursor xCursor = xText.createTextCursor();

                xCursor.gotoStart(false);
                xText.insertString(xCursor, "[TLP:CHRNĚNÉ] ", false);
            }
            catch (Exception ex)
            {
                Console.WriteLine("LabelMateJob Error: " + ex.Message);
            }
        }

        private XTextDocument GetCurrentDocument(XComponentContext xContext)
        {
            try
            {
                object desktop = xContext.getServiceManager().createInstanceWithContext(
                    "com.sun.star.frame.Desktop", xContext);
                XDesktop xDesktop = (XDesktop)desktop;
                XComponent xComponent = xDesktop.getCurrentComponent();
                return xComponent as XTextDocument;
            }
            catch
            {
                return null;
            }
        }
    }
}
