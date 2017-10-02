/**
 * Autogenerated by Thrift Compiler (1.0.0-dev)
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
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace FusionMiner.Thrift
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class HardwareConfig : TBase
  {
    private HardwareType _Type;
    private int _DeviceNumber;
    private string _DeviceName;
    private int _Frequency;
    private int _Voltage;

    /// <summary>
    /// 
    /// <seealso cref="HardwareType"/>
    /// </summary>
    public HardwareType Type
    {
      get
      {
        return _Type;
      }
      set
      {
        __isset.Type = true;
        this._Type = value;
      }
    }

    public int DeviceNumber
    {
      get
      {
        return _DeviceNumber;
      }
      set
      {
        __isset.DeviceNumber = true;
        this._DeviceNumber = value;
      }
    }

    public string DeviceName
    {
      get
      {
        return _DeviceName;
      }
      set
      {
        __isset.DeviceName = true;
        this._DeviceName = value;
      }
    }

    public int Frequency
    {
      get
      {
        return _Frequency;
      }
      set
      {
        __isset.Frequency = true;
        this._Frequency = value;
      }
    }

    public int Voltage
    {
      get
      {
        return _Voltage;
      }
      set
      {
        __isset.Voltage = true;
        this._Voltage = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool Type;
      public bool DeviceNumber;
      public bool DeviceName;
      public bool Frequency;
      public bool Voltage;
    }

    public HardwareConfig() {
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
            if (field.Type == TType.I32) {
              Type = (HardwareType)iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              DeviceNumber = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.String) {
              DeviceName = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I32) {
              Frequency = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.I32) {
              Voltage = iprot.ReadI32();
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
      TStruct struc = new TStruct("HardwareConfig");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.Type) {
        field.Name = "Type";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32((int)Type);
        oprot.WriteFieldEnd();
      }
      if (__isset.DeviceNumber) {
        field.Name = "DeviceNumber";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(DeviceNumber);
        oprot.WriteFieldEnd();
      }
      if (DeviceName != null && __isset.DeviceName) {
        field.Name = "DeviceName";
        field.Type = TType.String;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(DeviceName);
        oprot.WriteFieldEnd();
      }
      if (__isset.Frequency) {
        field.Name = "Frequency";
        field.Type = TType.I32;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Frequency);
        oprot.WriteFieldEnd();
      }
      if (__isset.Voltage) {
        field.Name = "Voltage";
        field.Type = TType.I32;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Voltage);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("HardwareConfig(");
      bool __first = true;
      if (__isset.Type) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Type: ");
        __sb.Append(Type);
      }
      if (__isset.DeviceNumber) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("DeviceNumber: ");
        __sb.Append(DeviceNumber);
      }
      if (DeviceName != null && __isset.DeviceName) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("DeviceName: ");
        __sb.Append(DeviceName);
      }
      if (__isset.Frequency) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Frequency: ");
        __sb.Append(Frequency);
      }
      if (__isset.Voltage) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Voltage: ");
        __sb.Append(Voltage);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}