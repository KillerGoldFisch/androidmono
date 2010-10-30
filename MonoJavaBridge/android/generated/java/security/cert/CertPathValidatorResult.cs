namespace java.security.cert
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.cert.CertPathValidatorResult_))]
	public partial interface CertPathValidatorResult : java.lang.Cloneable
	{
		global::java.lang.Object clone();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.cert.CertPathValidatorResult))]
	internal sealed partial class CertPathValidatorResult_ : java.lang.Object, CertPathValidatorResult
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CertPathValidatorResult_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone23528;
		global::java.lang.Object java.security.cert.CertPathValidatorResult.clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertPathValidatorResult_._clone23528)) as java.lang.Object;
		}
		static CertPathValidatorResult_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertPathValidatorResult_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertPathValidatorResult"));
			global::java.security.cert.CertPathValidatorResult_._clone23528 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathValidatorResult_.staticClass, "clone", "()Ljava/lang/Object;");
		}
		internal static void InitJNI()
		{
		}
	}
}