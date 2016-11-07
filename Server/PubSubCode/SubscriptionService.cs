using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using CentralMessagingServer;


[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
class Subscription : ISubscription
{
    #region ISubscription Members

    public void Subscribe(string topicName)
    {
        IPublishing subscriber = OperationContext.Current.GetCallbackChannel<IPublishing>();
        Filter.AddSubscriber(topicName, subscriber);
    }

    public void UnSubscribe(string topicName)
    {
        IPublishing subscriber = OperationContext.Current.GetCallbackChannel<IPublishing>();
        Filter.RemoveSubscriber(topicName, subscriber);
    }

    #endregion
}
