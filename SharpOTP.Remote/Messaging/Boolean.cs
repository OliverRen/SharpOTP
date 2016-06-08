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
namespace SharpOTP.Remote.Messaging
{

  [Serializable]
  public partial class Boolean : TBase
  {
    private bool _Value;

    public bool Value
    {
      get
      {
        return _Value;
      }
      set
      {
        __isset.Value = true;
        this._Value = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool Value;
    }

    public Boolean() {
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
            if (field.Type == TType.Bool) {
              Value = iprot.ReadBool();
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
      TStruct struc = new TStruct("Boolean");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.Value) {
        field.Name = "Value";
        field.Type = TType.Bool;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(Value);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("Boolean(");
      sb.Append("Value: ");
      sb.Append(Value);
      sb.Append(")");
      return sb.ToString();
    }

  }

}