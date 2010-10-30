namespace org.xml.sax.ext
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.xml.sax.ext.LexicalHandler_))]
	public partial interface LexicalHandler  : global::MonoJavaBridge.IJavaObject 
	{
		void comment(char[] arg0, int arg1, int arg2);
		void startCDATA();
		void endCDATA();
		void startEntity(java.lang.String arg0);
		void endEntity(java.lang.String arg0);
		void startDTD(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2);
		void endDTD();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.xml.sax.ext.LexicalHandler))]
	internal sealed partial class LexicalHandler_ : java.lang.Object, LexicalHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal LexicalHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _comment35130;
		void org.xml.sax.ext.LexicalHandler.comment(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.LexicalHandler_._comment35130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _startCDATA35131;
		void org.xml.sax.ext.LexicalHandler.startCDATA()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.LexicalHandler_._startCDATA35131);
		}
		internal static global::MonoJavaBridge.MethodId _endCDATA35132;
		void org.xml.sax.ext.LexicalHandler.endCDATA()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.LexicalHandler_._endCDATA35132);
		}
		internal static global::MonoJavaBridge.MethodId _startEntity35133;
		void org.xml.sax.ext.LexicalHandler.startEntity(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.LexicalHandler_._startEntity35133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _endEntity35134;
		void org.xml.sax.ext.LexicalHandler.endEntity(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.LexicalHandler_._endEntity35134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startDTD35135;
		void org.xml.sax.ext.LexicalHandler.startDTD(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.LexicalHandler_._startDTD35135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _endDTD35136;
		void org.xml.sax.ext.LexicalHandler.endDTD()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.LexicalHandler_._endDTD35136);
		}
		static LexicalHandler_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.ext.LexicalHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/ext/LexicalHandler"));
			global::org.xml.sax.ext.LexicalHandler_._comment35130 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.LexicalHandler_.staticClass, "comment", "([CII)V");
			global::org.xml.sax.ext.LexicalHandler_._startCDATA35131 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.LexicalHandler_.staticClass, "startCDATA", "()V");
			global::org.xml.sax.ext.LexicalHandler_._endCDATA35132 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.LexicalHandler_.staticClass, "endCDATA", "()V");
			global::org.xml.sax.ext.LexicalHandler_._startEntity35133 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.LexicalHandler_.staticClass, "startEntity", "(Ljava/lang/String;)V");
			global::org.xml.sax.ext.LexicalHandler_._endEntity35134 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.LexicalHandler_.staticClass, "endEntity", "(Ljava/lang/String;)V");
			global::org.xml.sax.ext.LexicalHandler_._startDTD35135 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.LexicalHandler_.staticClass, "startDTD", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.ext.LexicalHandler_._endDTD35136 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.LexicalHandler_.staticClass, "endDTD", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}