namespace java.lang.reflect
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.lang.reflect.WildcardType_))]
	public partial interface WildcardType : Type
	{
		global::java.lang.reflect.Type[] getUpperBounds();
		global::java.lang.reflect.Type[] getLowerBounds();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.reflect.WildcardType))]
	internal sealed partial class WildcardType_ : java.lang.Object, WildcardType
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal WildcardType_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getUpperBounds21162;
		global::java.lang.reflect.Type[] java.lang.reflect.WildcardType.getUpperBounds()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Type>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.WildcardType_._getUpperBounds21162)) as java.lang.reflect.Type[];
		}
		internal static global::MonoJavaBridge.MethodId _getLowerBounds21163;
		global::java.lang.reflect.Type[] java.lang.reflect.WildcardType.getLowerBounds()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Type>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.WildcardType_._getLowerBounds21163)) as java.lang.reflect.Type[];
		}
		static WildcardType_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.WildcardType_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/WildcardType"));
			global::java.lang.reflect.WildcardType_._getUpperBounds21162 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.WildcardType_.staticClass, "getUpperBounds", "()[Ljava/lang/reflect/Type;");
			global::java.lang.reflect.WildcardType_._getLowerBounds21163 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.WildcardType_.staticClass, "getLowerBounds", "()[Ljava/lang/reflect/Type;");
		}
		internal static void InitJNI()
		{
		}
	}
}