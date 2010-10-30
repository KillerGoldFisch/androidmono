namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TrustAnchor : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TrustAnchor(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString23692;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.TrustAnchor.staticClass, global::java.security.cert.TrustAnchor._toString23692)) as java.lang.String;
		}
		public new global::java.security.cert.X509Certificate TrustedCert
		{
			get
			{
				return getTrustedCert();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTrustedCert23693;
		public virtual global::java.security.cert.X509Certificate getTrustedCert()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.TrustAnchor.staticClass, global::java.security.cert.TrustAnchor._getTrustedCert23693)) as java.security.cert.X509Certificate;
		}
		public new global::javax.security.auth.x500.X500Principal CA
		{
			get
			{
				return getCA();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCA23694;
		public virtual global::javax.security.auth.x500.X500Principal getCA()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.security.auth.x500.X500Principal>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.TrustAnchor.staticClass, global::java.security.cert.TrustAnchor._getCA23694)) as javax.security.auth.x500.X500Principal;
		}
		public new global::java.lang.String CAName
		{
			get
			{
				return getCAName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCAName23695;
		public virtual global::java.lang.String getCAName()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.TrustAnchor.staticClass, global::java.security.cert.TrustAnchor._getCAName23695)) as java.lang.String;
		}
		public new global::java.security.PublicKey CAPublicKey
		{
			get
			{
				return getCAPublicKey();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCAPublicKey23696;
		public virtual global::java.security.PublicKey getCAPublicKey()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PublicKey>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.TrustAnchor.staticClass, global::java.security.cert.TrustAnchor._getCAPublicKey23696)) as java.security.PublicKey;
		}
		public new byte[] NameConstraints
		{
			get
			{
				return getNameConstraints();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNameConstraints23697;
		public virtual byte[] getNameConstraints()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.TrustAnchor.staticClass, global::java.security.cert.TrustAnchor._getNameConstraints23697)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _TrustAnchor23698;
		public TrustAnchor(java.security.cert.X509Certificate arg0, byte[] arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.TrustAnchor.staticClass, global::java.security.cert.TrustAnchor._TrustAnchor23698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TrustAnchor23699;
		public TrustAnchor(javax.security.auth.x500.X500Principal arg0, java.security.PublicKey arg1, byte[] arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.TrustAnchor.staticClass, global::java.security.cert.TrustAnchor._TrustAnchor23699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TrustAnchor23700;
		public TrustAnchor(java.lang.String arg0, java.security.PublicKey arg1, byte[] arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.TrustAnchor.staticClass, global::java.security.cert.TrustAnchor._TrustAnchor23700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static TrustAnchor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.TrustAnchor.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/TrustAnchor"));
			global::java.security.cert.TrustAnchor._toString23692 = @__env.GetMethodIDNoThrow(global::java.security.cert.TrustAnchor.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.cert.TrustAnchor._getTrustedCert23693 = @__env.GetMethodIDNoThrow(global::java.security.cert.TrustAnchor.staticClass, "getTrustedCert", "()Ljava/security/cert/X509Certificate;");
			global::java.security.cert.TrustAnchor._getCA23694 = @__env.GetMethodIDNoThrow(global::java.security.cert.TrustAnchor.staticClass, "getCA", "()Ljavax/security/auth/x500/X500Principal;");
			global::java.security.cert.TrustAnchor._getCAName23695 = @__env.GetMethodIDNoThrow(global::java.security.cert.TrustAnchor.staticClass, "getCAName", "()Ljava/lang/String;");
			global::java.security.cert.TrustAnchor._getCAPublicKey23696 = @__env.GetMethodIDNoThrow(global::java.security.cert.TrustAnchor.staticClass, "getCAPublicKey", "()Ljava/security/PublicKey;");
			global::java.security.cert.TrustAnchor._getNameConstraints23697 = @__env.GetMethodIDNoThrow(global::java.security.cert.TrustAnchor.staticClass, "getNameConstraints", "()[B");
			global::java.security.cert.TrustAnchor._TrustAnchor23698 = @__env.GetMethodIDNoThrow(global::java.security.cert.TrustAnchor.staticClass, "<init>", "(Ljava/security/cert/X509Certificate;[B)V");
			global::java.security.cert.TrustAnchor._TrustAnchor23699 = @__env.GetMethodIDNoThrow(global::java.security.cert.TrustAnchor.staticClass, "<init>", "(Ljavax/security/auth/x500/X500Principal;Ljava/security/PublicKey;[B)V");
			global::java.security.cert.TrustAnchor._TrustAnchor23700 = @__env.GetMethodIDNoThrow(global::java.security.cert.TrustAnchor.staticClass, "<init>", "(Ljava/lang/String;Ljava/security/PublicKey;[B)V");
		}
		internal static void InitJNI()
		{
		}
	}
}