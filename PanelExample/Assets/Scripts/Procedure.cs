using System;

[Serializable]
public class Procedure
{
    public int SequenceNumber;
    public string GUID;
    public string Content;

    public Procedure(int sequenceNumber, string content)
    {
        SequenceNumber = sequenceNumber;
        GUID = Guid.NewGuid().ToString();
        Content = content;
    }
}
