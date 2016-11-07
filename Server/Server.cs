using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace CentralMessagingServer
{
  
    public partial class Server : Form 
    {      
        ServiceHost _publishServiceHost = null;        
        ServiceHost _subscribeServiceHost = null;   
           
        public Server()
        {
            InitializeComponent();
            try
            {
                HostPublishService();
                HostSubscriptionService();
            }
            catch
            {
            }
        }   
        
        #region Service Hosting
        

        private void HostSubscriptionService()
        {
            _subscribeServiceHost = new ServiceHost(typeof(Subscription));             
            NetTcpBinding tcpBinding = new NetTcpBinding(SecurityMode.None);
                    
            _subscribeServiceHost.AddServiceEndpoint(typeof(ISubscription), tcpBinding,
                                "net.tcp://localhost:7002/Sub");           
            _subscribeServiceHost.Open(); 
        }

        private void HostPublishService()
        {
            _publishServiceHost = new ServiceHost(typeof(Publishing));           
            NetTcpBinding tcpBindingpublish = new NetTcpBinding();       
               
            _publishServiceHost.AddServiceEndpoint(typeof(IPublishing), tcpBindingpublish,
                                    "net.tcp://localhost:7001/Pub");           
            _publishServiceHost.Open();  
        }
        #endregion
    

    

    }
}