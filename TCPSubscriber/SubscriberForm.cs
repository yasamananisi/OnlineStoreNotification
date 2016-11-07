using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;

using System.Diagnostics;

using System.Configuration;


namespace SubscriberNamespace
{
 
    public partial class Subscriber : Form, IPublishing
    {
        ISubscription _proxy;
        static int _eventCount;
        string _endpoint = string.Empty;

        public Subscriber()
        {
            InitializeComponent();
            _endpoint = ConfigurationManager.AppSettings["EndpointAddress"];
            MakeProxy(_endpoint, this);
            _eventCount = 0;
            txtTopicName.Text = "Belt";
        }   


        public void MakeProxy(string EndpoindAddress, object callbackinstance)
        {
            NetTcpBinding netTcpbinding = new NetTcpBinding(SecurityMode.None);
            EndpointAddress endpointAddress = new EndpointAddress(EndpoindAddress);
            InstanceContext context = new InstanceContext(callbackinstance);        

            DuplexChannelFactory<ISubscription> channelFactory = new DuplexChannelFactory<ISubscription>(new InstanceContext(this), netTcpbinding, endpointAddress);
            _proxy  = channelFactory.CreateChannel();
        }

        void OnSubscribe(object sender, EventArgs e)
        {
            try
            {
                string topicName = txtTopicName.Text.Trim();
                if (string.IsNullOrEmpty(topicName))
                {
                    MessageBox.Show("Please Enter a Product Name");
                    return;
                }
                _proxy.Subscribe(topicName);
                ((Button)sender).Visible = false;
                button2.Visible = true;
            }
            catch
            {

            }
        }

        void OnUnSubscribe(object sender, EventArgs e)
        {
            string topicName = txtTopicName.Text.Trim();
            if (string.IsNullOrEmpty(topicName))
            {
                MessageBox.Show("Please Enter a Product Name");
                return;
            }
            ((Button)sender).Visible = false;
            button1.Visible = true;
            _proxy.UnSubscribe(topicName);
        }



        private void btnClearAstaListView_Click(object sender, EventArgs e)
        {
            lstEvents.Items.Clear();
        }

        #region IMyEvents Members

        public void Publish(Message e, String topicName)
        {
            if (e != null)
            {
                int itemNum = (lstEvents.Items.Count < 1) ? 0 : lstEvents.Items.Count;
                lstEvents.Items.Add(itemNum.ToString());
                lstEvents.Items[itemNum].SubItems.AddRange(new string[] { e.TopicName.ToString(), e.EventData });
                _eventCount += 1;
                txtAstaEventCount.Text = _eventCount.ToString();

            }
        }

        #endregion
    }

}