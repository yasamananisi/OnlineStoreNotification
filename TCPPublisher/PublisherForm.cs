using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using System.Configuration;


namespace Publisher
{
    public partial class PublisherForm : Form
    {
        IPublishing _proxy;
        int _eventCounter;

        public PublisherForm()
        {
            InitializeComponent();
            CreateProxy();
            _eventCounter = 0;
            txtTopicName.Text = "Belt";
            txtEventData.Text = "Price: 30$ - Product details of Remax Sports Belt Rhythm Series Super Waterproof Adjustable High-capacity";
        }
        private void CreateProxy()
        {
            string endpointAddressInString = ConfigurationManager.AppSettings["EndpointAddress"];
            EndpointAddress endpointAddress = new EndpointAddress(endpointAddressInString);
            NetTcpBinding netTcpBinding = new NetTcpBinding();
            _proxy = ChannelFactory<IPublishing>.CreateChannel(netTcpBinding, endpointAddress);
        }

        void SendEvent(object sender, EventArgs e)
        {
            try
            {
                string topicName = txtTopicName.Text.Trim();
                if (string.IsNullOrEmpty(topicName))
                {
                    MessageBox.Show("Please Enter a Product Name");
                    return;
                }

                Message alertData = PrepareEvent();
                _proxy.Publish(alertData, topicName);
                _eventCounter += 1;
                txtEventCount.Text = _eventCounter.ToString();
            }
            catch { }
        }

        private Message PrepareEvent()
        {
            Message e = new Message();
            e.TopicName = txtTopicName.Text;
            e.EventData = txtEventData.Text;
            return e;
        }

        void OnResetCounter(object sender, EventArgs e)
        {
            _eventCounter = 0;
            txtEventCount.Text = _eventCounter.ToString();
        }

        private void tmrEvent_Tick(object sender, EventArgs e)
        {
            SendEvent(sender, e);
        }
    }
}