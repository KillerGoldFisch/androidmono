namespace org.apache.http.impl.cookie
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BrowserCompatSpecFactory : java.lang.Object, org.apache.http.cookie.CookieSpecFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BrowserCompatSpecFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newInstance33284;
		public virtual global::org.apache.http.cookie.CookieSpec newInstance(org.apache.http.@params.HttpParams arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.cookie.CookieSpec>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.cookie.BrowserCompatSpecFactory.staticClass, global::org.apache.http.impl.cookie.BrowserCompatSpecFactory._newInstance33284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.cookie.CookieSpec;
		}
		internal static global::MonoJavaBridge.MethodId _BrowserCompatSpecFactory33285;
		public BrowserCompatSpecFactory() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.BrowserCompatSpecFactory.staticClass, global::org.apache.http.impl.cookie.BrowserCompatSpecFactory._BrowserCompatSpecFactory33285);
			Init(@__env, handle);
		}
		static BrowserCompatSpecFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.BrowserCompatSpecFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/BrowserCompatSpecFactory"));
			global::org.apache.http.impl.cookie.BrowserCompatSpecFactory._newInstance33284 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BrowserCompatSpecFactory.staticClass, "newInstance", "(Lorg/apache/http/params/HttpParams;)Lorg/apache/http/cookie/CookieSpec;");
			global::org.apache.http.impl.cookie.BrowserCompatSpecFactory._BrowserCompatSpecFactory33285 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BrowserCompatSpecFactory.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}