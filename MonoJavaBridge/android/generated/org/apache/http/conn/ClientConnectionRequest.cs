namespace org.apache.http.conn
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.conn.ClientConnectionRequest_))]
	public partial interface ClientConnectionRequest  : global::MonoJavaBridge.IJavaObject 
	{
		global::org.apache.http.conn.ManagedClientConnection getConnection(long arg0, java.util.concurrent.TimeUnit arg1);
		void abortRequest();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.conn.ClientConnectionRequest))]
	internal sealed partial class ClientConnectionRequest_ : java.lang.Object, ClientConnectionRequest
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ClientConnectionRequest_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getConnection32086;
		global::org.apache.http.conn.ManagedClientConnection org.apache.http.conn.ClientConnectionRequest.getConnection(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ManagedClientConnection>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.ClientConnectionRequest_._getConnection32086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.conn.ManagedClientConnection;
		}
		internal static global::MonoJavaBridge.MethodId _abortRequest32087;
		void org.apache.http.conn.ClientConnectionRequest.abortRequest()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ClientConnectionRequest_._abortRequest32087);
		}
		static ClientConnectionRequest_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.ClientConnectionRequest_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/ClientConnectionRequest"));
			global::org.apache.http.conn.ClientConnectionRequest_._getConnection32086 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ClientConnectionRequest_.staticClass, "getConnection", "(JLjava/util/concurrent/TimeUnit;)Lorg/apache/http/conn/ManagedClientConnection;");
			global::org.apache.http.conn.ClientConnectionRequest_._abortRequest32087 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ClientConnectionRequest_.staticClass, "abortRequest", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}