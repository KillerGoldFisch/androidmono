namespace android.app.admin
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class DeviceAdminInfo : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DeviceAdminInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString2232;
		public sealed override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.admin.DeviceAdminInfo.staticClass, global::android.app.admin.DeviceAdminInfo._toString2232)) as java.lang.String;
		}
		public new global::java.lang.String PackageName
		{
			get
			{
				return getPackageName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPackageName2233;
		public global::java.lang.String getPackageName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.admin.DeviceAdminInfo.staticClass, global::android.app.admin.DeviceAdminInfo._getPackageName2233)) as java.lang.String;
		}
		public new global::android.content.ComponentName Component
		{
			get
			{
				return getComponent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getComponent2234;
		public global::android.content.ComponentName getComponent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.ComponentName>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.admin.DeviceAdminInfo.staticClass, global::android.app.admin.DeviceAdminInfo._getComponent2234)) as android.content.ComponentName;
		}
		internal static global::MonoJavaBridge.MethodId _dump2235;
		public void dump(android.util.Printer arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.admin.DeviceAdminInfo.staticClass, global::android.app.admin.DeviceAdminInfo._dump2235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void dump(global::android.util.PrinterDelegate arg0, java.lang.String arg1)
		{
			dump((global::android.util.PrinterDelegateWrapper)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel2236;
		public void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.admin.DeviceAdminInfo.staticClass, global::android.app.admin.DeviceAdminInfo._writeToParcel2236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents2237;
		public int describeContents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.admin.DeviceAdminInfo.staticClass, global::android.app.admin.DeviceAdminInfo._describeContents2237);
		}
		public new global::android.content.pm.ActivityInfo ActivityInfo
		{
			get
			{
				return getActivityInfo();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getActivityInfo2238;
		public global::android.content.pm.ActivityInfo getActivityInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.admin.DeviceAdminInfo.staticClass, global::android.app.admin.DeviceAdminInfo._getActivityInfo2238)) as android.content.pm.ActivityInfo;
		}
		internal static global::MonoJavaBridge.MethodId _loadDescription2239;
		public global::java.lang.CharSequence loadDescription(android.content.pm.PackageManager arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.admin.DeviceAdminInfo.staticClass, global::android.app.admin.DeviceAdminInfo._loadDescription2239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _loadLabel2240;
		public global::java.lang.CharSequence loadLabel(android.content.pm.PackageManager arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.admin.DeviceAdminInfo.staticClass, global::android.app.admin.DeviceAdminInfo._loadLabel2240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _loadIcon2241;
		public global::android.graphics.drawable.Drawable loadIcon(android.content.pm.PackageManager arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.admin.DeviceAdminInfo.staticClass, global::android.app.admin.DeviceAdminInfo._loadIcon2241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _isVisible2242;
		public bool isVisible()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.admin.DeviceAdminInfo.staticClass, global::android.app.admin.DeviceAdminInfo._isVisible2242);
		}
		public new global::java.lang.String ReceiverName
		{
			get
			{
				return getReceiverName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getReceiverName2243;
		public global::java.lang.String getReceiverName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.admin.DeviceAdminInfo.staticClass, global::android.app.admin.DeviceAdminInfo._getReceiverName2243)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _usesPolicy2244;
		public bool usesPolicy(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.admin.DeviceAdminInfo.staticClass, global::android.app.admin.DeviceAdminInfo._usesPolicy2244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTagForPolicy2245;
		public global::java.lang.String getTagForPolicy(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.admin.DeviceAdminInfo.staticClass, global::android.app.admin.DeviceAdminInfo._getTagForPolicy2245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _DeviceAdminInfo2246;
		public DeviceAdminInfo(android.content.Context arg0, android.content.pm.ResolveInfo arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.admin.DeviceAdminInfo.staticClass, global::android.app.admin.DeviceAdminInfo._DeviceAdminInfo2246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		public static int USES_POLICY_LIMIT_PASSWORD
		{
			get
			{
				return 0;
			}
		}
		public static int USES_POLICY_WATCH_LOGIN
		{
			get
			{
				return 1;
			}
		}
		public static int USES_POLICY_RESET_PASSWORD
		{
			get
			{
				return 2;
			}
		}
		public static int USES_POLICY_FORCE_LOCK
		{
			get
			{
				return 3;
			}
		}
		public static int USES_POLICY_WIPE_DATA
		{
			get
			{
				return 4;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR2252;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.app.admin.DeviceAdminInfo.staticClass, _CREATOR2252)) as android.os.Parcelable_Creator;
			}
		}
		static DeviceAdminInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.admin.DeviceAdminInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/admin/DeviceAdminInfo"));
			global::android.app.admin.DeviceAdminInfo._toString2232 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.app.admin.DeviceAdminInfo._getPackageName2233 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminInfo.staticClass, "getPackageName", "()Ljava/lang/String;");
			global::android.app.admin.DeviceAdminInfo._getComponent2234 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminInfo.staticClass, "getComponent", "()Landroid/content/ComponentName;");
			global::android.app.admin.DeviceAdminInfo._dump2235 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminInfo.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.app.admin.DeviceAdminInfo._writeToParcel2236 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.app.admin.DeviceAdminInfo._describeContents2237 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminInfo.staticClass, "describeContents", "()I");
			global::android.app.admin.DeviceAdminInfo._getActivityInfo2238 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminInfo.staticClass, "getActivityInfo", "()Landroid/content/pm/ActivityInfo;");
			global::android.app.admin.DeviceAdminInfo._loadDescription2239 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminInfo.staticClass, "loadDescription", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;");
			global::android.app.admin.DeviceAdminInfo._loadLabel2240 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminInfo.staticClass, "loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;");
			global::android.app.admin.DeviceAdminInfo._loadIcon2241 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminInfo.staticClass, "loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;");
			global::android.app.admin.DeviceAdminInfo._isVisible2242 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminInfo.staticClass, "isVisible", "()Z");
			global::android.app.admin.DeviceAdminInfo._getReceiverName2243 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminInfo.staticClass, "getReceiverName", "()Ljava/lang/String;");
			global::android.app.admin.DeviceAdminInfo._usesPolicy2244 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminInfo.staticClass, "usesPolicy", "(I)Z");
			global::android.app.admin.DeviceAdminInfo._getTagForPolicy2245 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminInfo.staticClass, "getTagForPolicy", "(I)Ljava/lang/String;");
			global::android.app.admin.DeviceAdminInfo._DeviceAdminInfo2246 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminInfo.staticClass, "<init>", "(Landroid/content/Context;Landroid/content/pm/ResolveInfo;)V");
			global::android.app.admin.DeviceAdminInfo._CREATOR2252 = @__env.GetStaticFieldIDNoThrow(global::android.app.admin.DeviceAdminInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}