package md54d4a5cd7b1153e9de4a2e3782bf80f5b;


public class AndroidHorizontalListViewRenderer
	extends md51558244f76c53b6aeda52c8a337f2c37.ViewRenderer_2
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onLayout:(ZIIII)V:GetOnLayout_ZIIIIHandler\n" +
			"";
		mono.android.Runtime.register ("Sharpnado.Presentation.Forms.Droid.Renderers.HorizontalList.AndroidHorizontalListViewRenderer, Sharpnado.Presentation.Forms.Droid", AndroidHorizontalListViewRenderer.class, __md_methods);
	}


	public AndroidHorizontalListViewRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == AndroidHorizontalListViewRenderer.class)
			mono.android.TypeManager.Activate ("Sharpnado.Presentation.Forms.Droid.Renderers.HorizontalList.AndroidHorizontalListViewRenderer, Sharpnado.Presentation.Forms.Droid", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public AndroidHorizontalListViewRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == AndroidHorizontalListViewRenderer.class)
			mono.android.TypeManager.Activate ("Sharpnado.Presentation.Forms.Droid.Renderers.HorizontalList.AndroidHorizontalListViewRenderer, Sharpnado.Presentation.Forms.Droid", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public AndroidHorizontalListViewRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == AndroidHorizontalListViewRenderer.class)
			mono.android.TypeManager.Activate ("Sharpnado.Presentation.Forms.Droid.Renderers.HorizontalList.AndroidHorizontalListViewRenderer, Sharpnado.Presentation.Forms.Droid", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public void onLayout (boolean p0, int p1, int p2, int p3, int p4)
	{
		n_onLayout (p0, p1, p2, p3, p4);
	}

	private native void n_onLayout (boolean p0, int p1, int p2, int p3, int p4);

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
