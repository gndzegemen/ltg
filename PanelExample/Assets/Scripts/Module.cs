using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Module
{
    public int SequenceNumber;
    public string GUID;

    public Module(int sequenceNumber)
    {
        SequenceNumber = sequenceNumber;
        GUID = Guid.NewGuid().ToString();
    }
}
