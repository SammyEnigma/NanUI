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
    
    // Role: HANDLER
    public abstract unsafe partial class CefV8ArrayBufferReleaseCallback
    {
        private static Dictionary<IntPtr, CefV8ArrayBufferReleaseCallback> _roots = new Dictionary<IntPtr, CefV8ArrayBufferReleaseCallback>();
        
        private int _refct;
        private cef_v8array_buffer_release_callback_t* _self;
        
        protected object SyncRoot { get { return this; } }
        
        internal static CefV8ArrayBufferReleaseCallback FromNativeOrNull(cef_v8array_buffer_release_callback_t* ptr)
        {
            CefV8ArrayBufferReleaseCallback value = null;
            bool found;
            lock (_roots)
            {
                found = _roots.TryGetValue((IntPtr)ptr, out value);
            }
            return found ? value : null;
        }
        
        internal static CefV8ArrayBufferReleaseCallback FromNative(cef_v8array_buffer_release_callback_t* ptr)
        {
            var value = FromNativeOrNull(ptr);
            if (value == null) throw ExceptionBuilder.ObjectNotFound();
            return value;
        }
        
        private cef_v8array_buffer_release_callback_t.add_ref_delegate _ds0;
        private cef_v8array_buffer_release_callback_t.release_delegate _ds1;
        private cef_v8array_buffer_release_callback_t.has_one_ref_delegate _ds2;
        private cef_v8array_buffer_release_callback_t.has_at_least_one_ref_delegate _ds3;
        private cef_v8array_buffer_release_callback_t.release_buffer_delegate _ds4;
        
        protected CefV8ArrayBufferReleaseCallback()
        {
            _self = cef_v8array_buffer_release_callback_t.Alloc();
        
            _ds0 = new cef_v8array_buffer_release_callback_t.add_ref_delegate(add_ref);
            _self->_base._add_ref = Marshal.GetFunctionPointerForDelegate(_ds0);
            _ds1 = new cef_v8array_buffer_release_callback_t.release_delegate(release);
            _self->_base._release = Marshal.GetFunctionPointerForDelegate(_ds1);
            _ds2 = new cef_v8array_buffer_release_callback_t.has_one_ref_delegate(has_one_ref);
            _self->_base._has_one_ref = Marshal.GetFunctionPointerForDelegate(_ds2);
            _ds3 = new cef_v8array_buffer_release_callback_t.has_at_least_one_ref_delegate(has_at_least_one_ref);
            _self->_base._has_at_least_one_ref = Marshal.GetFunctionPointerForDelegate(_ds3);
            _ds4 = new cef_v8array_buffer_release_callback_t.release_buffer_delegate(release_buffer);
            _self->_release_buffer = Marshal.GetFunctionPointerForDelegate(_ds4);
        }
        
        ~CefV8ArrayBufferReleaseCallback()
        {
            Dispose(false);
        }
        
        protected virtual void Dispose(bool disposing)
        {
            if (_self != null)
            {
                cef_v8array_buffer_release_callback_t.Free(_self);
                _self = null;
            }
        }
        
        private void add_ref(cef_v8array_buffer_release_callback_t* self)
        {
            lock (SyncRoot)
            {
                var result = ++_refct;
                if (result == 1)
                {
                    lock (_roots) { _roots.Add((IntPtr)_self, this); }
                }
            }
        }
        
        private int release(cef_v8array_buffer_release_callback_t* self)
        {
            lock (SyncRoot)
            {
                var result = --_refct;
                if (result == 0)
                {
                    lock (_roots) { _roots.Remove((IntPtr)_self); }
                    return 1;
                }
                return 0;
            }
        }
        
        private int has_one_ref(cef_v8array_buffer_release_callback_t* self)
        {
            lock (SyncRoot) { return _refct == 1 ? 1 : 0; }
        }
        
        private int has_at_least_one_ref(cef_v8array_buffer_release_callback_t* self)
        {
            lock (SyncRoot) { return _refct != 0 ? 1 : 0; }
        }
        
        internal cef_v8array_buffer_release_callback_t* ToNative()
        {
            add_ref(_self);
            return _self;
        }
        
        [Conditional("DEBUG")]
        private void CheckSelf(cef_v8array_buffer_release_callback_t* self)
        {
            if (_self != self) throw ExceptionBuilder.InvalidSelfReference();
        }
        
    }
}
