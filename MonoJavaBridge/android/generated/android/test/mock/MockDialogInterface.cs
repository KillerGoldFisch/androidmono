namespace android.test.mock
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MockDialogInterface : java.lang.Object, android.content.DialogInterface
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MockDialogInterface(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _cancel12523;
		public virtual void cancel()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.mock.MockDialogInterface.staticClass, global::android.test.mock.MockDialogInterface._cancel12523);
		}
		internal static global::MonoJavaBridge.MethodId _dismiss12524;
		public virtual void dismiss()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.mock.MockDialogInterface.staticClass, global::android.test.mock.MockDialogInterface._dismiss12524);
		}
		internal static global::MonoJavaBridge.MethodId _MockDialogInterface12525;
		public MockDialogInterface() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.mock.MockDialogInterface.staticClass, global::android.test.mock.MockDialogInterface._MockDialogInterface12525);
			Init(@__env, handle);
		}
		static MockDialogInterface()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.mock.MockDialogInterface.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/mock/MockDialogInterface"));
			global::android.test.mock.MockDialogInterface._cancel12523 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockDialogInterface.staticClass, "cancel", "()V");
			global::android.test.mock.MockDialogInterface._dismiss12524 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockDialogInterface.staticClass, "dismiss", "()V");
			global::android.test.mock.MockDialogInterface._MockDialogInterface12525 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockDialogInterface.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}