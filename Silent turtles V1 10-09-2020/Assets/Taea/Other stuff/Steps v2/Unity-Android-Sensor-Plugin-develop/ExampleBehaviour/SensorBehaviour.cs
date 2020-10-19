using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class SensorBehaviour : MonoBehaviour
{
	private AndroidJavaObject plugin;

	void Start ()
	{
#if UNITY_ANDROID
		plugin = new AndroidJavaClass("jp.kshoji.unity.sensor.UnitySensorPlugin").CallStatic<AndroidJavaObject>("getInstance");
		plugin.Call("setSamplingPeriod", 100 * 1000); // refresh sensor 100 mSec each
		plugin.Call("startSensorListening", "stepcounter");
#endif
	}

	void OnApplicationQuit ()
	{
#if UNITY_ANDROID
		if (plugin != null) {
			plugin.Call("terminate");
			plugin = null;
		}
#endif
	}

	void Update ()
	{
#if UNITY_ANDROID
		if (plugin != null) {
			float[] sensorValue = plugin.Call<float[]>("getSensorValues", "stepcounter");
			if (sensorValue != null) {
				Debug.Log("sensorValue:" + string.Join(",", new List<float>(sensorValue).ConvertAll(i => i.ToString()).ToArray()));
			}
		}
#endif
	}
}
