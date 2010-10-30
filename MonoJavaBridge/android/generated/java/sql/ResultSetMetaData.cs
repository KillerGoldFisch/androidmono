namespace java.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.sql.ResultSetMetaData_))]
	public partial interface ResultSetMetaData  : global::MonoJavaBridge.IJavaObject 
	{
		bool isReadOnly(int arg0);
		global::java.lang.String getColumnName(int arg0);
		int getColumnCount();
		int getScale(int arg0);
		int getPrecision(int arg0);
		bool isWritable(int arg0);
		bool isAutoIncrement(int arg0);
		bool isCaseSensitive(int arg0);
		bool isSearchable(int arg0);
		bool isCurrency(int arg0);
		int isNullable(int arg0);
		bool isSigned(int arg0);
		int getColumnDisplaySize(int arg0);
		global::java.lang.String getColumnLabel(int arg0);
		global::java.lang.String getSchemaName(int arg0);
		global::java.lang.String getTableName(int arg0);
		global::java.lang.String getCatalogName(int arg0);
		int getColumnType(int arg0);
		global::java.lang.String getColumnTypeName(int arg0);
		bool isDefinitelyWritable(int arg0);
		global::java.lang.String getColumnClassName(int arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.sql.ResultSetMetaData))]
	internal sealed partial class ResultSetMetaData_ : java.lang.Object, ResultSetMetaData
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ResultSetMetaData_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly24943;
		bool java.sql.ResultSetMetaData.isReadOnly(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._isReadOnly24943, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnName24944;
		global::java.lang.String java.sql.ResultSetMetaData.getColumnName(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._getColumnName24944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getColumnCount24945;
		int java.sql.ResultSetMetaData.getColumnCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._getColumnCount24945);
		}
		internal static global::MonoJavaBridge.MethodId _getScale24946;
		int java.sql.ResultSetMetaData.getScale(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._getScale24946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPrecision24947;
		int java.sql.ResultSetMetaData.getPrecision(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._getPrecision24947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isWritable24948;
		bool java.sql.ResultSetMetaData.isWritable(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._isWritable24948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isAutoIncrement24949;
		bool java.sql.ResultSetMetaData.isAutoIncrement(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._isAutoIncrement24949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isCaseSensitive24950;
		bool java.sql.ResultSetMetaData.isCaseSensitive(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._isCaseSensitive24950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSearchable24951;
		bool java.sql.ResultSetMetaData.isSearchable(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._isSearchable24951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isCurrency24952;
		bool java.sql.ResultSetMetaData.isCurrency(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._isCurrency24952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isNullable24953;
		int java.sql.ResultSetMetaData.isNullable(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._isNullable24953, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSigned24954;
		bool java.sql.ResultSetMetaData.isSigned(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._isSigned24954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnDisplaySize24955;
		int java.sql.ResultSetMetaData.getColumnDisplaySize(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._getColumnDisplaySize24955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnLabel24956;
		global::java.lang.String java.sql.ResultSetMetaData.getColumnLabel(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._getColumnLabel24956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSchemaName24957;
		global::java.lang.String java.sql.ResultSetMetaData.getSchemaName(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._getSchemaName24957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getTableName24958;
		global::java.lang.String java.sql.ResultSetMetaData.getTableName(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._getTableName24958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getCatalogName24959;
		global::java.lang.String java.sql.ResultSetMetaData.getCatalogName(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._getCatalogName24959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getColumnType24960;
		int java.sql.ResultSetMetaData.getColumnType(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._getColumnType24960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnTypeName24961;
		global::java.lang.String java.sql.ResultSetMetaData.getColumnTypeName(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._getColumnTypeName24961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isDefinitelyWritable24962;
		bool java.sql.ResultSetMetaData.isDefinitelyWritable(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._isDefinitelyWritable24962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnClassName24963;
		global::java.lang.String java.sql.ResultSetMetaData.getColumnClassName(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._getColumnClassName24963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		static ResultSetMetaData_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.ResultSetMetaData_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/ResultSetMetaData"));
			global::java.sql.ResultSetMetaData_._isReadOnly24943 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "isReadOnly", "(I)Z");
			global::java.sql.ResultSetMetaData_._getColumnName24944 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "getColumnName", "(I)Ljava/lang/String;");
			global::java.sql.ResultSetMetaData_._getColumnCount24945 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "getColumnCount", "()I");
			global::java.sql.ResultSetMetaData_._getScale24946 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "getScale", "(I)I");
			global::java.sql.ResultSetMetaData_._getPrecision24947 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "getPrecision", "(I)I");
			global::java.sql.ResultSetMetaData_._isWritable24948 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "isWritable", "(I)Z");
			global::java.sql.ResultSetMetaData_._isAutoIncrement24949 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "isAutoIncrement", "(I)Z");
			global::java.sql.ResultSetMetaData_._isCaseSensitive24950 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "isCaseSensitive", "(I)Z");
			global::java.sql.ResultSetMetaData_._isSearchable24951 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "isSearchable", "(I)Z");
			global::java.sql.ResultSetMetaData_._isCurrency24952 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "isCurrency", "(I)Z");
			global::java.sql.ResultSetMetaData_._isNullable24953 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "isNullable", "(I)I");
			global::java.sql.ResultSetMetaData_._isSigned24954 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "isSigned", "(I)Z");
			global::java.sql.ResultSetMetaData_._getColumnDisplaySize24955 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "getColumnDisplaySize", "(I)I");
			global::java.sql.ResultSetMetaData_._getColumnLabel24956 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "getColumnLabel", "(I)Ljava/lang/String;");
			global::java.sql.ResultSetMetaData_._getSchemaName24957 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "getSchemaName", "(I)Ljava/lang/String;");
			global::java.sql.ResultSetMetaData_._getTableName24958 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "getTableName", "(I)Ljava/lang/String;");
			global::java.sql.ResultSetMetaData_._getCatalogName24959 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "getCatalogName", "(I)Ljava/lang/String;");
			global::java.sql.ResultSetMetaData_._getColumnType24960 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "getColumnType", "(I)I");
			global::java.sql.ResultSetMetaData_._getColumnTypeName24961 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "getColumnTypeName", "(I)Ljava/lang/String;");
			global::java.sql.ResultSetMetaData_._isDefinitelyWritable24962 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "isDefinitelyWritable", "(I)Z");
			global::java.sql.ResultSetMetaData_._getColumnClassName24963 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "getColumnClassName", "(I)Ljava/lang/String;");
		}
		internal static void InitJNI()
		{
		}
	}
}