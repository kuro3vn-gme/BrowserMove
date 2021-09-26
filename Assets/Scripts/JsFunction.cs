using System.Runtime.InteropServices;
using UnityEngine;

public static class JsFunction
{

#if (UNITY_WEBGL && !UNITY_EDITOR)

	[DllImport("__Internal")]
    public static extern int ScreenWidth();
    
    [DllImport("__Internal")]
    public static extern int ScreenHeight();
    
    [DllImport("__Internal")]
    public static extern int WindowX();

    [DllImport("__Internal")]
    public static extern int WindowY();

#else

	public static int ScreenWidth()
	{
		return Screen.width;
	}

	public static int ScreenHeight()
	{
		return Screen.height;
	}

	public static int WindowX()
	{
		return 0;
	}

	public static int WindowY()
	{
		return 0;
	}

#endif
}
