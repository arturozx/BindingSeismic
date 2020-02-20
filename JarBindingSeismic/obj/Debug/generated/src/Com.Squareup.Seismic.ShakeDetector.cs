using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Squareup.Seismic {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.squareup.seismic']/class[@name='ShakeDetector']"
	[global::Android.Runtime.Register ("com/squareup/seismic/ShakeDetector", DoNotGenerateAcw=true)]
	public partial class ShakeDetector : global::Java.Lang.Object, global::Android.Hardware.ISensorEventListener {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.seismic']/class[@name='ShakeDetector']/field[@name='SENSITIVITY_HARD']"
		[Register ("SENSITIVITY_HARD")]
		public const int SensitivityHard = (int) 15;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.seismic']/class[@name='ShakeDetector']/field[@name='SENSITIVITY_LIGHT']"
		[Register ("SENSITIVITY_LIGHT")]
		public const int SensitivityLight = (int) 11;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.seismic']/class[@name='ShakeDetector']/field[@name='SENSITIVITY_MEDIUM']"
		[Register ("SENSITIVITY_MEDIUM")]
		public const int SensitivityMedium = (int) 13;
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.squareup.seismic']/interface[@name='ShakeDetector.Listener']"
		[Register ("com/squareup/seismic/ShakeDetector$Listener", "", "Com.Squareup.Seismic.ShakeDetector/IListenerInvoker")]
		public partial interface IListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.seismic']/interface[@name='ShakeDetector.Listener']/method[@name='hearShake' and count(parameter)=0]"
			[Register ("hearShake", "()V", "GetHearShakeHandler:Com.Squareup.Seismic.ShakeDetector/IListenerInvoker, JarBindingSeismic")]
			void HearShake ();

		}

		[global::Android.Runtime.Register ("com/squareup/seismic/ShakeDetector$Listener", DoNotGenerateAcw=true)]
		internal class IListenerInvoker : global::Java.Lang.Object, IListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/squareup/seismic/ShakeDetector$Listener", typeof (IListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.squareup.seismic.ShakeDetector.Listener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_hearShake;
#pragma warning disable 0169
			static Delegate GetHearShakeHandler ()
			{
				if (cb_hearShake == null)
					cb_hearShake = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_HearShake);
				return cb_hearShake;
			}

			static void n_HearShake (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Squareup.Seismic.ShakeDetector.IListener __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Seismic.ShakeDetector.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.HearShake ();
			}
#pragma warning restore 0169

			IntPtr id_hearShake;
			public unsafe void HearShake ()
			{
				if (id_hearShake == IntPtr.Zero)
					id_hearShake = JNIEnv.GetMethodID (class_ref, "hearShake", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_hearShake);
			}

		}

		[global::Android.Runtime.Register ("mono/com/squareup/seismic/ShakeDetector_ListenerImplementor")]
		internal sealed partial class IListenerImplementor : global::Java.Lang.Object, IListener {

			object sender;

			public IListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/squareup/seismic/ShakeDetector_ListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler Handler;
#pragma warning restore 0649

			public void HearShake ()
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.squareup.seismic']/class[@name='ShakeDetector.Sample']"
		[global::Android.Runtime.Register ("com/squareup/seismic/ShakeDetector$Sample", DoNotGenerateAcw=true)]
		public partial class Sample : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/squareup/seismic/ShakeDetector$Sample", typeof (Sample));
			internal static new IntPtr class_ref {
				get {
					return _members.JniPeerType.PeerReference.Handle;
				}
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			protected Sample (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.squareup.seismic']/class[@name='ShakeDetector.SamplePool']"
		[global::Android.Runtime.Register ("com/squareup/seismic/ShakeDetector$SamplePool", DoNotGenerateAcw=true)]
		public partial class SamplePool : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/squareup/seismic/ShakeDetector$SamplePool", typeof (SamplePool));
			internal static new IntPtr class_ref {
				get {
					return _members.JniPeerType.PeerReference.Handle;
				}
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			protected SamplePool (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.squareup.seismic']/class[@name='ShakeDetector.SampleQueue']"
		[global::Android.Runtime.Register ("com/squareup/seismic/ShakeDetector$SampleQueue", DoNotGenerateAcw=true)]
		public partial class SampleQueue : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/squareup/seismic/ShakeDetector$SampleQueue", typeof (SampleQueue));
			internal static new IntPtr class_ref {
				get {
					return _members.JniPeerType.PeerReference.Handle;
				}
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			protected SampleQueue (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/squareup/seismic/ShakeDetector", typeof (ShakeDetector));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected ShakeDetector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.squareup.seismic']/class[@name='ShakeDetector']/constructor[@name='ShakeDetector' and count(parameter)=1 and parameter[1][@type='com.squareup.seismic.ShakeDetector.Listener']]"
		[Register (".ctor", "(Lcom/squareup/seismic/ShakeDetector$Listener;)V", "")]
		public unsafe ShakeDetector (global::Com.Squareup.Seismic.ShakeDetector.IListener listener)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/squareup/seismic/ShakeDetector$Listener;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onAccuracyChanged_Landroid_hardware_Sensor_I;
#pragma warning disable 0169
		static Delegate GetOnAccuracyChanged_Landroid_hardware_Sensor_IHandler ()
		{
			if (cb_onAccuracyChanged_Landroid_hardware_Sensor_I == null)
				cb_onAccuracyChanged_Landroid_hardware_Sensor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnAccuracyChanged_Landroid_hardware_Sensor_I);
			return cb_onAccuracyChanged_Landroid_hardware_Sensor_I;
		}

		static void n_OnAccuracyChanged_Landroid_hardware_Sensor_I (IntPtr jnienv, IntPtr native__this, IntPtr native_sensor, int native_accuracy)
		{
			global::Com.Squareup.Seismic.ShakeDetector __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Seismic.ShakeDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Hardware.Sensor sensor = global::Java.Lang.Object.GetObject<global::Android.Hardware.Sensor> (native_sensor, JniHandleOwnership.DoNotTransfer);
			global::Android.Hardware.SensorStatus accuracy = (global::Android.Hardware.SensorStatus) native_accuracy;
			__this.OnAccuracyChanged (sensor, accuracy);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.seismic']/class[@name='ShakeDetector']/method[@name='onAccuracyChanged' and count(parameter)=2 and parameter[1][@type='android.hardware.Sensor'] and parameter[2][@type='int']]"
		[Register ("onAccuracyChanged", "(Landroid/hardware/Sensor;I)V", "GetOnAccuracyChanged_Landroid_hardware_Sensor_IHandler")]
		public virtual unsafe void OnAccuracyChanged (global::Android.Hardware.Sensor sensor, [global::Android.Runtime.GeneratedEnum] global::Android.Hardware.SensorStatus accuracy)
		{
			const string __id = "onAccuracyChanged.(Landroid/hardware/Sensor;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((sensor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sensor).Handle);
				__args [1] = new JniArgumentValue ((int) accuracy);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onSensorChanged_Landroid_hardware_SensorEvent_;
#pragma warning disable 0169
		static Delegate GetOnSensorChanged_Landroid_hardware_SensorEvent_Handler ()
		{
			if (cb_onSensorChanged_Landroid_hardware_SensorEvent_ == null)
				cb_onSensorChanged_Landroid_hardware_SensorEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSensorChanged_Landroid_hardware_SensorEvent_);
			return cb_onSensorChanged_Landroid_hardware_SensorEvent_;
		}

		static void n_OnSensorChanged_Landroid_hardware_SensorEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			global::Com.Squareup.Seismic.ShakeDetector __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Seismic.ShakeDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Hardware.SensorEvent e = global::Java.Lang.Object.GetObject<global::Android.Hardware.SensorEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.OnSensorChanged (e);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.seismic']/class[@name='ShakeDetector']/method[@name='onSensorChanged' and count(parameter)=1 and parameter[1][@type='android.hardware.SensorEvent']]"
		[Register ("onSensorChanged", "(Landroid/hardware/SensorEvent;)V", "GetOnSensorChanged_Landroid_hardware_SensorEvent_Handler")]
		public virtual unsafe void OnSensorChanged (global::Android.Hardware.SensorEvent e)
		{
			const string __id = "onSensorChanged.(Landroid/hardware/SensorEvent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setSensitivity_I;
#pragma warning disable 0169
		static Delegate GetSetSensitivity_IHandler ()
		{
			if (cb_setSensitivity_I == null)
				cb_setSensitivity_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSensitivity_I);
			return cb_setSensitivity_I;
		}

		static void n_SetSensitivity_I (IntPtr jnienv, IntPtr native__this, int accelerationThreshold)
		{
			global::Com.Squareup.Seismic.ShakeDetector __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Seismic.ShakeDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSensitivity (accelerationThreshold);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.seismic']/class[@name='ShakeDetector']/method[@name='setSensitivity' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSensitivity", "(I)V", "GetSetSensitivity_IHandler")]
		public virtual unsafe void SetSensitivity (int accelerationThreshold)
		{
			const string __id = "setSensitivity.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (accelerationThreshold);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_start_Landroid_hardware_SensorManager_;
#pragma warning disable 0169
		static Delegate GetStart_Landroid_hardware_SensorManager_Handler ()
		{
			if (cb_start_Landroid_hardware_SensorManager_ == null)
				cb_start_Landroid_hardware_SensorManager_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Start_Landroid_hardware_SensorManager_);
			return cb_start_Landroid_hardware_SensorManager_;
		}

		static bool n_Start_Landroid_hardware_SensorManager_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sensorManager)
		{
			global::Com.Squareup.Seismic.ShakeDetector __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Seismic.ShakeDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Hardware.SensorManager sensorManager = global::Java.Lang.Object.GetObject<global::Android.Hardware.SensorManager> (native_sensorManager, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Start (sensorManager);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.seismic']/class[@name='ShakeDetector']/method[@name='start' and count(parameter)=1 and parameter[1][@type='android.hardware.SensorManager']]"
		[Register ("start", "(Landroid/hardware/SensorManager;)Z", "GetStart_Landroid_hardware_SensorManager_Handler")]
		public virtual unsafe bool Start (global::Android.Hardware.SensorManager sensorManager)
		{
			const string __id = "start.(Landroid/hardware/SensorManager;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((sensorManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sensorManager).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Squareup.Seismic.ShakeDetector __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Seismic.ShakeDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.seismic']/class[@name='ShakeDetector']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			const string __id = "stop.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
