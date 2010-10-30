namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.ConnectionReuseStrategy_))]
	public partial interface ConnectionReuseStrategy  : global::MonoJavaBridge.IJavaObject 
	{
		bool keepAlive(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.ConnectionReuseStrategy))]
	internal sealed partial class ConnectionReuseStrategy_ : java.lang.Object, ConnectionReuseStrategy
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ConnectionReuseStrategy_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _keepAlive31491;
		bool org.apache.http.ConnectionReuseStrategy.keepAlive(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.ConnectionReuseStrategy_._keepAlive31491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static ConnectionReuseStrategy_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.ConnectionReuseStrategy_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/ConnectionReuseStrategy"));
			global::org.apache.http.ConnectionReuseStrategy_._keepAlive31491 = @__env.GetMethodIDNoThrow(global::org.apache.http.ConnectionReuseStrategy_.staticClass, "keepAlive", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Z");
		}
		internal static void InitJNI()
		{
		}
	}
}