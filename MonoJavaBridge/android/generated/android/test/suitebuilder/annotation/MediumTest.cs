namespace android.test.suitebuilder.annotation
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.test.suitebuilder.annotation.MediumTest_))]
	public partial interface MediumTest : java.lang.annotation.Annotation
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.test.suitebuilder.annotation.MediumTest))]
	internal sealed partial class MediumTest_ : java.lang.Object, MediumTest
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal MediumTest_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals12651;
		bool java.lang.annotation.Annotation.equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.MediumTest_._equals12651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString12652;
		global::java.lang.String java.lang.annotation.Annotation.toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.MediumTest_._toString12652)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode12653;
		int java.lang.annotation.Annotation.hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.MediumTest_._hashCode12653);
		}
		internal static global::MonoJavaBridge.MethodId _annotationType12654;
		global::java.lang.Class java.lang.annotation.Annotation.annotationType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.MediumTest_._annotationType12654)) as java.lang.Class;
		}
		static MediumTest_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.suitebuilder.annotation.MediumTest_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/suitebuilder/annotation/MediumTest"));
			global::android.test.suitebuilder.annotation.MediumTest_._equals12651 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.annotation.MediumTest_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.test.suitebuilder.annotation.MediumTest_._toString12652 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.annotation.MediumTest_.staticClass, "toString", "()Ljava/lang/String;");
			global::android.test.suitebuilder.annotation.MediumTest_._hashCode12653 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.annotation.MediumTest_.staticClass, "hashCode", "()I");
			global::android.test.suitebuilder.annotation.MediumTest_._annotationType12654 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.annotation.MediumTest_.staticClass, "annotationType", "()Ljava/lang/Class;");
		}
		internal static void InitJNI()
		{
		}
	}
}