using System;
using System.Reflection;
using System.ServiceProcess;
using System.Timers;
using System.Xml;
using System.Xml.Xsl;

namespace XSLTWindowsService
{
    public partial class Service1 : ServiceBase
    {
        private Timer myTimer;
        private readonly ILogger logger = new Logger(MethodBase.GetCurrentMethod().DeclaringType);

        public Service1()
        {
            logger.Debug(MethodBase.GetCurrentMethod().DeclaringType.Name);
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            logger.Debug(MethodBase.GetCurrentMethod().DeclaringType.Name);
            myTimer = new Timer(10000);
            myTimer.Elapsed += new ElapsedEventHandler(DisplayTimeEvent);
            myTimer.Enabled = true;
            myTimer.Start();            
        }

        private void DisplayTimeEvent(object source, ElapsedEventArgs e)
        {
            // code here will run every second
            try
            {
                logger.Debug(MethodBase.GetCurrentMethod().DeclaringType.Name);
                XslTransform xsl = new XslTransform();
                XmlTextReader xmlTextReader = new XmlTextReader("C:\\Users\\andreu.conesa\\Documents\\cds.xsl");
                xsl.Load(xmlTextReader);
                // Execute the transformation and output the results to a file.
                xsl.Transform("C:\\Users\\andreu.conesa\\Documents\\cds.xml", "C:\\Users\\andreu.conesa\\Documents\\cds.html");
            }
            catch (Exception ex)
            {
                logger.Exception(ex, ex.InnerException.Message);               
            }
            
        }

        protected override void OnStop()
        {
            myTimer.Stop();
        }
    }
}
