package md54d4a5cd7b1153e9de4a2e3782bf80f5b;


public class ResponsiveGridLayoutManager
	extends android.support.v7.widget.GridLayoutManager
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onLayoutChildren:(Landroid/support/v7/widget/RecyclerView$Recycler;Landroid/support/v7/widget/RecyclerView$State;)V:GetOnLayoutChildren_Landroid_support_v7_widget_RecyclerView_Recycler_Landroid_support_v7_widget_RecyclerView_State_Handler\n" +
			"n_canScrollHorizontally:()Z:GetCanScrollHorizontallyHandler\n" +
			"n_canScrollVertically:()Z:GetCanScrollVerticallyHandler\n" +
			"";
		mono.android.Runtime.register ("Sharpnado.Presentation.Forms.Droid.Renderers.HorizontalList.ResponsiveGridLayoutManager, Sharpnado.Presentation.Forms.Droid", ResponsiveGridLayoutManager.class, __md_methods);
	}


	public ResponsiveGridLayoutManager (android.content.Context p0, android.util.AttributeSet p1, int p2, int p3)
	{
		super (p0, p1, p2, p3);
		if (getClass () == ResponsiveGridLayoutManager.class)
			mono.android.TypeManager.Activate ("Sharpnado.Presentation.Forms.Droid.Renderers.HorizontalList.ResponsiveGridLayoutManager, Sharpnado.Presentation.Forms.Droid", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2, p3 });
	}


	public ResponsiveGridLayoutManager (android.content.Context p0, int p1)
	{
		super (p0, p1);
		if (getClass () == ResponsiveGridLayoutManager.class)
			mono.android.TypeManager.Activate ("Sharpnado.Presentation.Forms.Droid.Renderers.HorizontalList.ResponsiveGridLayoutManager, Sharpnado.Presentation.Forms.Droid", "Android.Content.Context, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1 });
	}


	public ResponsiveGridLayoutManager (android.content.Context p0, int p1, int p2, boolean p3)
	{
		super (p0, p1, p2, p3);
		if (getClass () == ResponsiveGridLayoutManager.class)
			mono.android.TypeManager.Activate ("Sharpnado.Presentation.Forms.Droid.Renderers.HorizontalList.ResponsiveGridLayoutManager, Sharpnado.Presentation.Forms.Droid", "Android.Content.Context, Mono.Android:System.Int32, mscorlib:System.Int32, mscorlib:System.Boolean, mscorlib", this, new java.lang.Object[] { p0, p1, p2, p3 });
	}


	public void onLayoutChildren (android.support.v7.widget.RecyclerView.Recycler p0, android.support.v7.widget.RecyclerView.State p1)
	{
		n_onLayoutChildren (p0, p1);
	}

	private native void n_onLayoutChildren (android.support.v7.widget.RecyclerView.Recycler p0, android.support.v7.widget.RecyclerView.State p1);


	public boolean canScrollHorizontally ()
	{
		return n_canScrollHorizontally ();
	}

	private native boolean n_canScrollHorizontally ();


	public boolean canScrollVertically ()
	{
		return n_canScrollVertically ();
	}

	private native boolean n_canScrollVertically ();

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
