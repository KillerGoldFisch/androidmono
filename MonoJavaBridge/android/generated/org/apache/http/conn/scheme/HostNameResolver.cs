namespace org.apache.http.conn.scheme
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.conn.scheme.HostNameResolver_))]
	public partial interface HostNameResolver  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.net.InetAddress resolve(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.conn.scheme.HostNameResolver))]
	internal sealed partial class HostNameResolver_ : java.lang.Object, HostNameResolver
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HostNameResolver_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _resolve32289;
		global::java.net.InetAddress org.apache.http.conn.scheme.HostNameResolver.resolve(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.HostNameResolver_._resolve32289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.InetAddress;
		}
		static HostNameResolver_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.scheme.HostNameResolver_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/scheme/HostNameResolver"));
			global::org.apache.http.conn.scheme.HostNameResolver_._resolve32289 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.HostNameResolver_.staticClass, "resolve", "(Ljava/lang/String;)Ljava/net/InetAddress;");
		}
		internal static void InitJNI()
		{
		}
	}
}