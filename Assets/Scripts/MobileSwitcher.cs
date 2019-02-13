using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

public class MobileSwitcher : MonoBehaviour
{
	
	public SRPBatcherProfiler	m_srpProfiler;
	
	void OnGUI()
	{
		float offset = 256 + 50;
		if (GUI.Button(new Rect(32, offset, 150, 150), "Toggle batcher"))
		{
			GraphicsSettings.useScriptableRenderPipelineBatching ^= true;
		}
 		if (GUI.Button(new Rect(32 + 150 + 32, offset, 150, 150), "Toggle stats"))
 		{
 			m_srpProfiler.m_Enable ^= true;
 		}
	}
	
}
