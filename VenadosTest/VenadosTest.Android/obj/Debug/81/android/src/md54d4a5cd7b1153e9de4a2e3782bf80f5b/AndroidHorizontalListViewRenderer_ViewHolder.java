package md54d4a5cd7b1153e9de4a2e3782bf80f5b;


public class AndroidHorizontalListViewRenderer_ViewHolder
	extends android.support.v7.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Sharpnado.Presentation.Forms.Droid.Renderers.HorizontalList.AndroidHorizontalListViewRenderer+ViewHolder, Sharpnado.Presentation.Forms.Droid", AndroidHorizontalListViewRenderer_ViewHolder.class, __md_methods);
	}


	public AndroidHorizontalListViewRenderer_ViewHolder (android.view.View p0)
	{
		super (p0);
		if (getClass () == AndroidHorizontalListViewRenderer_ViewHolder.class)
			mono.android.TypeManager.Activate ("Sharpnado.Presentation.Forms.Droid.Renderers.HorizontalList.AndroidHorizontalListViewRenderer+ViewHolder, Sharpnado.Presentation.Forms.Droid", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
	}

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
