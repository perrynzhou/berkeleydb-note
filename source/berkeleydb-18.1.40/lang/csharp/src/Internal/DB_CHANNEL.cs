//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace BerkeleyDB.Internal {

using global::System;
using global::System.Runtime.InteropServices;

internal class DB_CHANNEL : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal DB_CHANNEL(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(DB_CHANNEL obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~DB_CHANNEL() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libdb_csharpPINVOKE.delete_DB_CHANNEL(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  internal int close(uint flags) {
		int ret = libdb_csharpPINVOKE.DB_CHANNEL_close(swigCPtr, flags);
		if (ret == 0)
			/* Close is a db handle destructor.  Reflect that in the wrapper class. */
			swigCPtr = new HandleRef(null, IntPtr.Zero);
		else
			DatabaseException.ThrowException(ret);
		return ret;
}

  internal int send_msg(IntPtr[] msg, uint nmsg, uint flags) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_CHANNEL_send_msg(swigCPtr, msg, nmsg, flags);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int send_request(IntPtr[] request, uint nrequest, DatabaseEntry response, uint timeout, uint flags) {
    try {
		int ret;
		ret = libdb_csharpPINVOKE.DB_CHANNEL_send_request(swigCPtr, request, nrequest, DBT.getCPtr(DatabaseEntry.getDBT(response)).Handle, timeout, flags);
		DatabaseException.ThrowException(ret);
		return ret;
} finally {
      GC.KeepAlive(response);
    }
  }

  internal int set_timeout(uint timeout) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_CHANNEL_set_timeout(swigCPtr, timeout);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal DB_CHANNEL() : this(libdb_csharpPINVOKE.new_DB_CHANNEL(), true) {
  }

}

}
