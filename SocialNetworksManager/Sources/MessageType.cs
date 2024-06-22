


namespace SocialNetworksManager.Sources
{
    interface IMessage
    {
        Guid Id { get; }
        string? Data { get; }
        char? Flag { get; }
        DateTime? MessageTime { get; }
        List<string>? Attachments { get; }
        void AddAttachment(string Attachment);
        void RemoveAttachment(string Attachment);
    }

    class AnyMessageType : IMessage
    {
        public Guid Id { get; } = new Guid();
        public string? Data { get; }
        public char? Flag { get; }
        public DateTime? MessageTime { get; }
        public List<string>? Attachments { get; }

        public AnyMessageType(string _Data, char _Flag, DateTime _Time) {
            Data = _Data;
            Flag = _Flag;
            MessageTime = _Time;
        }

        void IMessage.AddAttachment(string Attachment)
        {
            throw new NotImplementedException();
        }

        void IMessage.RemoveAttachment(string Attachment)
        {
            throw new NotImplementedException();
        }
    }

    class MessageWrap
    {
        public int Id { get; }
        public char OuterFlag { get; set; }
        public AnyMessageType Message { get; set; }

        public MessageWrap(int _Id, char _OuterFlag, AnyMessageType _Message)
        {
            Id = _Id;
            OuterFlag = _OuterFlag;
            Message = _Message;
        }
    }
}