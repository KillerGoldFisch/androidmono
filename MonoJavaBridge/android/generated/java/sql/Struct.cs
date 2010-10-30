namespace java.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.sql.Struct_))]
	public partial interface Struct  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Object[] getAttributes();
		global::java.lang.Object[] getAttributes(java.util.Map arg0);
		global::java.lang.String getSQLTypeName();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.sql.Struct))]
	internal sealed partial class Struct_ : java.lang.Object, Struct
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Struct_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getAttributes25092;
		global::java.lang.Object[] java.sql.Struct.getAttributes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Struct_._getAttributes25092)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _getAttributes25093;
		global::java.lang.Object[] java.sql.Struct.getAttributes(java.util.Map arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Struct_._getAttributes25093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _getSQLTypeName25094;
		global::java.lang.String java.sql.Struct.getSQLTypeName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Struct_._getSQLTypeName25094)) as java.lang.String;
		}
		static Struct_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.Struct_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/Struct"));
			global::java.sql.Struct_._getAttributes25092 = @__env.GetMethodIDNoThrow(global::java.sql.Struct_.staticClass, "getAttributes", "()[Ljava/lang/Object;");
			global::java.sql.Struct_._getAttributes25093 = @__env.GetMethodIDNoThrow(global::java.sql.Struct_.staticClass, "getAttributes", "(Ljava/util/Map;)[Ljava/lang/Object;");
			global::java.sql.Struct_._getSQLTypeName25094 = @__env.GetMethodIDNoThrow(global::java.sql.Struct_.staticClass, "getSQLTypeName", "()Ljava/lang/String;");
		}
		internal static void InitJNI()
		{
		}
	}
}