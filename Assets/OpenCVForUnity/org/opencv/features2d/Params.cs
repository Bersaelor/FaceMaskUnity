

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Features2dModule
{
    // C++: class Params


    public class Params : DisposableOpenCVObject
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
                        features2d_Params_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal Params(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static Params __fromPtr__(IntPtr addr) { return new Params(addr); }

        //
        // C++:   cv::SimpleBlobDetector::Params::Params()
        //

        public Params()
        {


            nativeObj = features2d_Params_Params_10();


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::SimpleBlobDetector::Params::Params()
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_Params_Params_10();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void features2d_Params_delete(IntPtr nativeObj);

    }
}
