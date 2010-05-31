namespace android.text.style
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class LeadingMarginSpan_Standard : java.lang.Object, LeadingMarginSpan, ParcelableSpan
	{
		internal static global::java.lang.Class staticClass;
		static LeadingMarginSpan_Standard()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.style.LeadingMarginSpan_Standard), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.text.style.LeadingMarginSpan_Standard(@__env);
			}
		}
		protected LeadingMarginSpan_Standard(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel7354;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.style.LeadingMarginSpan_Standard._writeToParcel7354, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.style.LeadingMarginSpan_Standard.staticClass, global::android.text.style.LeadingMarginSpan_Standard._writeToParcel7354, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents7355;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.style.LeadingMarginSpan_Standard._describeContents7355);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.style.LeadingMarginSpan_Standard.staticClass, global::android.text.style.LeadingMarginSpan_Standard._describeContents7355);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSpanTypeId7356;
		public virtual int getSpanTypeId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.style.LeadingMarginSpan_Standard._getSpanTypeId7356);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.style.LeadingMarginSpan_Standard.staticClass, global::android.text.style.LeadingMarginSpan_Standard._getSpanTypeId7356);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLeadingMargin7357;
		public virtual int getLeadingMargin(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.style.LeadingMarginSpan_Standard._getLeadingMargin7357, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.style.LeadingMarginSpan_Standard.staticClass, global::android.text.style.LeadingMarginSpan_Standard._getLeadingMargin7357, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawLeadingMargin7358;
		public virtual void drawLeadingMargin(android.graphics.Canvas arg0, android.graphics.Paint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, java.lang.CharSequence arg7, int arg8, int arg9, bool arg10, android.text.Layout arg11) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.style.LeadingMarginSpan_Standard._drawLeadingMargin7358, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg7), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg8), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg9), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg10), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg11));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.style.LeadingMarginSpan_Standard.staticClass, global::android.text.style.LeadingMarginSpan_Standard._drawLeadingMargin7358, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg7), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg8), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg9), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg10), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg11));
		}
		internal static global::net.sf.jni4net.jni.MethodId _LeadingMarginSpan_Standard7359;
		public LeadingMarginSpan_Standard(int arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.style.LeadingMarginSpan_Standard.staticClass, global::android.text.style.LeadingMarginSpan_Standard._LeadingMarginSpan_Standard7359, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _LeadingMarginSpan_Standard7360;
		public LeadingMarginSpan_Standard(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.style.LeadingMarginSpan_Standard.staticClass, global::android.text.style.LeadingMarginSpan_Standard._LeadingMarginSpan_Standard7360, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _LeadingMarginSpan_Standard7361;
		public LeadingMarginSpan_Standard(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.style.LeadingMarginSpan_Standard.staticClass, global::android.text.style.LeadingMarginSpan_Standard._LeadingMarginSpan_Standard7361, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.style.LeadingMarginSpan_Standard.staticClass = @__class;
			global::android.text.style.LeadingMarginSpan_Standard._writeToParcel7354 = @__env.GetMethodID(global::android.text.style.LeadingMarginSpan_Standard.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.text.style.LeadingMarginSpan_Standard._describeContents7355 = @__env.GetMethodID(global::android.text.style.LeadingMarginSpan_Standard.staticClass, "describeContents", "()I");
			global::android.text.style.LeadingMarginSpan_Standard._getSpanTypeId7356 = @__env.GetMethodID(global::android.text.style.LeadingMarginSpan_Standard.staticClass, "getSpanTypeId", "()I");
			global::android.text.style.LeadingMarginSpan_Standard._getLeadingMargin7357 = @__env.GetMethodID(global::android.text.style.LeadingMarginSpan_Standard.staticClass, "getLeadingMargin", "(Z)I");
			global::android.text.style.LeadingMarginSpan_Standard._drawLeadingMargin7358 = @__env.GetMethodID(global::android.text.style.LeadingMarginSpan_Standard.staticClass, "drawLeadingMargin", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;IIIIILjava/lang/CharSequence;IIZLandroid/text/Layout;)V");
			global::android.text.style.LeadingMarginSpan_Standard._LeadingMarginSpan_Standard7359 = @__env.GetMethodID(global::android.text.style.LeadingMarginSpan_Standard.staticClass, "<init>", "(II)V");
			global::android.text.style.LeadingMarginSpan_Standard._LeadingMarginSpan_Standard7360 = @__env.GetMethodID(global::android.text.style.LeadingMarginSpan_Standard.staticClass, "<init>", "(I)V");
			global::android.text.style.LeadingMarginSpan_Standard._LeadingMarginSpan_Standard7361 = @__env.GetMethodID(global::android.text.style.LeadingMarginSpan_Standard.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
	public static class LeadingMarginSpan_StandardExtensionMethods
	{
		public static void drawLeadingMargin(this global::android.text.style.LeadingMarginSpan_Standard __this, android.graphics.Canvas arg0, android.graphics.Paint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, string arg7, int arg8, int arg9, bool arg10, android.text.Layout arg11)
		{
			__this.drawLeadingMargin(arg0, arg1, arg2, arg3, arg4, arg5, arg6, (global::java.lang.String)arg7, arg8, arg9, arg10, arg11);
		}
	}
}