using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;

[ServiceContract]
public interface IPublishing
{
    [OperationContract(IsOneWay = true)]
    void Publish(Message e, string topicName);

}