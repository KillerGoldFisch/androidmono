namespace org.apache.http.impl.cookie
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicExpiresHandler : org.apache.http.impl.cookie.AbstractCookieAttributeHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BasicExpiresHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parse33257;
		public override void parse(org.apache.http.cookie.SetCookie arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.cookie.BasicExpiresHandler.staticClass, global::org.apache.http.impl.cookie.BasicExpiresHandler._parse33257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _BasicExpiresHandler33258;
		public BasicExpiresHandler(java.lang.String[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.BasicExpiresHandler.staticClass, global::org.apache.http.impl.cookie.BasicExpiresHandler._BasicExpiresHandler33258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static BasicExpiresHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.BasicExpiresHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/BasicExpiresHandler"));
			global::org.apache.http.impl.cookie.BasicExpiresHandler._parse33257 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicExpiresHandler.staticClass, "parse", "(Lorg/apache/http/cookie/SetCookie;Ljava/lang/String;)V");
			global::org.apache.http.impl.cookie.BasicExpiresHandler._BasicExpiresHandler33258 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicExpiresHandler.staticClass, "<init>", "([Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}