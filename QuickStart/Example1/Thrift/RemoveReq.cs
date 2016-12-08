/**
 * Autogenerated by Thrift Compiler (0.8.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using Thrift.Protocol;
using Thrift.Transport;
namespace Example1.Thrift
{

  [Serializable]
  public partial class RemoveReq : TBase
  {
    private string _Key;

    public string Key
    {
      get
      {
        return _Key;
      }
      set
      {
        __isset.Key = true;
        this._Key = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool Key;
    }

    public RemoveReq() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.String) {
              Key = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("RemoveReq");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (Key != null && __isset.Key) {
        field.Name = "Key";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Key);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("RemoveReq(");
      sb.Append("Key: ");
      sb.Append(Key);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
