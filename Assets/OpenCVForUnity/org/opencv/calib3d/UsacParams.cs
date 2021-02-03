

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Calib3dModule
{
    // C++: class UsacParams


    public class UsacParams : DisposableOpenCVObject
    {

        protected override void Dispose(bool disposing)
        {

            try
            {
                if (disposing)
                {
                }
                if (IsEnabledDispose)
                {
                    if (nativeObj != IntPtr.Zero)
                        calib3d_UsacParams_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal UsacParams(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static UsacParams __fromPtr__(IntPtr addr) { return new UsacParams(addr); }

#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void calib3d_UsacParams_delete(IntPtr nativeObj);

    }
}
