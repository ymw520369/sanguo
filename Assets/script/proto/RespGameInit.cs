//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: RespGameInit.proto
// Note: requires additional types generated from: CardSprite.proto
// Note: requires additional types generated from: TeamInfo.proto
namespace org.alan.chess.proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RespGameInit")]
  public partial class RespGameInit : global::ProtoBuf.IExtensible
  {
    public RespGameInit() {}
    

    private int _currentTeamId = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"currentTeamId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int currentTeamId
    {
      get { return _currentTeamId; }
      set { _currentTeamId = value; }
    }

    private int _mapId = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"mapId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int mapId
    {
      get { return _mapId; }
      set { _mapId = value; }
    }

    private int _battleSid = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"battleSid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int battleSid
    {
      get { return _battleSid; }
      set { _battleSid = value; }
    }
    private readonly global::System.Collections.Generic.List<org.alan.chess.proto.CardSprite> _allSprite = new global::System.Collections.Generic.List<org.alan.chess.proto.CardSprite>();
    [global::ProtoBuf.ProtoMember(4, Name=@"allSprite", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<org.alan.chess.proto.CardSprite> allSprite
    {
      get { return _allSprite; }
    }
  
    private readonly global::System.Collections.Generic.List<org.alan.chess.proto.TeamInfo> _teamInfos = new global::System.Collections.Generic.List<org.alan.chess.proto.TeamInfo>();
    [global::ProtoBuf.ProtoMember(5, Name=@"teamInfos", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<org.alan.chess.proto.TeamInfo> teamInfos
    {
      get { return _teamInfos; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}