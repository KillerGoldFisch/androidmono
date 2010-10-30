namespace org.apache.http.auth
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class AuthSchemeRegistry : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AuthSchemeRegistry(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _register31785;
		public void register(java.lang.String arg0, org.apache.http.auth.AuthSchemeFactory arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.auth.AuthSchemeRegistry.staticClass, global::org.apache.http.auth.AuthSchemeRegistry._register31785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.util.Map Items
		{
			set
			{
				setItems(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setItems31786;
		public void setItems(java.util.Map arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.auth.AuthSchemeRegistry.staticClass, global::org.apache.http.auth.AuthSchemeRegistry._setItems31786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregister31787;
		public void unregister(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.auth.AuthSchemeRegistry.staticClass, global::org.apache.http.auth.AuthSchemeRegistry._unregister31787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAuthScheme31788;
		public global::org.apache.http.auth.AuthScheme getAuthScheme(java.lang.String arg0, org.apache.http.@params.HttpParams arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.auth.AuthScheme>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.auth.AuthSchemeRegistry.staticClass, global::org.apache.http.auth.AuthSchemeRegistry._getAuthScheme31788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.auth.AuthScheme;
		}
		public new global::java.util.List SchemeNames
		{
			get
			{
				return getSchemeNames();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSchemeNames31789;
		public global::java.util.List getSchemeNames()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.auth.AuthSchemeRegistry.staticClass, global::org.apache.http.auth.AuthSchemeRegistry._getSchemeNames31789)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _AuthSchemeRegistry31790;
		public AuthSchemeRegistry() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.AuthSchemeRegistry.staticClass, global::org.apache.http.auth.AuthSchemeRegistry._AuthSchemeRegistry31790);
			Init(@__env, handle);
		}
		static AuthSchemeRegistry()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.auth.AuthSchemeRegistry.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/auth/AuthSchemeRegistry"));
			global::org.apache.http.auth.AuthSchemeRegistry._register31785 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthSchemeRegistry.staticClass, "register", "(Ljava/lang/String;Lorg/apache/http/auth/AuthSchemeFactory;)V");
			global::org.apache.http.auth.AuthSchemeRegistry._setItems31786 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthSchemeRegistry.staticClass, "setItems", "(Ljava/util/Map;)V");
			global::org.apache.http.auth.AuthSchemeRegistry._unregister31787 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthSchemeRegistry.staticClass, "unregister", "(Ljava/lang/String;)V");
			global::org.apache.http.auth.AuthSchemeRegistry._getAuthScheme31788 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthSchemeRegistry.staticClass, "getAuthScheme", "(Ljava/lang/String;Lorg/apache/http/params/HttpParams;)Lorg/apache/http/auth/AuthScheme;");
			global::org.apache.http.auth.AuthSchemeRegistry._getSchemeNames31789 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthSchemeRegistry.staticClass, "getSchemeNames", "()Ljava/util/List;");
			global::org.apache.http.auth.AuthSchemeRegistry._AuthSchemeRegistry31790 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthSchemeRegistry.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}