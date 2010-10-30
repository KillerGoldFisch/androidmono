namespace javax.crypto.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PBEKeySpec : java.lang.Object, java.security.spec.KeySpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PBEKeySpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new char[] Password
		{
			get
			{
				return getPassword();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPassword28792;
		public virtual char[] getPassword()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.spec.PBEKeySpec.staticClass, global::javax.crypto.spec.PBEKeySpec._getPassword28792)) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _clearPassword28793;
		public virtual void clearPassword()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.spec.PBEKeySpec.staticClass, global::javax.crypto.spec.PBEKeySpec._clearPassword28793);
		}
		public new int IterationCount
		{
			get
			{
				return getIterationCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIterationCount28794;
		public virtual int getIterationCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.spec.PBEKeySpec.staticClass, global::javax.crypto.spec.PBEKeySpec._getIterationCount28794);
		}
		public new byte[] Salt
		{
			get
			{
				return getSalt();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSalt28795;
		public virtual byte[] getSalt()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.spec.PBEKeySpec.staticClass, global::javax.crypto.spec.PBEKeySpec._getSalt28795)) as byte[];
		}
		public new int KeyLength
		{
			get
			{
				return getKeyLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getKeyLength28796;
		public virtual int getKeyLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.spec.PBEKeySpec.staticClass, global::javax.crypto.spec.PBEKeySpec._getKeyLength28796);
		}
		internal static global::MonoJavaBridge.MethodId _PBEKeySpec28797;
		public PBEKeySpec(char[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.PBEKeySpec.staticClass, global::javax.crypto.spec.PBEKeySpec._PBEKeySpec28797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PBEKeySpec28798;
		public PBEKeySpec(char[] arg0, byte[] arg1, int arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.PBEKeySpec.staticClass, global::javax.crypto.spec.PBEKeySpec._PBEKeySpec28798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PBEKeySpec28799;
		public PBEKeySpec(char[] arg0, byte[] arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.PBEKeySpec.staticClass, global::javax.crypto.spec.PBEKeySpec._PBEKeySpec28799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static PBEKeySpec()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.spec.PBEKeySpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/spec/PBEKeySpec"));
			global::javax.crypto.spec.PBEKeySpec._getPassword28792 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.PBEKeySpec.staticClass, "getPassword", "()[C");
			global::javax.crypto.spec.PBEKeySpec._clearPassword28793 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.PBEKeySpec.staticClass, "clearPassword", "()V");
			global::javax.crypto.spec.PBEKeySpec._getIterationCount28794 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.PBEKeySpec.staticClass, "getIterationCount", "()I");
			global::javax.crypto.spec.PBEKeySpec._getSalt28795 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.PBEKeySpec.staticClass, "getSalt", "()[B");
			global::javax.crypto.spec.PBEKeySpec._getKeyLength28796 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.PBEKeySpec.staticClass, "getKeyLength", "()I");
			global::javax.crypto.spec.PBEKeySpec._PBEKeySpec28797 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.PBEKeySpec.staticClass, "<init>", "([C)V");
			global::javax.crypto.spec.PBEKeySpec._PBEKeySpec28798 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.PBEKeySpec.staticClass, "<init>", "([C[BII)V");
			global::javax.crypto.spec.PBEKeySpec._PBEKeySpec28799 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.PBEKeySpec.staticClass, "<init>", "([C[BI)V");
		}
		internal static void InitJNI()
		{
		}
	}
}