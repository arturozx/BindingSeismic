package mono.com.squareup.seismic;


public class ShakeDetector_ListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.squareup.seismic.ShakeDetector.Listener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_hearShake:()V:GetHearShakeHandler:Com.Squareup.Seismic.ShakeDetector/IListenerInvoker, JarBindingSeismic\n" +
			"";
		mono.android.Runtime.register ("Com.Squareup.Seismic.ShakeDetector+IListenerImplementor, JarBindingSeismic", ShakeDetector_ListenerImplementor.class, __md_methods);
	}


	public ShakeDetector_ListenerImplementor ()
	{
		super ();
		if (getClass () == ShakeDetector_ListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Squareup.Seismic.ShakeDetector+IListenerImplementor, JarBindingSeismic", "", this, new java.lang.Object[] {  });
	}


	public void hearShake ()
	{
		n_hearShake ();
	}

	private native void n_hearShake ();

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
