namespace org.apache.http.impl.auth
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DigestSchemeFactory : java.lang.Object, org.apache.http.auth.AuthSchemeFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DigestSchemeFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newInstance32735;
		public virtual global::org.apache.http.auth.AuthScheme newInstance(org.apache.http.@params.HttpParams arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.auth.AuthScheme>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.auth.DigestSchemeFactory.staticClass, global::org.apache.http.impl.auth.DigestSchemeFactory._newInstance32735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.auth.AuthScheme;
		}
		internal static global::MonoJavaBridge.MethodId _DigestSchemeFactory32736;
		public DigestSchemeFactory() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.auth.DigestSchemeFactory.staticClass, global::org.apache.http.impl.auth.DigestSchemeFactory._DigestSchemeFactory32736);
			Init(@__env, handle);
		}
		static DigestSchemeFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.auth.DigestSchemeFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/auth/DigestSchemeFactory"));
			global::org.apache.http.impl.auth.DigestSchemeFactory._newInstance32735 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.DigestSchemeFactory.staticClass, "newInstance", "(Lorg/apache/http/params/HttpParams;)Lorg/apache/http/auth/AuthScheme;");
			global::org.apache.http.impl.auth.DigestSchemeFactory._DigestSchemeFactory32736 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.DigestSchemeFactory.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}