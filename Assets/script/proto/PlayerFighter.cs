//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: PlayerFighter.proto
namespace org.alan.chess.proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PlayerFighter")]
  public partial class PlayerFighter : global::ProtoBuf.IExtensible
  {
    public PlayerFighter() {}
    

    private int _teamId = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"teamId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int teamId
    {
      get { return _teamId; }
      set { _teamId = value; }
    }

    private long _playerId = default(long);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"playerId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long playerId
    {
      get { return _playerId; }
      set { _playerId = value; }
    }

    private string _playerName = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"playerName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string playerName
    {
      get { return _playerName; }
      set { _playerName = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}