using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;

[DataContract]
public class Message
{
    private string _topicName;

    private string _eventData;

    [DataMember]
    public string TopicName { get { return _topicName; } set { _topicName = value; } }

    [DataMember]
    public string EventData { get { return _eventData; } set { _eventData = value; } }
}