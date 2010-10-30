namespace org.w3c.dom
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.ProcessingInstruction_))]
	public partial interface ProcessingInstruction : Node
	{
		global::java.lang.String getData();
		void setData(java.lang.String arg0);
		global::java.lang.String getTarget();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.ProcessingInstruction))]
	internal sealed partial class ProcessingInstruction_ : java.lang.Object, ProcessingInstruction
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ProcessingInstruction_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getData34780;
		global::java.lang.String org.w3c.dom.ProcessingInstruction.getData()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._getData34780)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setData34781;
		void org.w3c.dom.ProcessingInstruction.setData(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._setData34781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTarget34782;
		global::java.lang.String org.w3c.dom.ProcessingInstruction.getTarget()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._getTarget34782)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _normalize34783;
		void org.w3c.dom.Node.normalize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._normalize34783);
		}
		internal static global::MonoJavaBridge.MethodId _isSupported34784;
		bool org.w3c.dom.Node.isSupported(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._isSupported34784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributes34785;
		global::org.w3c.dom.NamedNodeMap org.w3c.dom.Node.getAttributes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NamedNodeMap>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._getAttributes34785)) as org.w3c.dom.NamedNodeMap;
		}
		internal static global::MonoJavaBridge.MethodId _getPrefix34786;
		global::java.lang.String org.w3c.dom.Node.getPrefix()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._getPrefix34786)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFirstChild34787;
		global::org.w3c.dom.Node org.w3c.dom.Node.getFirstChild()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._getFirstChild34787)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getNodeType34788;
		short org.w3c.dom.Node.getNodeType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallShortMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._getNodeType34788);
		}
		internal static global::MonoJavaBridge.MethodId _getNodeName34789;
		global::java.lang.String org.w3c.dom.Node.getNodeName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._getNodeName34789)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNodeValue34790;
		global::java.lang.String org.w3c.dom.Node.getNodeValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._getNodeValue34790)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNextSibling34791;
		global::org.w3c.dom.Node org.w3c.dom.Node.getNextSibling()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._getNextSibling34791)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalName34792;
		global::java.lang.String org.w3c.dom.Node.getLocalName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._getLocalName34792)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasAttributes34793;
		bool org.w3c.dom.Node.hasAttributes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._hasAttributes34793);
		}
		internal static global::MonoJavaBridge.MethodId _getNamespaceURI34794;
		global::java.lang.String org.w3c.dom.Node.getNamespaceURI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._getNamespaceURI34794)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasChildNodes34795;
		bool org.w3c.dom.Node.hasChildNodes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._hasChildNodes34795);
		}
		internal static global::MonoJavaBridge.MethodId _getUserData34796;
		global::java.lang.Object org.w3c.dom.Node.getUserData(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._getUserData34796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setUserData34797;
		global::java.lang.Object org.w3c.dom.Node.setUserData(java.lang.String arg0, java.lang.Object arg1, org.w3c.dom.UserDataHandler arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._setUserData34797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getFeature34798;
		global::java.lang.Object org.w3c.dom.Node.getFeature(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._getFeature34798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setPrefix34799;
		void org.w3c.dom.Node.setPrefix(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._setPrefix34799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNodeValue34800;
		void org.w3c.dom.Node.setNodeValue(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._setNodeValue34800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getParentNode34801;
		global::org.w3c.dom.Node org.w3c.dom.Node.getParentNode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._getParentNode34801)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getChildNodes34802;
		global::org.w3c.dom.NodeList org.w3c.dom.Node.getChildNodes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NodeList>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._getChildNodes34802)) as org.w3c.dom.NodeList;
		}
		internal static global::MonoJavaBridge.MethodId _getLastChild34803;
		global::org.w3c.dom.Node org.w3c.dom.Node.getLastChild()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._getLastChild34803)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getPreviousSibling34804;
		global::org.w3c.dom.Node org.w3c.dom.Node.getPreviousSibling()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._getPreviousSibling34804)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getOwnerDocument34805;
		global::org.w3c.dom.Document org.w3c.dom.Node.getOwnerDocument()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._getOwnerDocument34805)) as org.w3c.dom.Document;
		}
		internal static global::MonoJavaBridge.MethodId _insertBefore34806;
		global::org.w3c.dom.Node org.w3c.dom.Node.insertBefore(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._insertBefore34806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _replaceChild34807;
		global::org.w3c.dom.Node org.w3c.dom.Node.replaceChild(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._replaceChild34807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _removeChild34808;
		global::org.w3c.dom.Node org.w3c.dom.Node.removeChild(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._removeChild34808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _appendChild34809;
		global::org.w3c.dom.Node org.w3c.dom.Node.appendChild(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._appendChild34809, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _cloneNode34810;
		global::org.w3c.dom.Node org.w3c.dom.Node.cloneNode(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._cloneNode34810, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getBaseURI34811;
		global::java.lang.String org.w3c.dom.Node.getBaseURI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._getBaseURI34811)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _compareDocumentPosition34812;
		short org.w3c.dom.Node.compareDocumentPosition(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallShortMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._compareDocumentPosition34812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTextContent34813;
		global::java.lang.String org.w3c.dom.Node.getTextContent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._getTextContent34813)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setTextContent34814;
		void org.w3c.dom.Node.setTextContent(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._setTextContent34814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSameNode34815;
		bool org.w3c.dom.Node.isSameNode(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._isSameNode34815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lookupPrefix34816;
		global::java.lang.String org.w3c.dom.Node.lookupPrefix(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._lookupPrefix34816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isDefaultNamespace34817;
		bool org.w3c.dom.Node.isDefaultNamespace(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._isDefaultNamespace34817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lookupNamespaceURI34818;
		global::java.lang.String org.w3c.dom.Node.lookupNamespaceURI(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._lookupNamespaceURI34818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isEqualNode34819;
		bool org.w3c.dom.Node.isEqualNode(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._isEqualNode34819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static ProcessingInstruction_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.ProcessingInstruction_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/ProcessingInstruction"));
			global::org.w3c.dom.ProcessingInstruction_._getData34780 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "getData", "()Ljava/lang/String;");
			global::org.w3c.dom.ProcessingInstruction_._setData34781 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "setData", "(Ljava/lang/String;)V");
			global::org.w3c.dom.ProcessingInstruction_._getTarget34782 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "getTarget", "()Ljava/lang/String;");
			global::org.w3c.dom.ProcessingInstruction_._normalize34783 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "normalize", "()V");
			global::org.w3c.dom.ProcessingInstruction_._isSupported34784 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "isSupported", "(Ljava/lang/String;Ljava/lang/String;)Z");
			global::org.w3c.dom.ProcessingInstruction_._getAttributes34785 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "getAttributes", "()Lorg/w3c/dom/NamedNodeMap;");
			global::org.w3c.dom.ProcessingInstruction_._getPrefix34786 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "getPrefix", "()Ljava/lang/String;");
			global::org.w3c.dom.ProcessingInstruction_._getFirstChild34787 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "getFirstChild", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.ProcessingInstruction_._getNodeType34788 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "getNodeType", "()S");
			global::org.w3c.dom.ProcessingInstruction_._getNodeName34789 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "getNodeName", "()Ljava/lang/String;");
			global::org.w3c.dom.ProcessingInstruction_._getNodeValue34790 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "getNodeValue", "()Ljava/lang/String;");
			global::org.w3c.dom.ProcessingInstruction_._getNextSibling34791 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "getNextSibling", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.ProcessingInstruction_._getLocalName34792 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "getLocalName", "()Ljava/lang/String;");
			global::org.w3c.dom.ProcessingInstruction_._hasAttributes34793 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "hasAttributes", "()Z");
			global::org.w3c.dom.ProcessingInstruction_._getNamespaceURI34794 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "getNamespaceURI", "()Ljava/lang/String;");
			global::org.w3c.dom.ProcessingInstruction_._hasChildNodes34795 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "hasChildNodes", "()Z");
			global::org.w3c.dom.ProcessingInstruction_._getUserData34796 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "getUserData", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.w3c.dom.ProcessingInstruction_._setUserData34797 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "setUserData", "(Ljava/lang/String;Ljava/lang/Object;Lorg/w3c/dom/UserDataHandler;)Ljava/lang/Object;");
			global::org.w3c.dom.ProcessingInstruction_._getFeature34798 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "getFeature", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;");
			global::org.w3c.dom.ProcessingInstruction_._setPrefix34799 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "setPrefix", "(Ljava/lang/String;)V");
			global::org.w3c.dom.ProcessingInstruction_._setNodeValue34800 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "setNodeValue", "(Ljava/lang/String;)V");
			global::org.w3c.dom.ProcessingInstruction_._getParentNode34801 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "getParentNode", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.ProcessingInstruction_._getChildNodes34802 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "getChildNodes", "()Lorg/w3c/dom/NodeList;");
			global::org.w3c.dom.ProcessingInstruction_._getLastChild34803 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "getLastChild", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.ProcessingInstruction_._getPreviousSibling34804 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "getPreviousSibling", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.ProcessingInstruction_._getOwnerDocument34805 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "getOwnerDocument", "()Lorg/w3c/dom/Document;");
			global::org.w3c.dom.ProcessingInstruction_._insertBefore34806 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "insertBefore", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.ProcessingInstruction_._replaceChild34807 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "replaceChild", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.ProcessingInstruction_._removeChild34808 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "removeChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.ProcessingInstruction_._appendChild34809 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "appendChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.ProcessingInstruction_._cloneNode34810 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "cloneNode", "(Z)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.ProcessingInstruction_._getBaseURI34811 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "getBaseURI", "()Ljava/lang/String;");
			global::org.w3c.dom.ProcessingInstruction_._compareDocumentPosition34812 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "compareDocumentPosition", "(Lorg/w3c/dom/Node;)S");
			global::org.w3c.dom.ProcessingInstruction_._getTextContent34813 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "getTextContent", "()Ljava/lang/String;");
			global::org.w3c.dom.ProcessingInstruction_._setTextContent34814 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "setTextContent", "(Ljava/lang/String;)V");
			global::org.w3c.dom.ProcessingInstruction_._isSameNode34815 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "isSameNode", "(Lorg/w3c/dom/Node;)Z");
			global::org.w3c.dom.ProcessingInstruction_._lookupPrefix34816 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "lookupPrefix", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.w3c.dom.ProcessingInstruction_._isDefaultNamespace34817 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "isDefaultNamespace", "(Ljava/lang/String;)Z");
			global::org.w3c.dom.ProcessingInstruction_._lookupNamespaceURI34818 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "lookupNamespaceURI", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.w3c.dom.ProcessingInstruction_._isEqualNode34819 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "isEqualNode", "(Lorg/w3c/dom/Node;)Z");
		}
		internal static void InitJNI()
		{
		}
	}
}