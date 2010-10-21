namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Base64 : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Base64()
		{
			InitJNI();
		}
		protected Base64(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _decode9011;
		public static byte[] decode(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(android.util.Base64.staticClass, global::android.util.Base64._decode9011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _decode9012;
		public static byte[] decode(byte[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(android.util.Base64.staticClass, global::android.util.Base64._decode9012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _decode9013;
		public static byte[] decode(byte[] arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(android.util.Base64.staticClass, global::android.util.Base64._decode9013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _encode9014;
		public static byte[] encode(byte[] arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(android.util.Base64.staticClass, global::android.util.Base64._encode9014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _encode9015;
		public static byte[] encode(byte[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(android.util.Base64.staticClass, global::android.util.Base64._encode9015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _encodeToString9016;
		public static global::java.lang.String encodeToString(byte[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.util.Base64.staticClass, global::android.util.Base64._encodeToString9016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _encodeToString9017;
		public static global::java.lang.String encodeToString(byte[] arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.util.Base64.staticClass, global::android.util.Base64._encodeToString9017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.String;
		}
		public static int DEFAULT
		{
			get
			{
				return 0;
			}
		}
		public static int NO_PADDING
		{
			get
			{
				return 1;
			}
		}
		public static int NO_WRAP
		{
			get
			{
				return 2;
			}
		}
		public static int CRLF
		{
			get
			{
				return 4;
			}
		}
		public static int URL_SAFE
		{
			get
			{
				return 8;
			}
		}
		public static int NO_CLOSE
		{
			get
			{
				return 16;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.Base64.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/Base64"));
			global::android.util.Base64._decode9011 = @__env.GetStaticMethodIDNoThrow(global::android.util.Base64.staticClass, "decode", "(Ljava/lang/String;I)[B");
			global::android.util.Base64._decode9012 = @__env.GetStaticMethodIDNoThrow(global::android.util.Base64.staticClass, "decode", "([BI)[B");
			global::android.util.Base64._decode9013 = @__env.GetStaticMethodIDNoThrow(global::android.util.Base64.staticClass, "decode", "([BIII)[B");
			global::android.util.Base64._encode9014 = @__env.GetStaticMethodIDNoThrow(global::android.util.Base64.staticClass, "encode", "([BIII)[B");
			global::android.util.Base64._encode9015 = @__env.GetStaticMethodIDNoThrow(global::android.util.Base64.staticClass, "encode", "([BI)[B");
			global::android.util.Base64._encodeToString9016 = @__env.GetStaticMethodIDNoThrow(global::android.util.Base64.staticClass, "encodeToString", "([BI)Ljava/lang/String;");
			global::android.util.Base64._encodeToString9017 = @__env.GetStaticMethodIDNoThrow(global::android.util.Base64.staticClass, "encodeToString", "([BIII)Ljava/lang/String;");
		}
	}
}