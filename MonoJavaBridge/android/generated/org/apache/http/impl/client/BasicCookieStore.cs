namespace org.apache.http.impl.client
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicCookieStore : java.lang.Object, org.apache.http.client.CookieStore
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BasicCookieStore(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString32856;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.client.BasicCookieStore.staticClass, global::org.apache.http.impl.client.BasicCookieStore._toString32856)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clear32857;
		public virtual void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.client.BasicCookieStore.staticClass, global::org.apache.http.impl.client.BasicCookieStore._clear32857);
		}
		internal static global::MonoJavaBridge.MethodId _addCookie32858;
		public virtual void addCookie(org.apache.http.cookie.Cookie arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.client.BasicCookieStore.staticClass, global::org.apache.http.impl.client.BasicCookieStore._addCookie32858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.List Cookies
		{
			get
			{
				return getCookies();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCookies32859;
		public virtual global::java.util.List getCookies()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.client.BasicCookieStore.staticClass, global::org.apache.http.impl.client.BasicCookieStore._getCookies32859)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _clearExpired32860;
		public virtual bool clearExpired(java.util.Date arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.client.BasicCookieStore.staticClass, global::org.apache.http.impl.client.BasicCookieStore._clearExpired32860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addCookies32861;
		public virtual void addCookies(org.apache.http.cookie.Cookie[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.client.BasicCookieStore.staticClass, global::org.apache.http.impl.client.BasicCookieStore._addCookies32861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _BasicCookieStore32862;
		public BasicCookieStore() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.BasicCookieStore.staticClass, global::org.apache.http.impl.client.BasicCookieStore._BasicCookieStore32862);
			Init(@__env, handle);
		}
		static BasicCookieStore()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.client.BasicCookieStore.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/client/BasicCookieStore"));
			global::org.apache.http.impl.client.BasicCookieStore._toString32856 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.BasicCookieStore.staticClass, "toString", "()Ljava/lang/String;");
			global::org.apache.http.impl.client.BasicCookieStore._clear32857 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.BasicCookieStore.staticClass, "clear", "()V");
			global::org.apache.http.impl.client.BasicCookieStore._addCookie32858 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.BasicCookieStore.staticClass, "addCookie", "(Lorg/apache/http/cookie/Cookie;)V");
			global::org.apache.http.impl.client.BasicCookieStore._getCookies32859 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.BasicCookieStore.staticClass, "getCookies", "()Ljava/util/List;");
			global::org.apache.http.impl.client.BasicCookieStore._clearExpired32860 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.BasicCookieStore.staticClass, "clearExpired", "(Ljava/util/Date;)Z");
			global::org.apache.http.impl.client.BasicCookieStore._addCookies32861 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.BasicCookieStore.staticClass, "addCookies", "([Lorg/apache/http/cookie/Cookie;)V");
			global::org.apache.http.impl.client.BasicCookieStore._BasicCookieStore32862 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.BasicCookieStore.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}