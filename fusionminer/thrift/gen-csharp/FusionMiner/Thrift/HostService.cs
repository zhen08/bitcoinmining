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
  public partial class HostService {
    public interface Iface {
      string Ping();
      #if SILVERLIGHT
      IAsyncResult Begin_Ping(AsyncCallback callback, object state);
      string End_Ping(IAsyncResult asyncResult);
      #endif
      long GetUniqueId(MinerInfo minerInfo);
      #if SILVERLIGHT
      IAsyncResult Begin_GetUniqueId(AsyncCallback callback, object state, MinerInfo minerInfo);
      long End_GetUniqueId(IAsyncResult asyncResult);
      #endif
      string GetSN(MinerInfo minerInfo);
      #if SILVERLIGHT
      IAsyncResult Begin_GetSN(AsyncCallback callback, object state, MinerInfo minerInfo);
      string End_GetSN(IAsyncResult asyncResult);
      #endif
      Maintenance QueryMaintenanceTask(long uniqueId, string version, string key);
      #if SILVERLIGHT
      IAsyncResult Begin_QueryMaintenanceTask(AsyncCallback callback, object state, long uniqueId, string version, string key);
      Maintenance End_QueryMaintenanceTask(IAsyncResult asyncResult);
      #endif
      void SubmitHostStatus(MinerHostStatus status);
      #if SILVERLIGHT
      IAsyncResult Begin_SubmitHostStatus(AsyncCallback callback, object state, MinerHostStatus status);
      void End_SubmitHostStatus(IAsyncResult asyncResult);
      #endif
    }

    public class Client : IDisposable, Iface {
      public Client(TProtocol prot) : this(prot, prot)
      {
      }

      public Client(TProtocol iprot, TProtocol oprot)
      {
        iprot_ = iprot;
        oprot_ = oprot;
      }

      protected TProtocol iprot_;
      protected TProtocol oprot_;
      protected int seqid_;

      public TProtocol InputProtocol
      {
        get { return iprot_; }
      }
      public TProtocol OutputProtocol
      {
        get { return oprot_; }
      }


      #region " IDisposable Support "
      private bool _IsDisposed;

      // IDisposable
      public void Dispose()
      {
        Dispose(true);
      }
      

      protected virtual void Dispose(bool disposing)
      {
        if (!_IsDisposed)
        {
          if (disposing)
          {
            if (iprot_ != null)
            {
              ((IDisposable)iprot_).Dispose();
            }
            if (oprot_ != null)
            {
              ((IDisposable)oprot_).Dispose();
            }
          }
        }
        _IsDisposed = true;
      }
      #endregion


      
      #if SILVERLIGHT
      public IAsyncResult Begin_Ping(AsyncCallback callback, object state)
      {
        return send_Ping(callback, state);
      }

      public string End_Ping(IAsyncResult asyncResult)
      {
        oprot_.Transport.EndFlush(asyncResult);
        return recv_Ping();
      }

      #endif

      public string Ping()
      {
        #if !SILVERLIGHT
        send_Ping();
        return recv_Ping();

        #else
        var asyncResult = Begin_Ping(null, null);
        return End_Ping(asyncResult);

        #endif
      }
      #if SILVERLIGHT
      public IAsyncResult send_Ping(AsyncCallback callback, object state)
      #else
      public void send_Ping()
      #endif
      {
        oprot_.WriteMessageBegin(new TMessage("Ping", TMessageType.Call, seqid_));
        Ping_args args = new Ping_args();
        args.Write(oprot_);
        oprot_.WriteMessageEnd();
        #if SILVERLIGHT
        return oprot_.Transport.BeginFlush(callback, state);
        #else
        oprot_.Transport.Flush();
        #endif
      }

      public string recv_Ping()
      {
        TMessage msg = iprot_.ReadMessageBegin();
        if (msg.Type == TMessageType.Exception) {
          TApplicationException x = TApplicationException.Read(iprot_);
          iprot_.ReadMessageEnd();
          throw x;
        }
        Ping_result result = new Ping_result();
        result.Read(iprot_);
        iprot_.ReadMessageEnd();
        if (result.__isset.success) {
          return result.Success;
        }
        throw new TApplicationException(TApplicationException.ExceptionType.MissingResult, "Ping failed: unknown result");
      }

      
      #if SILVERLIGHT
      public IAsyncResult Begin_GetUniqueId(AsyncCallback callback, object state, MinerInfo minerInfo)
      {
        return send_GetUniqueId(callback, state, minerInfo);
      }

      public long End_GetUniqueId(IAsyncResult asyncResult)
      {
        oprot_.Transport.EndFlush(asyncResult);
        return recv_GetUniqueId();
      }

      #endif

      public long GetUniqueId(MinerInfo minerInfo)
      {
        #if !SILVERLIGHT
        send_GetUniqueId(minerInfo);
        return recv_GetUniqueId();

        #else
        var asyncResult = Begin_GetUniqueId(null, null, minerInfo);
        return End_GetUniqueId(asyncResult);

        #endif
      }
      #if SILVERLIGHT
      public IAsyncResult send_GetUniqueId(AsyncCallback callback, object state, MinerInfo minerInfo)
      #else
      public void send_GetUniqueId(MinerInfo minerInfo)
      #endif
      {
        oprot_.WriteMessageBegin(new TMessage("GetUniqueId", TMessageType.Call, seqid_));
        GetUniqueId_args args = new GetUniqueId_args();
        args.MinerInfo = minerInfo;
        args.Write(oprot_);
        oprot_.WriteMessageEnd();
        #if SILVERLIGHT
        return oprot_.Transport.BeginFlush(callback, state);
        #else
        oprot_.Transport.Flush();
        #endif
      }

      public long recv_GetUniqueId()
      {
        TMessage msg = iprot_.ReadMessageBegin();
        if (msg.Type == TMessageType.Exception) {
          TApplicationException x = TApplicationException.Read(iprot_);
          iprot_.ReadMessageEnd();
          throw x;
        }
        GetUniqueId_result result = new GetUniqueId_result();
        result.Read(iprot_);
        iprot_.ReadMessageEnd();
        if (result.__isset.success) {
          return result.Success;
        }
        throw new TApplicationException(TApplicationException.ExceptionType.MissingResult, "GetUniqueId failed: unknown result");
      }

      
      #if SILVERLIGHT
      public IAsyncResult Begin_GetSN(AsyncCallback callback, object state, MinerInfo minerInfo)
      {
        return send_GetSN(callback, state, minerInfo);
      }

      public string End_GetSN(IAsyncResult asyncResult)
      {
        oprot_.Transport.EndFlush(asyncResult);
        return recv_GetSN();
      }

      #endif

      public string GetSN(MinerInfo minerInfo)
      {
        #if !SILVERLIGHT
        send_GetSN(minerInfo);
        return recv_GetSN();

        #else
        var asyncResult = Begin_GetSN(null, null, minerInfo);
        return End_GetSN(asyncResult);

        #endif
      }
      #if SILVERLIGHT
      public IAsyncResult send_GetSN(AsyncCallback callback, object state, MinerInfo minerInfo)
      #else
      public void send_GetSN(MinerInfo minerInfo)
      #endif
      {
        oprot_.WriteMessageBegin(new TMessage("GetSN", TMessageType.Call, seqid_));
        GetSN_args args = new GetSN_args();
        args.MinerInfo = minerInfo;
        args.Write(oprot_);
        oprot_.WriteMessageEnd();
        #if SILVERLIGHT
        return oprot_.Transport.BeginFlush(callback, state);
        #else
        oprot_.Transport.Flush();
        #endif
      }

      public string recv_GetSN()
      {
        TMessage msg = iprot_.ReadMessageBegin();
        if (msg.Type == TMessageType.Exception) {
          TApplicationException x = TApplicationException.Read(iprot_);
          iprot_.ReadMessageEnd();
          throw x;
        }
        GetSN_result result = new GetSN_result();
        result.Read(iprot_);
        iprot_.ReadMessageEnd();
        if (result.__isset.success) {
          return result.Success;
        }
        throw new TApplicationException(TApplicationException.ExceptionType.MissingResult, "GetSN failed: unknown result");
      }

      
      #if SILVERLIGHT
      public IAsyncResult Begin_QueryMaintenanceTask(AsyncCallback callback, object state, long uniqueId, string version, string key)
      {
        return send_QueryMaintenanceTask(callback, state, uniqueId, version, key);
      }

      public Maintenance End_QueryMaintenanceTask(IAsyncResult asyncResult)
      {
        oprot_.Transport.EndFlush(asyncResult);
        return recv_QueryMaintenanceTask();
      }

      #endif

      public Maintenance QueryMaintenanceTask(long uniqueId, string version, string key)
      {
        #if !SILVERLIGHT
        send_QueryMaintenanceTask(uniqueId, version, key);
        return recv_QueryMaintenanceTask();

        #else
        var asyncResult = Begin_QueryMaintenanceTask(null, null, uniqueId, version, key);
        return End_QueryMaintenanceTask(asyncResult);

        #endif
      }
      #if SILVERLIGHT
      public IAsyncResult send_QueryMaintenanceTask(AsyncCallback callback, object state, long uniqueId, string version, string key)
      #else
      public void send_QueryMaintenanceTask(long uniqueId, string version, string key)
      #endif
      {
        oprot_.WriteMessageBegin(new TMessage("QueryMaintenanceTask", TMessageType.Call, seqid_));
        QueryMaintenanceTask_args args = new QueryMaintenanceTask_args();
        args.UniqueId = uniqueId;
        args.Version = version;
        args.Key = key;
        args.Write(oprot_);
        oprot_.WriteMessageEnd();
        #if SILVERLIGHT
        return oprot_.Transport.BeginFlush(callback, state);
        #else
        oprot_.Transport.Flush();
        #endif
      }

      public Maintenance recv_QueryMaintenanceTask()
      {
        TMessage msg = iprot_.ReadMessageBegin();
        if (msg.Type == TMessageType.Exception) {
          TApplicationException x = TApplicationException.Read(iprot_);
          iprot_.ReadMessageEnd();
          throw x;
        }
        QueryMaintenanceTask_result result = new QueryMaintenanceTask_result();
        result.Read(iprot_);
        iprot_.ReadMessageEnd();
        if (result.__isset.success) {
          return result.Success;
        }
        throw new TApplicationException(TApplicationException.ExceptionType.MissingResult, "QueryMaintenanceTask failed: unknown result");
      }

      
      #if SILVERLIGHT
      public IAsyncResult Begin_SubmitHostStatus(AsyncCallback callback, object state, MinerHostStatus status)
      {
        return send_SubmitHostStatus(callback, state, status);
      }

      public void End_SubmitHostStatus(IAsyncResult asyncResult)
      {
        oprot_.Transport.EndFlush(asyncResult);
        recv_SubmitHostStatus();
      }

      #endif

      public void SubmitHostStatus(MinerHostStatus status)
      {
        #if !SILVERLIGHT
        send_SubmitHostStatus(status);
        recv_SubmitHostStatus();

        #else
        var asyncResult = Begin_SubmitHostStatus(null, null, status);
        End_SubmitHostStatus(asyncResult);

        #endif
      }
      #if SILVERLIGHT
      public IAsyncResult send_SubmitHostStatus(AsyncCallback callback, object state, MinerHostStatus status)
      #else
      public void send_SubmitHostStatus(MinerHostStatus status)
      #endif
      {
        oprot_.WriteMessageBegin(new TMessage("SubmitHostStatus", TMessageType.Call, seqid_));
        SubmitHostStatus_args args = new SubmitHostStatus_args();
        args.Status = status;
        args.Write(oprot_);
        oprot_.WriteMessageEnd();
        #if SILVERLIGHT
        return oprot_.Transport.BeginFlush(callback, state);
        #else
        oprot_.Transport.Flush();
        #endif
      }

      public void recv_SubmitHostStatus()
      {
        TMessage msg = iprot_.ReadMessageBegin();
        if (msg.Type == TMessageType.Exception) {
          TApplicationException x = TApplicationException.Read(iprot_);
          iprot_.ReadMessageEnd();
          throw x;
        }
        SubmitHostStatus_result result = new SubmitHostStatus_result();
        result.Read(iprot_);
        iprot_.ReadMessageEnd();
        return;
      }

    }
    public class Processor : TProcessor {
      public Processor(Iface iface)
      {
        iface_ = iface;
        processMap_["Ping"] = Ping_Process;
        processMap_["GetUniqueId"] = GetUniqueId_Process;
        processMap_["GetSN"] = GetSN_Process;
        processMap_["QueryMaintenanceTask"] = QueryMaintenanceTask_Process;
        processMap_["SubmitHostStatus"] = SubmitHostStatus_Process;
      }

      protected delegate void ProcessFunction(int seqid, TProtocol iprot, TProtocol oprot);
      private Iface iface_;
      protected Dictionary<string, ProcessFunction> processMap_ = new Dictionary<string, ProcessFunction>();

      public bool Process(TProtocol iprot, TProtocol oprot)
      {
        try
        {
          TMessage msg = iprot.ReadMessageBegin();
          ProcessFunction fn;
          processMap_.TryGetValue(msg.Name, out fn);
          if (fn == null) {
            TProtocolUtil.Skip(iprot, TType.Struct);
            iprot.ReadMessageEnd();
            TApplicationException x = new TApplicationException (TApplicationException.ExceptionType.UnknownMethod, "Invalid method name: '" + msg.Name + "'");
            oprot.WriteMessageBegin(new TMessage(msg.Name, TMessageType.Exception, msg.SeqID));
            x.Write(oprot);
            oprot.WriteMessageEnd();
            oprot.Transport.Flush();
            return true;
          }
          fn(msg.SeqID, iprot, oprot);
        }
        catch (IOException)
        {
          return false;
        }
        return true;
      }

      public void Ping_Process(int seqid, TProtocol iprot, TProtocol oprot)
      {
        Ping_args args = new Ping_args();
        args.Read(iprot);
        iprot.ReadMessageEnd();
        Ping_result result = new Ping_result();
        result.Success = iface_.Ping();
        oprot.WriteMessageBegin(new TMessage("Ping", TMessageType.Reply, seqid)); 
        result.Write(oprot);
        oprot.WriteMessageEnd();
        oprot.Transport.Flush();
      }

      public void GetUniqueId_Process(int seqid, TProtocol iprot, TProtocol oprot)
      {
        GetUniqueId_args args = new GetUniqueId_args();
        args.Read(iprot);
        iprot.ReadMessageEnd();
        GetUniqueId_result result = new GetUniqueId_result();
        result.Success = iface_.GetUniqueId(args.MinerInfo);
        oprot.WriteMessageBegin(new TMessage("GetUniqueId", TMessageType.Reply, seqid)); 
        result.Write(oprot);
        oprot.WriteMessageEnd();
        oprot.Transport.Flush();
      }

      public void GetSN_Process(int seqid, TProtocol iprot, TProtocol oprot)
      {
        GetSN_args args = new GetSN_args();
        args.Read(iprot);
        iprot.ReadMessageEnd();
        GetSN_result result = new GetSN_result();
        result.Success = iface_.GetSN(args.MinerInfo);
        oprot.WriteMessageBegin(new TMessage("GetSN", TMessageType.Reply, seqid)); 
        result.Write(oprot);
        oprot.WriteMessageEnd();
        oprot.Transport.Flush();
      }

      public void QueryMaintenanceTask_Process(int seqid, TProtocol iprot, TProtocol oprot)
      {
        QueryMaintenanceTask_args args = new QueryMaintenanceTask_args();
        args.Read(iprot);
        iprot.ReadMessageEnd();
        QueryMaintenanceTask_result result = new QueryMaintenanceTask_result();
        result.Success = iface_.QueryMaintenanceTask(args.UniqueId, args.Version, args.Key);
        oprot.WriteMessageBegin(new TMessage("QueryMaintenanceTask", TMessageType.Reply, seqid)); 
        result.Write(oprot);
        oprot.WriteMessageEnd();
        oprot.Transport.Flush();
      }

      public void SubmitHostStatus_Process(int seqid, TProtocol iprot, TProtocol oprot)
      {
        SubmitHostStatus_args args = new SubmitHostStatus_args();
        args.Read(iprot);
        iprot.ReadMessageEnd();
        SubmitHostStatus_result result = new SubmitHostStatus_result();
        iface_.SubmitHostStatus(args.Status);
        oprot.WriteMessageBegin(new TMessage("SubmitHostStatus", TMessageType.Reply, seqid)); 
        result.Write(oprot);
        oprot.WriteMessageEnd();
        oprot.Transport.Flush();
      }

    }


    #if !SILVERLIGHT
    [Serializable]
    #endif
    public partial class Ping_args : TBase
    {

      public Ping_args() {
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
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
      }

      public void Write(TProtocol oprot) {
        TStruct struc = new TStruct("Ping_args");
        oprot.WriteStructBegin(struc);
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }

      public override string ToString() {
        StringBuilder __sb = new StringBuilder("Ping_args(");
        __sb.Append(")");
        return __sb.ToString();
      }

    }


    #if !SILVERLIGHT
    [Serializable]
    #endif
    public partial class Ping_result : TBase
    {
      private string _success;

      public string Success
      {
        get
        {
          return _success;
        }
        set
        {
          __isset.success = true;
          this._success = value;
        }
      }


      public Isset __isset;
      #if !SILVERLIGHT
      [Serializable]
      #endif
      public struct Isset {
        public bool success;
      }

      public Ping_result() {
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
            case 0:
              if (field.Type == TType.String) {
                Success = iprot.ReadString();
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
        TStruct struc = new TStruct("Ping_result");
        oprot.WriteStructBegin(struc);
        TField field = new TField();

        if (this.__isset.success) {
          if (Success != null) {
            field.Name = "Success";
            field.Type = TType.String;
            field.ID = 0;
            oprot.WriteFieldBegin(field);
            oprot.WriteString(Success);
            oprot.WriteFieldEnd();
          }
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }

      public override string ToString() {
        StringBuilder __sb = new StringBuilder("Ping_result(");
        bool __first = true;
        if (Success != null && __isset.success) {
          if(!__first) { __sb.Append(", "); }
          __first = false;
          __sb.Append("Success: ");
          __sb.Append(Success);
        }
        __sb.Append(")");
        return __sb.ToString();
      }

    }


    #if !SILVERLIGHT
    [Serializable]
    #endif
    public partial class GetUniqueId_args : TBase
    {
      private MinerInfo _minerInfo;

      public MinerInfo MinerInfo
      {
        get
        {
          return _minerInfo;
        }
        set
        {
          __isset.minerInfo = true;
          this._minerInfo = value;
        }
      }


      public Isset __isset;
      #if !SILVERLIGHT
      [Serializable]
      #endif
      public struct Isset {
        public bool minerInfo;
      }

      public GetUniqueId_args() {
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
              if (field.Type == TType.Struct) {
                MinerInfo = new MinerInfo();
                MinerInfo.Read(iprot);
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
        TStruct struc = new TStruct("GetUniqueId_args");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (MinerInfo != null && __isset.minerInfo) {
          field.Name = "minerInfo";
          field.Type = TType.Struct;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          MinerInfo.Write(oprot);
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }

      public override string ToString() {
        StringBuilder __sb = new StringBuilder("GetUniqueId_args(");
        bool __first = true;
        if (MinerInfo != null && __isset.minerInfo) {
          if(!__first) { __sb.Append(", "); }
          __first = false;
          __sb.Append("MinerInfo: ");
          __sb.Append(MinerInfo== null ? "<null>" : MinerInfo.ToString());
        }
        __sb.Append(")");
        return __sb.ToString();
      }

    }


    #if !SILVERLIGHT
    [Serializable]
    #endif
    public partial class GetUniqueId_result : TBase
    {
      private long _success;

      public long Success
      {
        get
        {
          return _success;
        }
        set
        {
          __isset.success = true;
          this._success = value;
        }
      }


      public Isset __isset;
      #if !SILVERLIGHT
      [Serializable]
      #endif
      public struct Isset {
        public bool success;
      }

      public GetUniqueId_result() {
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
            case 0:
              if (field.Type == TType.I64) {
                Success = iprot.ReadI64();
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
        TStruct struc = new TStruct("GetUniqueId_result");
        oprot.WriteStructBegin(struc);
        TField field = new TField();

        if (this.__isset.success) {
          field.Name = "Success";
          field.Type = TType.I64;
          field.ID = 0;
          oprot.WriteFieldBegin(field);
          oprot.WriteI64(Success);
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }

      public override string ToString() {
        StringBuilder __sb = new StringBuilder("GetUniqueId_result(");
        bool __first = true;
        if (__isset.success) {
          if(!__first) { __sb.Append(", "); }
          __first = false;
          __sb.Append("Success: ");
          __sb.Append(Success);
        }
        __sb.Append(")");
        return __sb.ToString();
      }

    }


    #if !SILVERLIGHT
    [Serializable]
    #endif
    public partial class GetSN_args : TBase
    {
      private MinerInfo _minerInfo;

      public MinerInfo MinerInfo
      {
        get
        {
          return _minerInfo;
        }
        set
        {
          __isset.minerInfo = true;
          this._minerInfo = value;
        }
      }


      public Isset __isset;
      #if !SILVERLIGHT
      [Serializable]
      #endif
      public struct Isset {
        public bool minerInfo;
      }

      public GetSN_args() {
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
              if (field.Type == TType.Struct) {
                MinerInfo = new MinerInfo();
                MinerInfo.Read(iprot);
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
        TStruct struc = new TStruct("GetSN_args");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (MinerInfo != null && __isset.minerInfo) {
          field.Name = "minerInfo";
          field.Type = TType.Struct;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          MinerInfo.Write(oprot);
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }

      public override string ToString() {
        StringBuilder __sb = new StringBuilder("GetSN_args(");
        bool __first = true;
        if (MinerInfo != null && __isset.minerInfo) {
          if(!__first) { __sb.Append(", "); }
          __first = false;
          __sb.Append("MinerInfo: ");
          __sb.Append(MinerInfo== null ? "<null>" : MinerInfo.ToString());
        }
        __sb.Append(")");
        return __sb.ToString();
      }

    }


    #if !SILVERLIGHT
    [Serializable]
    #endif
    public partial class GetSN_result : TBase
    {
      private string _success;

      public string Success
      {
        get
        {
          return _success;
        }
        set
        {
          __isset.success = true;
          this._success = value;
        }
      }


      public Isset __isset;
      #if !SILVERLIGHT
      [Serializable]
      #endif
      public struct Isset {
        public bool success;
      }

      public GetSN_result() {
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
            case 0:
              if (field.Type == TType.String) {
                Success = iprot.ReadString();
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
        TStruct struc = new TStruct("GetSN_result");
        oprot.WriteStructBegin(struc);
        TField field = new TField();

        if (this.__isset.success) {
          if (Success != null) {
            field.Name = "Success";
            field.Type = TType.String;
            field.ID = 0;
            oprot.WriteFieldBegin(field);
            oprot.WriteString(Success);
            oprot.WriteFieldEnd();
          }
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }

      public override string ToString() {
        StringBuilder __sb = new StringBuilder("GetSN_result(");
        bool __first = true;
        if (Success != null && __isset.success) {
          if(!__first) { __sb.Append(", "); }
          __first = false;
          __sb.Append("Success: ");
          __sb.Append(Success);
        }
        __sb.Append(")");
        return __sb.ToString();
      }

    }


    #if !SILVERLIGHT
    [Serializable]
    #endif
    public partial class QueryMaintenanceTask_args : TBase
    {
      private long _uniqueId;
      private string _version;
      private string _key;

      public long UniqueId
      {
        get
        {
          return _uniqueId;
        }
        set
        {
          __isset.uniqueId = true;
          this._uniqueId = value;
        }
      }

      public string Version
      {
        get
        {
          return _version;
        }
        set
        {
          __isset.version = true;
          this._version = value;
        }
      }

      public string Key
      {
        get
        {
          return _key;
        }
        set
        {
          __isset.key = true;
          this._key = value;
        }
      }


      public Isset __isset;
      #if !SILVERLIGHT
      [Serializable]
      #endif
      public struct Isset {
        public bool uniqueId;
        public bool version;
        public bool key;
      }

      public QueryMaintenanceTask_args() {
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
              if (field.Type == TType.I64) {
                UniqueId = iprot.ReadI64();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.String) {
                Version = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
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
        TStruct struc = new TStruct("QueryMaintenanceTask_args");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (__isset.uniqueId) {
          field.Name = "uniqueId";
          field.Type = TType.I64;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteI64(UniqueId);
          oprot.WriteFieldEnd();
        }
        if (Version != null && __isset.version) {
          field.Name = "version";
          field.Type = TType.String;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Version);
          oprot.WriteFieldEnd();
        }
        if (Key != null && __isset.key) {
          field.Name = "key";
          field.Type = TType.String;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Key);
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }

      public override string ToString() {
        StringBuilder __sb = new StringBuilder("QueryMaintenanceTask_args(");
        bool __first = true;
        if (__isset.uniqueId) {
          if(!__first) { __sb.Append(", "); }
          __first = false;
          __sb.Append("UniqueId: ");
          __sb.Append(UniqueId);
        }
        if (Version != null && __isset.version) {
          if(!__first) { __sb.Append(", "); }
          __first = false;
          __sb.Append("Version: ");
          __sb.Append(Version);
        }
        if (Key != null && __isset.key) {
          if(!__first) { __sb.Append(", "); }
          __first = false;
          __sb.Append("Key: ");
          __sb.Append(Key);
        }
        __sb.Append(")");
        return __sb.ToString();
      }

    }


    #if !SILVERLIGHT
    [Serializable]
    #endif
    public partial class QueryMaintenanceTask_result : TBase
    {
      private Maintenance _success;

      public Maintenance Success
      {
        get
        {
          return _success;
        }
        set
        {
          __isset.success = true;
          this._success = value;
        }
      }


      public Isset __isset;
      #if !SILVERLIGHT
      [Serializable]
      #endif
      public struct Isset {
        public bool success;
      }

      public QueryMaintenanceTask_result() {
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
            case 0:
              if (field.Type == TType.Struct) {
                Success = new Maintenance();
                Success.Read(iprot);
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
        TStruct struc = new TStruct("QueryMaintenanceTask_result");
        oprot.WriteStructBegin(struc);
        TField field = new TField();

        if (this.__isset.success) {
          if (Success != null) {
            field.Name = "Success";
            field.Type = TType.Struct;
            field.ID = 0;
            oprot.WriteFieldBegin(field);
            Success.Write(oprot);
            oprot.WriteFieldEnd();
          }
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }

      public override string ToString() {
        StringBuilder __sb = new StringBuilder("QueryMaintenanceTask_result(");
        bool __first = true;
        if (Success != null && __isset.success) {
          if(!__first) { __sb.Append(", "); }
          __first = false;
          __sb.Append("Success: ");
          __sb.Append(Success== null ? "<null>" : Success.ToString());
        }
        __sb.Append(")");
        return __sb.ToString();
      }

    }


    #if !SILVERLIGHT
    [Serializable]
    #endif
    public partial class SubmitHostStatus_args : TBase
    {
      private MinerHostStatus _status;

      public MinerHostStatus Status
      {
        get
        {
          return _status;
        }
        set
        {
          __isset.status = true;
          this._status = value;
        }
      }


      public Isset __isset;
      #if !SILVERLIGHT
      [Serializable]
      #endif
      public struct Isset {
        public bool status;
      }

      public SubmitHostStatus_args() {
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
              if (field.Type == TType.Struct) {
                Status = new MinerHostStatus();
                Status.Read(iprot);
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
        TStruct struc = new TStruct("SubmitHostStatus_args");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (Status != null && __isset.status) {
          field.Name = "status";
          field.Type = TType.Struct;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          Status.Write(oprot);
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }

      public override string ToString() {
        StringBuilder __sb = new StringBuilder("SubmitHostStatus_args(");
        bool __first = true;
        if (Status != null && __isset.status) {
          if(!__first) { __sb.Append(", "); }
          __first = false;
          __sb.Append("Status: ");
          __sb.Append(Status== null ? "<null>" : Status.ToString());
        }
        __sb.Append(")");
        return __sb.ToString();
      }

    }


    #if !SILVERLIGHT
    [Serializable]
    #endif
    public partial class SubmitHostStatus_result : TBase
    {

      public SubmitHostStatus_result() {
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
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
      }

      public void Write(TProtocol oprot) {
        TStruct struc = new TStruct("SubmitHostStatus_result");
        oprot.WriteStructBegin(struc);

        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }

      public override string ToString() {
        StringBuilder __sb = new StringBuilder("SubmitHostStatus_result(");
        __sb.Append(")");
        return __sb.ToString();
      }

    }

  }
}