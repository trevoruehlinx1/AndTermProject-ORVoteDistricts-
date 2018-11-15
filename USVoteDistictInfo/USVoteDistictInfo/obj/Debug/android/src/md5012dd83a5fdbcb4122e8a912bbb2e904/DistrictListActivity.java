package md5012dd83a5fdbcb4122e8a912bbb2e904;


public class DistrictListActivity
	extends android.app.ListActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("USVoteDistictInfo.DistrictListActivity, USVoteDistictInfo", DistrictListActivity.class, __md_methods);
	}


	public DistrictListActivity ()
	{
		super ();
		if (getClass () == DistrictListActivity.class)
			mono.android.TypeManager.Activate ("USVoteDistictInfo.DistrictListActivity, USVoteDistictInfo", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
