//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: CardSprite.proto
namespace org.alan.chess.proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CardSprite")]
  public partial class CardSprite : global::ProtoBuf.IExtensible
  {
    public CardSprite() {}
    

    private int _sid = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"sid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int sid
    {
      get { return _sid; }
      set { _sid = value; }
    }

    private string _name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }

    private int _team = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"team", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int team
    {
      get { return _team; }
      set { _team = value; }
    }

    private int _type = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int type
    {
      get { return _type; }
      set { _type = value; }
    }

    private int _x = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"x", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int x
    {
      get { return _x; }
      set { _x = value; }
    }

    private int _z = default(int);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"z", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int z
    {
      get { return _z; }
      set { _z = value; }
    }

    private string _bg = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"bg", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string bg
    {
      get { return _bg; }
      set { _bg = value; }
    }

    private string _texture = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"texture", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string texture
    {
      get { return _texture; }
      set { _texture = value; }
    }

    private int _needSp = default(int);
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"needSp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int needSp
    {
      get { return _needSp; }
      set { _needSp = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}