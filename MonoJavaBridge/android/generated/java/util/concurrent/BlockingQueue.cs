namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.concurrent.BlockingQueue_))]
	public partial interface BlockingQueue : Queue
	{
		bool add(java.lang.Object arg0);
		void put(java.lang.Object arg0);
		bool contains(java.lang.Object arg0);
		bool remove(java.lang.Object arg0);
		global::java.lang.Object poll(long arg0, java.util.concurrent.TimeUnit arg1);
		bool offer(java.lang.Object arg0, long arg1, java.util.concurrent.TimeUnit arg2);
		bool offer(java.lang.Object arg0);
		global::java.lang.Object take();
		int remainingCapacity();
		int drainTo(java.util.Collection arg0);
		int drainTo(java.util.Collection arg0, int arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.concurrent.BlockingQueue))]
	internal sealed partial class BlockingQueue_ : java.lang.Object, BlockingQueue
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal BlockingQueue_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add27067;
		bool java.util.concurrent.BlockingQueue.add(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._add27067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _put27068;
		void java.util.concurrent.BlockingQueue.put(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._put27068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _contains27069;
		bool java.util.concurrent.BlockingQueue.contains(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._contains27069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove27070;
		bool java.util.concurrent.BlockingQueue.remove(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._remove27070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _poll27071;
		global::java.lang.Object java.util.concurrent.BlockingQueue.poll(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._poll27071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _offer27072;
		bool java.util.concurrent.BlockingQueue.offer(java.lang.Object arg0, long arg1, java.util.concurrent.TimeUnit arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._offer27072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _offer27073;
		bool java.util.concurrent.BlockingQueue.offer(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._offer27073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _take27074;
		global::java.lang.Object java.util.concurrent.BlockingQueue.take()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._take27074)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remainingCapacity27075;
		int java.util.concurrent.BlockingQueue.remainingCapacity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._remainingCapacity27075);
		}
		internal static global::MonoJavaBridge.MethodId _drainTo27076;
		int java.util.concurrent.BlockingQueue.drainTo(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._drainTo27076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drainTo27077;
		int java.util.concurrent.BlockingQueue.drainTo(java.util.Collection arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._drainTo27077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _add27078;
		bool java.util.Queue.add(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._add27078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove27079;
		global::java.lang.Object java.util.Queue.remove()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._remove27079)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _poll27080;
		global::java.lang.Object java.util.Queue.poll()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._poll27080)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _peek27081;
		global::java.lang.Object java.util.Queue.peek()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._peek27081)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _element27082;
		global::java.lang.Object java.util.Queue.element()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._element27082)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _offer27083;
		bool java.util.Queue.offer(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._offer27083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _add27084;
		bool java.util.Collection.add(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._add27084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals27085;
		bool java.util.Collection.equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._equals27085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode27086;
		int java.util.Collection.hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._hashCode27086);
		}
		internal static global::MonoJavaBridge.MethodId _clear27087;
		void java.util.Collection.clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._clear27087);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty27088;
		bool java.util.Collection.isEmpty()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._isEmpty27088);
		}
		internal static global::MonoJavaBridge.MethodId _contains27089;
		bool java.util.Collection.contains(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._contains27089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll27090;
		bool java.util.Collection.addAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._addAll27090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size27091;
		int java.util.Collection.size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._size27091);
		}
		internal static global::MonoJavaBridge.MethodId _toArray27092;
		global::java.lang.Object[] java.util.Collection.toArray(java.lang.Object[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._toArray27092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray27093;
		global::java.lang.Object[] java.util.Collection.toArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._toArray27093)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator27094;
		global::java.util.Iterator java.util.Collection.iterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._iterator27094)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove27095;
		bool java.util.Collection.remove(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._remove27095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsAll27096;
		bool java.util.Collection.containsAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._containsAll27096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll27097;
		bool java.util.Collection.removeAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._removeAll27097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll27098;
		bool java.util.Collection.retainAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._retainAll27098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(((global::java.lang.Iterable)this).iterator());
		}
		internal static global::MonoJavaBridge.MethodId _iterator27099;
		global::java.util.Iterator java.lang.Iterable.iterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._iterator27099)) as java.util.Iterator;
		}
		static BlockingQueue_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.BlockingQueue_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/BlockingQueue"));
			global::java.util.concurrent.BlockingQueue_._add27067 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.BlockingQueue_._put27068 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "put", "(Ljava/lang/Object;)V");
			global::java.util.concurrent.BlockingQueue_._contains27069 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.BlockingQueue_._remove27070 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.BlockingQueue_._poll27071 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			global::java.util.concurrent.BlockingQueue_._offer27072 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "offer", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z");
			global::java.util.concurrent.BlockingQueue_._offer27073 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "offer", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.BlockingQueue_._take27074 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "take", "()Ljava/lang/Object;");
			global::java.util.concurrent.BlockingQueue_._remainingCapacity27075 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "remainingCapacity", "()I");
			global::java.util.concurrent.BlockingQueue_._drainTo27076 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "drainTo", "(Ljava/util/Collection;)I");
			global::java.util.concurrent.BlockingQueue_._drainTo27077 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "drainTo", "(Ljava/util/Collection;I)I");
			global::java.util.concurrent.BlockingQueue_._add27078 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.BlockingQueue_._remove27079 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "remove", "()Ljava/lang/Object;");
			global::java.util.concurrent.BlockingQueue_._poll27080 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "poll", "()Ljava/lang/Object;");
			global::java.util.concurrent.BlockingQueue_._peek27081 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "peek", "()Ljava/lang/Object;");
			global::java.util.concurrent.BlockingQueue_._element27082 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "element", "()Ljava/lang/Object;");
			global::java.util.concurrent.BlockingQueue_._offer27083 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "offer", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.BlockingQueue_._add27084 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.BlockingQueue_._equals27085 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.BlockingQueue_._hashCode27086 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "hashCode", "()I");
			global::java.util.concurrent.BlockingQueue_._clear27087 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "clear", "()V");
			global::java.util.concurrent.BlockingQueue_._isEmpty27088 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "isEmpty", "()Z");
			global::java.util.concurrent.BlockingQueue_._contains27089 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.BlockingQueue_._addAll27090 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.concurrent.BlockingQueue_._size27091 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "size", "()I");
			global::java.util.concurrent.BlockingQueue_._toArray27092 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.concurrent.BlockingQueue_._toArray27093 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.concurrent.BlockingQueue_._iterator27094 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.concurrent.BlockingQueue_._remove27095 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.BlockingQueue_._containsAll27096 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			global::java.util.concurrent.BlockingQueue_._removeAll27097 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.concurrent.BlockingQueue_._retainAll27098 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			global::java.util.concurrent.BlockingQueue_._iterator27099 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "iterator", "()Ljava/util/Iterator;");
		}
		internal static void InitJNI()
		{
		}
	}
}