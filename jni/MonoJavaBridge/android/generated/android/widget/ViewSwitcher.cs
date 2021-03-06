namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ViewSwitcher : android.widget.ViewAnimator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ViewSwitcher()
		{
			InitJNI();
		}
		protected ViewSwitcher(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.ViewSwitcher.ViewFactory_))]
		public interface ViewFactory  : global::MonoJavaBridge.IJavaObject 
		{
			global::android.view.View makeView();
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.ViewSwitcher.ViewFactory))]
		public sealed partial class ViewFactory_ : java.lang.Object, ViewFactory
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static ViewFactory_()
			{
				InitJNI();
			}
			internal ViewFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _makeView12428;
			 global::android.view.View android.widget.ViewSwitcher.ViewFactory.makeView() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ViewSwitcher.ViewFactory_._makeView12428)) as android.view.View;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ViewSwitcher.ViewFactory_.staticClass, global::android.widget.ViewSwitcher.ViewFactory_._makeView12428)) as android.view.View;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.ViewSwitcher.ViewFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ViewSwitcher$ViewFactory"));
				global::android.widget.ViewSwitcher.ViewFactory_._makeView12428 = @__env.GetMethodIDNoThrow(global::android.widget.ViewSwitcher.ViewFactory_.staticClass, "makeView", "()Landroid/view/View;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _reset12429;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewSwitcher._reset12429);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewSwitcher.staticClass, global::android.widget.ViewSwitcher._reset12429);
		}
		internal static global::MonoJavaBridge.MethodId _addView12430;
		public override void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewSwitcher._addView12430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewSwitcher.staticClass, global::android.widget.ViewSwitcher._addView12430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setFactory12431;
		public virtual void setFactory(android.widget.ViewSwitcher.ViewFactory arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewSwitcher._setFactory12431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewSwitcher.staticClass, global::android.widget.ViewSwitcher._setFactory12431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getNextView12432;
		public virtual global::android.view.View getNextView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ViewSwitcher._getNextView12432)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ViewSwitcher.staticClass, global::android.widget.ViewSwitcher._getNextView12432)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _ViewSwitcher12433;
		public ViewSwitcher(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ViewSwitcher.staticClass, global::android.widget.ViewSwitcher._ViewSwitcher12433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ViewSwitcher12434;
		public ViewSwitcher(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ViewSwitcher.staticClass, global::android.widget.ViewSwitcher._ViewSwitcher12434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ViewSwitcher.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ViewSwitcher"));
			global::android.widget.ViewSwitcher._reset12429 = @__env.GetMethodIDNoThrow(global::android.widget.ViewSwitcher.staticClass, "reset", "()V");
			global::android.widget.ViewSwitcher._addView12430 = @__env.GetMethodIDNoThrow(global::android.widget.ViewSwitcher.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V");
			global::android.widget.ViewSwitcher._setFactory12431 = @__env.GetMethodIDNoThrow(global::android.widget.ViewSwitcher.staticClass, "setFactory", "(Landroid/widget/ViewSwitcher$ViewFactory;)V");
			global::android.widget.ViewSwitcher._getNextView12432 = @__env.GetMethodIDNoThrow(global::android.widget.ViewSwitcher.staticClass, "getNextView", "()Landroid/view/View;");
			global::android.widget.ViewSwitcher._ViewSwitcher12433 = @__env.GetMethodIDNoThrow(global::android.widget.ViewSwitcher.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.ViewSwitcher._ViewSwitcher12434 = @__env.GetMethodIDNoThrow(global::android.widget.ViewSwitcher.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
