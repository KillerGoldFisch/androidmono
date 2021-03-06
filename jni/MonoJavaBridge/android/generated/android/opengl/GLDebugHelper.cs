namespace android.opengl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GLDebugHelper : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static GLDebugHelper()
		{
			InitJNI();
		}
		protected GLDebugHelper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _wrap5548;
		public static global::javax.microedition.khronos.opengles.GL wrap(javax.microedition.khronos.opengles.GL arg0, int arg1, java.io.Writer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.microedition.khronos.opengles.GL>(@__env.CallStaticObjectMethod(android.opengl.GLDebugHelper.staticClass, global::android.opengl.GLDebugHelper._wrap5548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as javax.microedition.khronos.opengles.GL;
		}
		internal static global::MonoJavaBridge.MethodId _wrap5549;
		public static global::javax.microedition.khronos.egl.EGL wrap(javax.microedition.khronos.egl.EGL arg0, int arg1, java.io.Writer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.microedition.khronos.egl.EGL>(@__env.CallStaticObjectMethod(android.opengl.GLDebugHelper.staticClass, global::android.opengl.GLDebugHelper._wrap5549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as javax.microedition.khronos.egl.EGL;
		}
		internal static global::MonoJavaBridge.MethodId _GLDebugHelper5550;
		public GLDebugHelper()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.opengl.GLDebugHelper.staticClass, global::android.opengl.GLDebugHelper._GLDebugHelper5550);
			Init(@__env, handle);
		}
		public static int CONFIG_CHECK_GL_ERROR
		{
			get
			{
				return 1;
			}
		}
		public static int CONFIG_CHECK_THREAD
		{
			get
			{
				return 2;
			}
		}
		public static int CONFIG_LOG_ARGUMENT_NAMES
		{
			get
			{
				return 4;
			}
		}
		public static int ERROR_WRONG_THREAD
		{
			get
			{
				return 28672;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.opengl.GLDebugHelper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/opengl/GLDebugHelper"));
			global::android.opengl.GLDebugHelper._wrap5548 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLDebugHelper.staticClass, "wrap", "(Ljavax/microedition/khronos/opengles/GL;ILjava/io/Writer;)Ljavax/microedition/khronos/opengles/GL;");
			global::android.opengl.GLDebugHelper._wrap5549 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLDebugHelper.staticClass, "wrap", "(Ljavax/microedition/khronos/egl/EGL;ILjava/io/Writer;)Ljavax/microedition/khronos/egl/EGL;");
			global::android.opengl.GLDebugHelper._GLDebugHelper5550 = @__env.GetMethodIDNoThrow(global::android.opengl.GLDebugHelper.staticClass, "<init>", "()V");
		}
	}
}
