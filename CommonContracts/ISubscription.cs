using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;

[ServiceContract(CallbackContract = typeof(IPublishing))]
public interface ISubscription
{
    [OperationContract]
    void Subscribe(string topicName);

    [OperationContract]
    void UnSubscribe(string topicName);
}