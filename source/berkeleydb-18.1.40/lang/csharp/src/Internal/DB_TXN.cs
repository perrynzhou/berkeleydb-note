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

internal class DB_TXN : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal DB_TXN(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(DB_TXN obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~DB_TXN() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libdb_csharpPINVOKE.delete_DB_TXN(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

	internal int get_name(out string name) {
		int ret;
		IntPtr namep;
		ret = get_name(out namep);		
		name = Marshal.PtrToStringAnsi(namep);		
		return ret;
	}	

  internal int abort() {
		int ret;
		ret = libdb_csharpPINVOKE.DB_TXN_abort(swigCPtr);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal bool is_commit_token_enabled() {
		int ret;
		ret = libdb_csharpPINVOKE.DB_TXN_is_commit_token_enabled(swigCPtr);
		return (ret > 0 ? true : false);
	}

  internal int set_commit_token(DB_TXN_TOKEN token) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_TXN_set_commit_token(swigCPtr, DB_TXN_TOKEN.getCPtr(token));
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int commit(uint flags) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_TXN_commit(swigCPtr, flags);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int discard(uint flags) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_TXN_discard(swigCPtr, flags);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal uint id() {
    uint ret = libdb_csharpPINVOKE.DB_TXN_id(swigCPtr);
    return ret;
  }

  internal int prepare(byte[] globalID) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_TXN_prepare(swigCPtr, globalID);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int get_name(out IntPtr name) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_TXN_get_name(swigCPtr, out name);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int set_name(string name) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_TXN_set_name(swigCPtr, name);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int get_priority(ref uint priorityp) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_TXN_get_priority(swigCPtr, ref priorityp);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int set_priority(uint priority) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_TXN_set_priority(swigCPtr, priority);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int set_timeout(uint timeout, uint flags) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_TXN_set_timeout(swigCPtr, timeout, flags);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal DB_TXN() : this(libdb_csharpPINVOKE.new_DB_TXN(), true) {
  }

}

}
