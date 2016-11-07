using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using System.Threading;
using System.Reflection;
using System.Diagnostics;
using CentralMessagingServer;


[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
class Publishing : IPublishing
{
    #region IPublishing Members
    public void Publish(Message e, string topicName)
    {
        List<IPublishing> subscribers = Filter.GetSubscribers(topicName);
        if (subscribers == null) return;

        Type type = typeof(IPublishing);
        MethodInfo publishMethodInfo = type.GetMethod("Publish");
       
        foreach (IPublishing subscriber in subscribers)
        {
            try
            {
                publishMethodInfo.Invoke(subscriber, new object[] { e, topicName });
            }
            catch
            {

            }

        }


    }


    #endregion
}

