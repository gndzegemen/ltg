using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Scenario
{
    public int SequenceNumber;
    public string GUID;

    public Scenario(int sequenceNumber)
    {
        SequenceNumber = sequenceNumber;
        GUID = Guid.NewGuid().ToString();
    }
}
