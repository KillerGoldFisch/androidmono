namespace javax.security.auth
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.security.auth.Destroyable_))]
	public partial interface Destroyable  : global::MonoJavaBridge.IJavaObject 
	{
		void destroy();
		bool isDestroyed();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.security.auth.Destroyable))]
	internal sealed partial class Destroyable_ : java.lang.Object, Destroyable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Destroyable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _destroy30167;
		void javax.security.auth.Destroyable.destroy()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::javax.security.auth.Destroyable_._destroy30167);
		}
		internal static global::MonoJavaBridge.MethodId _isDestroyed30168;
		bool javax.security.auth.Destroyable.isDestroyed()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::javax.security.auth.Destroyable_._isDestroyed30168);
		}
		static Destroyable_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.auth.Destroyable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/auth/Destroyable"));
			global::javax.security.auth.Destroyable_._destroy30167 = @__env.GetMethodIDNoThrow(global::javax.security.auth.Destroyable_.staticClass, "destroy", "()V");
			global::javax.security.auth.Destroyable_._isDestroyed30168 = @__env.GetMethodIDNoThrow(global::javax.security.auth.Destroyable_.staticClass, "isDestroyed", "()Z");
		}
		internal static void InitJNI()
		{
		}
	}
}