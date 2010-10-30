namespace javax.xml.parsers
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.parsers.DocumentBuilder_))]
	public abstract partial class DocumentBuilder : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DocumentBuilder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _reset30832;
		public virtual void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.parsers.DocumentBuilder.staticClass, global::javax.xml.parsers.DocumentBuilder._reset30832);
		}
		internal static global::MonoJavaBridge.MethodId _parse30833;
		public virtual global::org.w3c.dom.Document parse(java.io.InputStream arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.parsers.DocumentBuilder.staticClass, global::javax.xml.parsers.DocumentBuilder._parse30833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Document;
		}
		internal static global::MonoJavaBridge.MethodId _parse30834;
		public virtual global::org.w3c.dom.Document parse(java.io.InputStream arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.parsers.DocumentBuilder.staticClass, global::javax.xml.parsers.DocumentBuilder._parse30834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Document;
		}
		internal static global::MonoJavaBridge.MethodId _parse30835;
		public virtual global::org.w3c.dom.Document parse(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.parsers.DocumentBuilder.staticClass, global::javax.xml.parsers.DocumentBuilder._parse30835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Document;
		}
		internal static global::MonoJavaBridge.MethodId _parse30836;
		public virtual global::org.w3c.dom.Document parse(java.io.File arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.parsers.DocumentBuilder.staticClass, global::javax.xml.parsers.DocumentBuilder._parse30836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Document;
		}
		internal static global::MonoJavaBridge.MethodId _parse30837;
		public abstract global::org.w3c.dom.Document parse(org.xml.sax.InputSource arg0);
		internal static global::MonoJavaBridge.MethodId _setEntityResolver30838;
		public abstract void setEntityResolver(org.xml.sax.EntityResolver arg0);
		internal static global::MonoJavaBridge.MethodId _setErrorHandler30839;
		public abstract void setErrorHandler(org.xml.sax.ErrorHandler arg0);
		internal static global::MonoJavaBridge.MethodId _isNamespaceAware30840;
		public abstract bool isNamespaceAware();
		internal static global::MonoJavaBridge.MethodId _isValidating30841;
		public abstract bool isValidating();
		internal static global::MonoJavaBridge.MethodId _newDocument30842;
		public abstract global::org.w3c.dom.Document newDocument();
		internal static global::MonoJavaBridge.MethodId _getDOMImplementation30843;
		public abstract global::org.w3c.dom.DOMImplementation getDOMImplementation();
		internal static global::MonoJavaBridge.MethodId _getSchema30844;
		public virtual global::javax.xml.validation.Schema getSchema()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.parsers.DocumentBuilder.staticClass, global::javax.xml.parsers.DocumentBuilder._getSchema30844)) as javax.xml.validation.Schema;
		}
		internal static global::MonoJavaBridge.MethodId _isXIncludeAware30845;
		public virtual bool isXIncludeAware()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.parsers.DocumentBuilder.staticClass, global::javax.xml.parsers.DocumentBuilder._isXIncludeAware30845);
		}
		internal static global::MonoJavaBridge.MethodId _DocumentBuilder30846;
		protected DocumentBuilder() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.parsers.DocumentBuilder.staticClass, global::javax.xml.parsers.DocumentBuilder._DocumentBuilder30846);
			Init(@__env, handle);
		}
		static DocumentBuilder()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.parsers.DocumentBuilder.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/parsers/DocumentBuilder"));
			global::javax.xml.parsers.DocumentBuilder._reset30832 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder.staticClass, "reset", "()V");
			global::javax.xml.parsers.DocumentBuilder._parse30833 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder.staticClass, "parse", "(Ljava/io/InputStream;)Lorg/w3c/dom/Document;");
			global::javax.xml.parsers.DocumentBuilder._parse30834 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder.staticClass, "parse", "(Ljava/io/InputStream;Ljava/lang/String;)Lorg/w3c/dom/Document;");
			global::javax.xml.parsers.DocumentBuilder._parse30835 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder.staticClass, "parse", "(Ljava/lang/String;)Lorg/w3c/dom/Document;");
			global::javax.xml.parsers.DocumentBuilder._parse30836 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder.staticClass, "parse", "(Ljava/io/File;)Lorg/w3c/dom/Document;");
			global::javax.xml.parsers.DocumentBuilder._parse30837 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder.staticClass, "parse", "(Lorg/xml/sax/InputSource;)Lorg/w3c/dom/Document;");
			global::javax.xml.parsers.DocumentBuilder._setEntityResolver30838 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder.staticClass, "setEntityResolver", "(Lorg/xml/sax/EntityResolver;)V");
			global::javax.xml.parsers.DocumentBuilder._setErrorHandler30839 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder.staticClass, "setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V");
			global::javax.xml.parsers.DocumentBuilder._isNamespaceAware30840 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder.staticClass, "isNamespaceAware", "()Z");
			global::javax.xml.parsers.DocumentBuilder._isValidating30841 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder.staticClass, "isValidating", "()Z");
			global::javax.xml.parsers.DocumentBuilder._newDocument30842 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder.staticClass, "newDocument", "()Lorg/w3c/dom/Document;");
			global::javax.xml.parsers.DocumentBuilder._getDOMImplementation30843 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder.staticClass, "getDOMImplementation", "()Lorg/w3c/dom/DOMImplementation;");
			global::javax.xml.parsers.DocumentBuilder._getSchema30844 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder.staticClass, "getSchema", "()Ljavax/xml/validation/Schema;");
			global::javax.xml.parsers.DocumentBuilder._isXIncludeAware30845 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder.staticClass, "isXIncludeAware", "()Z");
			global::javax.xml.parsers.DocumentBuilder._DocumentBuilder30846 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.parsers.DocumentBuilder))]
	internal sealed partial class DocumentBuilder_ : javax.xml.parsers.DocumentBuilder
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DocumentBuilder_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parse30847;
		public override global::org.w3c.dom.Document parse(org.xml.sax.InputSource arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder_._parse30847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Document;
		}
		internal static global::MonoJavaBridge.MethodId _setEntityResolver30848;
		public override void setEntityResolver(org.xml.sax.EntityResolver arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder_._setEntityResolver30848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setErrorHandler30849;
		public override void setErrorHandler(org.xml.sax.ErrorHandler arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder_._setErrorHandler30849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isNamespaceAware30850;
		public override bool isNamespaceAware()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder_._isNamespaceAware30850);
		}
		internal static global::MonoJavaBridge.MethodId _isValidating30851;
		public override bool isValidating()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder_._isValidating30851);
		}
		internal static global::MonoJavaBridge.MethodId _newDocument30852;
		public override global::org.w3c.dom.Document newDocument()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder_._newDocument30852)) as org.w3c.dom.Document;
		}
		internal static global::MonoJavaBridge.MethodId _getDOMImplementation30853;
		public override global::org.w3c.dom.DOMImplementation getDOMImplementation()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.DOMImplementation>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilder_._getDOMImplementation30853)) as org.w3c.dom.DOMImplementation;
		}
		static DocumentBuilder_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.parsers.DocumentBuilder_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/parsers/DocumentBuilder"));
			global::javax.xml.parsers.DocumentBuilder_._parse30847 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder_.staticClass, "parse", "(Lorg/xml/sax/InputSource;)Lorg/w3c/dom/Document;");
			global::javax.xml.parsers.DocumentBuilder_._setEntityResolver30848 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder_.staticClass, "setEntityResolver", "(Lorg/xml/sax/EntityResolver;)V");
			global::javax.xml.parsers.DocumentBuilder_._setErrorHandler30849 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder_.staticClass, "setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V");
			global::javax.xml.parsers.DocumentBuilder_._isNamespaceAware30850 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder_.staticClass, "isNamespaceAware", "()Z");
			global::javax.xml.parsers.DocumentBuilder_._isValidating30851 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder_.staticClass, "isValidating", "()Z");
			global::javax.xml.parsers.DocumentBuilder_._newDocument30852 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder_.staticClass, "newDocument", "()Lorg/w3c/dom/Document;");
			global::javax.xml.parsers.DocumentBuilder_._getDOMImplementation30853 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilder_.staticClass, "getDOMImplementation", "()Lorg/w3c/dom/DOMImplementation;");
		}
		internal static void InitJNI()
		{
		}
	}
}