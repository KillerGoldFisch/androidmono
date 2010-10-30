namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.cert.CertPathBuilderSpi_))]
	public abstract partial class CertPathBuilderSpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CertPathBuilderSpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineBuild23509;
		public abstract global::java.security.cert.CertPathBuilderResult engineBuild(java.security.cert.CertPathParameters arg0);
		internal static global::MonoJavaBridge.MethodId _CertPathBuilderSpi23510;
		public CertPathBuilderSpi() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertPathBuilderSpi.staticClass, global::java.security.cert.CertPathBuilderSpi._CertPathBuilderSpi23510);
			Init(@__env, handle);
		}
		static CertPathBuilderSpi()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertPathBuilderSpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertPathBuilderSpi"));
			global::java.security.cert.CertPathBuilderSpi._engineBuild23509 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathBuilderSpi.staticClass, "engineBuild", "(Ljava/security/cert/CertPathParameters;)Ljava/security/cert/CertPathBuilderResult;");
			global::java.security.cert.CertPathBuilderSpi._CertPathBuilderSpi23510 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathBuilderSpi.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.cert.CertPathBuilderSpi))]
	internal sealed partial class CertPathBuilderSpi_ : java.security.cert.CertPathBuilderSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CertPathBuilderSpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineBuild23511;
		public override global::java.security.cert.CertPathBuilderResult engineBuild(java.security.cert.CertPathParameters arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.cert.CertPathBuilderResult>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertPathBuilderSpi_._engineBuild23511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CertPathBuilderResult;
		}
		static CertPathBuilderSpi_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertPathBuilderSpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertPathBuilderSpi"));
			global::java.security.cert.CertPathBuilderSpi_._engineBuild23511 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathBuilderSpi_.staticClass, "engineBuild", "(Ljava/security/cert/CertPathParameters;)Ljava/security/cert/CertPathBuilderResult;");
		}
		internal static void InitJNI()
		{
		}
	}
}