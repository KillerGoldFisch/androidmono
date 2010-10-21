namespace java.net
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.net.ProxySelector_))]
	public abstract partial class ProxySelector : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ProxySelector()
		{
			InitJNI();
		}
		protected ProxySelector(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getDefault15972;
		public static global::java.net.ProxySelector getDefault() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.ProxySelector.staticClass, global::java.net.ProxySelector._getDefault15972)) as java.net.ProxySelector;
		}
		internal static global::MonoJavaBridge.MethodId _setDefault15973;
		public static void setDefault(java.net.ProxySelector arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.net.ProxySelector.staticClass, global::java.net.ProxySelector._setDefault15973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _select15974;
		public abstract global::java.util.List select(java.net.URI arg0);
		internal static global::MonoJavaBridge.MethodId _connectFailed15975;
		public abstract void connectFailed(java.net.URI arg0, java.net.SocketAddress arg1, java.io.IOException arg2);
		internal static global::MonoJavaBridge.MethodId _ProxySelector15976;
		public ProxySelector()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.ProxySelector.staticClass, global::java.net.ProxySelector._ProxySelector15976);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.ProxySelector.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/ProxySelector"));
			global::java.net.ProxySelector._getDefault15972 = @__env.GetStaticMethodIDNoThrow(global::java.net.ProxySelector.staticClass, "getDefault", "()Ljava/net/ProxySelector;");
			global::java.net.ProxySelector._setDefault15973 = @__env.GetStaticMethodIDNoThrow(global::java.net.ProxySelector.staticClass, "setDefault", "(Ljava/net/ProxySelector;)V");
			global::java.net.ProxySelector._select15974 = @__env.GetMethodIDNoThrow(global::java.net.ProxySelector.staticClass, "select", "(Ljava/net/URI;)Ljava/util/List;");
			global::java.net.ProxySelector._connectFailed15975 = @__env.GetMethodIDNoThrow(global::java.net.ProxySelector.staticClass, "connectFailed", "(Ljava/net/URI;Ljava/net/SocketAddress;Ljava/io/IOException;)V");
			global::java.net.ProxySelector._ProxySelector15976 = @__env.GetMethodIDNoThrow(global::java.net.ProxySelector.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.ProxySelector))]
	public sealed partial class ProxySelector_ : java.net.ProxySelector
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ProxySelector_()
		{
			InitJNI();
		}
		internal ProxySelector_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _select15977;
		public override global::java.util.List select(java.net.URI arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.ProxySelector_._select15977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.ProxySelector_.staticClass, global::java.net.ProxySelector_._select15977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _connectFailed15978;
		public override void connectFailed(java.net.URI arg0, java.net.SocketAddress arg1, java.io.IOException arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.ProxySelector_._connectFailed15978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.ProxySelector_.staticClass, global::java.net.ProxySelector_._connectFailed15978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.ProxySelector_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/ProxySelector"));
			global::java.net.ProxySelector_._select15977 = @__env.GetMethodIDNoThrow(global::java.net.ProxySelector_.staticClass, "select", "(Ljava/net/URI;)Ljava/util/List;");
			global::java.net.ProxySelector_._connectFailed15978 = @__env.GetMethodIDNoThrow(global::java.net.ProxySelector_.staticClass, "connectFailed", "(Ljava/net/URI;Ljava/net/SocketAddress;Ljava/io/IOException;)V");
		}
	}
}