//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: RespCurrentGoInfo.proto
namespace org.alan.chess.proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RespCurrentGoInfo")]
  public partial class RespCurrentGoInfo : global::ProtoBuf.IExtensible
  {
    public RespCurrentGoInfo() {}
    

    private int _countdownSecond = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"countdownSecond", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int countdownSecond
    {
      get { return _countdownSecond; }
      set { _countdownSecond = value; }
    }

    private int _roundNum = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"roundNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int roundNum
    {
      get { return _roundNum; }
      set { _roundNum = value; }
    }

    private bool _newRound = default(bool);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"newRound", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool newRound
    {
      get { return _newRound; }
      set { _newRound = value; }
    }

    private int _currentTeamId = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"currentTeamId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int currentTeamId
    {
      get { return _currentTeamId; }
      set { _currentTeamId = value; }
    }

    private long _playerId = default(long);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"playerId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long playerId
    {
      get { return _playerId; }
      set { _playerId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}