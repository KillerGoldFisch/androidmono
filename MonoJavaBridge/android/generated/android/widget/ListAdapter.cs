namespace android.widget
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.ListAdapter_))]
	public partial interface ListAdapter : Adapter
	{
		bool isEnabled(int arg0);
		bool areAllItemsEnabled();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.ListAdapter))]
	internal sealed partial class ListAdapter_ : java.lang.Object, ListAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ListAdapter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isEnabled17324;
		bool android.widget.ListAdapter.isEnabled(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListAdapter_._isEnabled17324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _areAllItemsEnabled17325;
		bool android.widget.ListAdapter.areAllItemsEnabled()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListAdapter_._areAllItemsEnabled17325);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty17326;
		bool android.widget.Adapter.isEmpty()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListAdapter_._isEmpty17326);
		}
		internal static global::MonoJavaBridge.MethodId _getCount17327;
		int android.widget.Adapter.getCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ListAdapter_._getCount17327);
		}
		internal static global::MonoJavaBridge.MethodId _registerDataSetObserver17328;
		void android.widget.Adapter.registerDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListAdapter_._registerDataSetObserver17328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterDataSetObserver17329;
		void android.widget.Adapter.unregisterDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListAdapter_._unregisterDataSetObserver17329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getItem17330;
		global::java.lang.Object android.widget.Adapter.getItem(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ListAdapter_._getItem17330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getItemId17331;
		long android.widget.Adapter.getItemId(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallLongMethod(this.JvmHandle, global::android.widget.ListAdapter_._getItemId17331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasStableIds17332;
		bool android.widget.Adapter.hasStableIds()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListAdapter_._hasStableIds17332);
		}
		internal static global::MonoJavaBridge.MethodId _getView17333;
		global::android.view.View android.widget.Adapter.getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ListAdapter_._getView17333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _getItemViewType17334;
		int android.widget.Adapter.getItemViewType(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ListAdapter_._getItemViewType17334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getViewTypeCount17335;
		int android.widget.Adapter.getViewTypeCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ListAdapter_._getViewTypeCount17335);
		}
		static ListAdapter_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ListAdapter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ListAdapter"));
			global::android.widget.ListAdapter_._isEnabled17324 = @__env.GetMethodIDNoThrow(global::android.widget.ListAdapter_.staticClass, "isEnabled", "(I)Z");
			global::android.widget.ListAdapter_._areAllItemsEnabled17325 = @__env.GetMethodIDNoThrow(global::android.widget.ListAdapter_.staticClass, "areAllItemsEnabled", "()Z");
			global::android.widget.ListAdapter_._isEmpty17326 = @__env.GetMethodIDNoThrow(global::android.widget.ListAdapter_.staticClass, "isEmpty", "()Z");
			global::android.widget.ListAdapter_._getCount17327 = @__env.GetMethodIDNoThrow(global::android.widget.ListAdapter_.staticClass, "getCount", "()I");
			global::android.widget.ListAdapter_._registerDataSetObserver17328 = @__env.GetMethodIDNoThrow(global::android.widget.ListAdapter_.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.widget.ListAdapter_._unregisterDataSetObserver17329 = @__env.GetMethodIDNoThrow(global::android.widget.ListAdapter_.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.widget.ListAdapter_._getItem17330 = @__env.GetMethodIDNoThrow(global::android.widget.ListAdapter_.staticClass, "getItem", "(I)Ljava/lang/Object;");
			global::android.widget.ListAdapter_._getItemId17331 = @__env.GetMethodIDNoThrow(global::android.widget.ListAdapter_.staticClass, "getItemId", "(I)J");
			global::android.widget.ListAdapter_._hasStableIds17332 = @__env.GetMethodIDNoThrow(global::android.widget.ListAdapter_.staticClass, "hasStableIds", "()Z");
			global::android.widget.ListAdapter_._getView17333 = @__env.GetMethodIDNoThrow(global::android.widget.ListAdapter_.staticClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.ListAdapter_._getItemViewType17334 = @__env.GetMethodIDNoThrow(global::android.widget.ListAdapter_.staticClass, "getItemViewType", "(I)I");
			global::android.widget.ListAdapter_._getViewTypeCount17335 = @__env.GetMethodIDNoThrow(global::android.widget.ListAdapter_.staticClass, "getViewTypeCount", "()I");
		}
		internal static void InitJNI()
		{
		}
	}
}