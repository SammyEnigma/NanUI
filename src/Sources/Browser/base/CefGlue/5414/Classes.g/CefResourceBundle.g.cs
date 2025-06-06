//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace NetDimension.NanUI.CefGlue
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using NetDimension.NanUI.CefGlue.Interop;
    
    // Role: PROXY
    public sealed unsafe partial class CefResourceBundle : IDisposable
    {
        internal static CefResourceBundle FromNative(cef_resource_bundle_t* ptr)
        {
            return new CefResourceBundle(ptr);
        }
        
        internal static CefResourceBundle FromNativeOrNull(cef_resource_bundle_t* ptr)
        {
            if (ptr == null) return null;
            return new CefResourceBundle(ptr);
        }
        
        private cef_resource_bundle_t* _self;
        
        private CefResourceBundle(cef_resource_bundle_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");
            _self = ptr;
        }
        
        ~CefResourceBundle()
        {
            if (_self != null)
            {
                Release();
                _self = null;
            }
        }
        
        public void Dispose()
        {
            if (_self != null)
            {
                Release();
                _self = null;
            }
            GC.SuppressFinalize(this);
        }
        
        internal void AddRef()
        {
            cef_resource_bundle_t.add_ref(_self);
        }
        
        internal bool Release()
        {
            return cef_resource_bundle_t.release(_self) != 0;
        }
        
        internal bool HasOneRef
        {
            get { return cef_resource_bundle_t.has_one_ref(_self) != 0; }
        }
        
        internal bool HasAtLeastOneRef
        {
            get { return cef_resource_bundle_t.has_at_least_one_ref(_self) != 0; }
        }
        
        internal cef_resource_bundle_t* ToNative()
        {
            AddRef();
            return _self;
        }
    }
}
