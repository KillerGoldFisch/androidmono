namespace org.apache.http.client.methods
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpOptions : org.apache.http.client.methods.HttpRequestBase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected HttpOptions(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Method
		{
			get
			{
				return getMethod();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMethod31930;
		public override global::java.lang.String getMethod()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.client.methods.HttpOptions.staticClass, global::org.apache.http.client.methods.HttpOptions._getMethod31930)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAllowedMethods31931;
		public virtual global::java.util.Set getAllowedMethods(org.apache.http.HttpResponse arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.client.methods.HttpOptions.staticClass, global::org.apache.http.client.methods.HttpOptions._getAllowedMethods31931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _HttpOptions31932;
		public HttpOptions() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.methods.HttpOptions.staticClass, global::org.apache.http.client.methods.HttpOptions._HttpOptions31932);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpOptions31933;
		public HttpOptions(java.net.URI arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.methods.HttpOptions.staticClass, global::org.apache.http.client.methods.HttpOptions._HttpOptions31933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpOptions31934;
		public HttpOptions(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.methods.HttpOptions.staticClass, global::org.apache.http.client.methods.HttpOptions._HttpOptions31934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static global::java.lang.String METHOD_NAME
		{
			get
			{
				return "OPTIONS";
			}
		}
		static HttpOptions()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.methods.HttpOptions.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/methods/HttpOptions"));
			global::org.apache.http.client.methods.HttpOptions._getMethod31930 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpOptions.staticClass, "getMethod", "()Ljava/lang/String;");
			global::org.apache.http.client.methods.HttpOptions._getAllowedMethods31931 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpOptions.staticClass, "getAllowedMethods", "(Lorg/apache/http/HttpResponse;)Ljava/util/Set;");
			global::org.apache.http.client.methods.HttpOptions._HttpOptions31932 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpOptions.staticClass, "<init>", "()V");
			global::org.apache.http.client.methods.HttpOptions._HttpOptions31933 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpOptions.staticClass, "<init>", "(Ljava/net/URI;)V");
			global::org.apache.http.client.methods.HttpOptions._HttpOptions31934 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpOptions.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}