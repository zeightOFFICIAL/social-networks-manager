


namespace SocialNetworksManager.Sources
{
    class MessageUnwrap
    {
        public Guid Gid { get; set; } = new Guid();
        public int Id { get; set; }
        public char OuterFlag { get; set; }
        public char? InnerFlag { get; set; }
        public DateTime? Time { get; set; }
        public string? Data { get; set; }
        public long? SendTo { get; set; }

        public MessageUnwrap(int _Id, char _OuterFlag, AnyMessageType _Message, long _PeerId)
        {
            Id = _Id;
            OuterFlag = _OuterFlag;
            InnerFlag = _Message.Flag;
            Time = _Message.MessageTime;
            Data = _Message.Data;
            SendTo = _PeerId;
        }

        public MessageUnwrap(int _Id, char _OuterFlag, AnyMessageType _Message)
        {
            Id = _Id;
            OuterFlag = _OuterFlag;
            InnerFlag = _Message.Flag;
            Time = _Message.MessageTime;
            Data = _Message.Data;
        }

        public MessageUnwrap(int _Id, char _OuterFlag, char _InnerFlag, DateTime _Time, string? _Data)
        {
            Id = _Id;
            OuterFlag = _OuterFlag;
            InnerFlag = _InnerFlag;
            Time = _Time;
            Data = _Data;
        }

        public MessageUnwrap()
        {
            Id = -1;
            OuterFlag = ' ';
            InnerFlag = ' ';
            Time = DateTime.Now;
            Data = " ";
        }
    }
}
