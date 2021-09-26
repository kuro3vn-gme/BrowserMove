using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageMover : MonoBehaviour
{
	private RectTransform rectTransform;
	private int startWindowX;
	private int startWindowY;

#if (UNITY_WEBGL && !UNITY_EDITOR)

	private void Awake()
	{
		rectTransform = GetComponent<RectTransform>();
	}

	private void OnEnable()
	{
		startWindowX = JsFunction.WindowX();
		startWindowY = JsFunction.WindowY();
		rectTransform.anchoredPosition = Vector2.zero;
	}

	private void Update()
	{
		var currentWindowX = JsFunction.WindowX();
		var currentWindowY = JsFunction.WindowY();
		rectTransform.anchoredPosition = new Vector2(startWindowX - currentWindowX, currentWindowY - startWindowY);
	}
#endif
}
