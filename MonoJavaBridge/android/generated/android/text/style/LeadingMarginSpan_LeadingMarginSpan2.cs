namespace android.text.style
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.style.LeadingMarginSpan_LeadingMarginSpan2_))]
	public partial interface LeadingMarginSpan_LeadingMarginSpan2 : LeadingMarginSpan, WrapTogetherSpan
	{
		int getLeadingMarginLineCount();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.style.LeadingMarginSpan_LeadingMarginSpan2))]
	internal sealed partial class LeadingMarginSpan_LeadingMarginSpan2_ : java.lang.Object, LeadingMarginSpan_LeadingMarginSpan2
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal LeadingMarginSpan_LeadingMarginSpan2_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getLeadingMarginLineCount13508;
		int android.text.style.LeadingMarginSpan_LeadingMarginSpan2.getLeadingMarginLineCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.LeadingMarginSpan_LeadingMarginSpan2_._getLeadingMarginLineCount13508);
		}
		internal static global::MonoJavaBridge.MethodId _getLeadingMargin13509;
		int android.text.style.LeadingMarginSpan.getLeadingMargin(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.LeadingMarginSpan_LeadingMarginSpan2_._getLeadingMargin13509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawLeadingMargin13510;
		void android.text.style.LeadingMarginSpan.drawLeadingMargin(android.graphics.Canvas arg0, android.graphics.Paint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, java.lang.CharSequence arg7, int arg8, int arg9, bool arg10, android.text.Layout arg11)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.LeadingMarginSpan_LeadingMarginSpan2_._drawLeadingMargin13510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg11));
		}
		static LeadingMarginSpan_LeadingMarginSpan2_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.LeadingMarginSpan_LeadingMarginSpan2_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/LeadingMarginSpan$LeadingMarginSpan2"));
			global::android.text.style.LeadingMarginSpan_LeadingMarginSpan2_._getLeadingMarginLineCount13508 = @__env.GetMethodIDNoThrow(global::android.text.style.LeadingMarginSpan_LeadingMarginSpan2_.staticClass, "getLeadingMarginLineCount", "()I");
			global::android.text.style.LeadingMarginSpan_LeadingMarginSpan2_._getLeadingMargin13509 = @__env.GetMethodIDNoThrow(global::android.text.style.LeadingMarginSpan_LeadingMarginSpan2_.staticClass, "getLeadingMargin", "(Z)I");
			global::android.text.style.LeadingMarginSpan_LeadingMarginSpan2_._drawLeadingMargin13510 = @__env.GetMethodIDNoThrow(global::android.text.style.LeadingMarginSpan_LeadingMarginSpan2_.staticClass, "drawLeadingMargin", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;IIIIILjava/lang/CharSequence;IIZLandroid/text/Layout;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}