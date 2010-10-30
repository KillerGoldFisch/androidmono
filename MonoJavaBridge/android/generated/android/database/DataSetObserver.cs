namespace android.database
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.database.DataSetObserver_))]
	public abstract partial class DataSetObserver : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DataSetObserver(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onChanged4601;
		public virtual void onChanged()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.DataSetObserver.staticClass, global::android.database.DataSetObserver._onChanged4601);
		}
		internal static global::MonoJavaBridge.MethodId _onInvalidated4602;
		public virtual void onInvalidated()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.DataSetObserver.staticClass, global::android.database.DataSetObserver._onInvalidated4602);
		}
		internal static global::MonoJavaBridge.MethodId _DataSetObserver4603;
		public DataSetObserver() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.DataSetObserver.staticClass, global::android.database.DataSetObserver._DataSetObserver4603);
			Init(@__env, handle);
		}
		static DataSetObserver()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.DataSetObserver.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/DataSetObserver"));
			global::android.database.DataSetObserver._onChanged4601 = @__env.GetMethodIDNoThrow(global::android.database.DataSetObserver.staticClass, "onChanged", "()V");
			global::android.database.DataSetObserver._onInvalidated4602 = @__env.GetMethodIDNoThrow(global::android.database.DataSetObserver.staticClass, "onInvalidated", "()V");
			global::android.database.DataSetObserver._DataSetObserver4603 = @__env.GetMethodIDNoThrow(global::android.database.DataSetObserver.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.database.DataSetObserver))]
	internal sealed partial class DataSetObserver_ : android.database.DataSetObserver
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DataSetObserver_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static DataSetObserver_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.DataSetObserver_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/DataSetObserver"));
		}
		internal static void InitJNI()
		{
		}
	}
}