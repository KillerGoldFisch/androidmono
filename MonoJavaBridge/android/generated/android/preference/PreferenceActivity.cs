namespace android.preference
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.preference.PreferenceActivity_))]
	public abstract partial class PreferenceActivity : android.app.ListActivity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PreferenceActivity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onCreate10393;
		protected override void onCreate(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.PreferenceActivity.staticClass, global::android.preference.PreferenceActivity._onCreate10393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onDestroy10394;
		protected override void onDestroy()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.PreferenceActivity.staticClass, global::android.preference.PreferenceActivity._onDestroy10394);
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState10395;
		protected override void onRestoreInstanceState(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.PreferenceActivity.staticClass, global::android.preference.PreferenceActivity._onRestoreInstanceState10395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onNewIntent10396;
		protected override void onNewIntent(android.content.Intent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.PreferenceActivity.staticClass, global::android.preference.PreferenceActivity._onNewIntent10396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState10397;
		protected override void onSaveInstanceState(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.PreferenceActivity.staticClass, global::android.preference.PreferenceActivity._onSaveInstanceState10397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onStop10398;
		protected override void onStop()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.PreferenceActivity.staticClass, global::android.preference.PreferenceActivity._onStop10398);
		}
		internal static global::MonoJavaBridge.MethodId _onContentChanged10399;
		public override void onContentChanged()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.PreferenceActivity.staticClass, global::android.preference.PreferenceActivity._onContentChanged10399);
		}
		internal static global::MonoJavaBridge.MethodId _onActivityResult10400;
		protected override void onActivityResult(int arg0, int arg1, android.content.Intent arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.PreferenceActivity.staticClass, global::android.preference.PreferenceActivity._onActivityResult10400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getPreferenceManager10401;
		public virtual global::android.preference.PreferenceManager getPreferenceManager()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.preference.PreferenceActivity.staticClass, global::android.preference.PreferenceActivity._getPreferenceManager10401)) as android.preference.PreferenceManager;
		}
		internal static global::MonoJavaBridge.MethodId _findPreference10402;
		public virtual global::android.preference.Preference findPreference(java.lang.CharSequence arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.preference.PreferenceActivity.staticClass, global::android.preference.PreferenceActivity._findPreference10402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.preference.Preference;
		}
		public android.preference.Preference findPreference(string arg0)
		{
			return findPreference((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setPreferenceScreen10403;
		public virtual void setPreferenceScreen(android.preference.PreferenceScreen arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.PreferenceActivity.staticClass, global::android.preference.PreferenceActivity._setPreferenceScreen10403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPreferenceScreen10404;
		public virtual global::android.preference.PreferenceScreen getPreferenceScreen()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.preference.PreferenceScreen>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.preference.PreferenceActivity.staticClass, global::android.preference.PreferenceActivity._getPreferenceScreen10404)) as android.preference.PreferenceScreen;
		}
		internal static global::MonoJavaBridge.MethodId _addPreferencesFromIntent10405;
		public virtual void addPreferencesFromIntent(android.content.Intent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.PreferenceActivity.staticClass, global::android.preference.PreferenceActivity._addPreferencesFromIntent10405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addPreferencesFromResource10406;
		public virtual void addPreferencesFromResource(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.PreferenceActivity.staticClass, global::android.preference.PreferenceActivity._addPreferencesFromResource10406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onPreferenceTreeClick10407;
		public virtual bool onPreferenceTreeClick(android.preference.PreferenceScreen arg0, android.preference.Preference arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.preference.PreferenceActivity.staticClass, global::android.preference.PreferenceActivity._onPreferenceTreeClick10407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _PreferenceActivity10408;
		public PreferenceActivity() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.PreferenceActivity.staticClass, global::android.preference.PreferenceActivity._PreferenceActivity10408);
			Init(@__env, handle);
		}
		static PreferenceActivity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.preference.PreferenceActivity.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/PreferenceActivity"));
			global::android.preference.PreferenceActivity._onCreate10393 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceActivity.staticClass, "onCreate", "(Landroid/os/Bundle;)V");
			global::android.preference.PreferenceActivity._onDestroy10394 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceActivity.staticClass, "onDestroy", "()V");
			global::android.preference.PreferenceActivity._onRestoreInstanceState10395 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceActivity.staticClass, "onRestoreInstanceState", "(Landroid/os/Bundle;)V");
			global::android.preference.PreferenceActivity._onNewIntent10396 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceActivity.staticClass, "onNewIntent", "(Landroid/content/Intent;)V");
			global::android.preference.PreferenceActivity._onSaveInstanceState10397 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceActivity.staticClass, "onSaveInstanceState", "(Landroid/os/Bundle;)V");
			global::android.preference.PreferenceActivity._onStop10398 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceActivity.staticClass, "onStop", "()V");
			global::android.preference.PreferenceActivity._onContentChanged10399 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceActivity.staticClass, "onContentChanged", "()V");
			global::android.preference.PreferenceActivity._onActivityResult10400 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceActivity.staticClass, "onActivityResult", "(IILandroid/content/Intent;)V");
			global::android.preference.PreferenceActivity._getPreferenceManager10401 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceActivity.staticClass, "getPreferenceManager", "()Landroid/preference/PreferenceManager;");
			global::android.preference.PreferenceActivity._findPreference10402 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceActivity.staticClass, "findPreference", "(Ljava/lang/CharSequence;)Landroid/preference/Preference;");
			global::android.preference.PreferenceActivity._setPreferenceScreen10403 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceActivity.staticClass, "setPreferenceScreen", "(Landroid/preference/PreferenceScreen;)V");
			global::android.preference.PreferenceActivity._getPreferenceScreen10404 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceActivity.staticClass, "getPreferenceScreen", "()Landroid/preference/PreferenceScreen;");
			global::android.preference.PreferenceActivity._addPreferencesFromIntent10405 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceActivity.staticClass, "addPreferencesFromIntent", "(Landroid/content/Intent;)V");
			global::android.preference.PreferenceActivity._addPreferencesFromResource10406 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceActivity.staticClass, "addPreferencesFromResource", "(I)V");
			global::android.preference.PreferenceActivity._onPreferenceTreeClick10407 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceActivity.staticClass, "onPreferenceTreeClick", "(Landroid/preference/PreferenceScreen;Landroid/preference/Preference;)Z");
			global::android.preference.PreferenceActivity._PreferenceActivity10408 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceActivity.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.preference.PreferenceActivity))]
	internal sealed partial class PreferenceActivity_ : android.preference.PreferenceActivity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal PreferenceActivity_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static PreferenceActivity_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.preference.PreferenceActivity_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/PreferenceActivity"));
		}
		internal static void InitJNI()
		{
		}
	}
}