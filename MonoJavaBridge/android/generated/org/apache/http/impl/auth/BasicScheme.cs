namespace org.apache.http.impl.auth
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicScheme : org.apache.http.impl.auth.RFC2617Scheme
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BasicScheme(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String SchemeName
		{
			get
			{
				return getSchemeName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSchemeName32718;
		public override global::java.lang.String getSchemeName()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.auth.BasicScheme.staticClass, global::org.apache.http.impl.auth.BasicScheme._getSchemeName32718)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _processChallenge32719;
		public override void processChallenge(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.auth.BasicScheme.staticClass, global::org.apache.http.impl.auth.BasicScheme._processChallenge32719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isConnectionBased32720;
		public override bool isConnectionBased()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.auth.BasicScheme.staticClass, global::org.apache.http.impl.auth.BasicScheme._isConnectionBased32720);
		}
		internal static global::MonoJavaBridge.MethodId _isComplete32721;
		public override bool isComplete()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.auth.BasicScheme.staticClass, global::org.apache.http.impl.auth.BasicScheme._isComplete32721);
		}
		internal static global::MonoJavaBridge.MethodId _authenticate32722;
		public override global::org.apache.http.Header authenticate(org.apache.http.auth.Credentials arg0, org.apache.http.HttpRequest arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.auth.BasicScheme.staticClass, global::org.apache.http.impl.auth.BasicScheme._authenticate32722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _authenticate32723;
		public static global::org.apache.http.Header authenticate(org.apache.http.auth.Credentials arg0, java.lang.String arg1, bool arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallStaticObjectMethod(org.apache.http.impl.auth.BasicScheme.staticClass, global::org.apache.http.impl.auth.BasicScheme._authenticate32723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _BasicScheme32724;
		public BasicScheme() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.auth.BasicScheme.staticClass, global::org.apache.http.impl.auth.BasicScheme._BasicScheme32724);
			Init(@__env, handle);
		}
		static BasicScheme()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.auth.BasicScheme.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/auth/BasicScheme"));
			global::org.apache.http.impl.auth.BasicScheme._getSchemeName32718 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.BasicScheme.staticClass, "getSchemeName", "()Ljava/lang/String;");
			global::org.apache.http.impl.auth.BasicScheme._processChallenge32719 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.BasicScheme.staticClass, "processChallenge", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.impl.auth.BasicScheme._isConnectionBased32720 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.BasicScheme.staticClass, "isConnectionBased", "()Z");
			global::org.apache.http.impl.auth.BasicScheme._isComplete32721 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.BasicScheme.staticClass, "isComplete", "()Z");
			global::org.apache.http.impl.auth.BasicScheme._authenticate32722 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.BasicScheme.staticClass, "authenticate", "(Lorg/apache/http/auth/Credentials;Lorg/apache/http/HttpRequest;)Lorg/apache/http/Header;");
			global::org.apache.http.impl.auth.BasicScheme._authenticate32723 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.impl.auth.BasicScheme.staticClass, "authenticate", "(Lorg/apache/http/auth/Credentials;Ljava/lang/String;Z)Lorg/apache/http/Header;");
			global::org.apache.http.impl.auth.BasicScheme._BasicScheme32724 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.BasicScheme.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}