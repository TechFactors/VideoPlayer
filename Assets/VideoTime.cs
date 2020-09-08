using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class VideoTime : MonoBehaviour
{
	public VideoManager video;
	public TextMeshProUGUI time;

	int secondsPassed;
	int minutesPassed;
	int totalSeconds;
	int totalMinutes;

	void Update()
	{
		if (video.IsPrepared)
		{
			totalMinutes = (int)video.Duration / 60;
			totalSeconds = (int)video.Duration - totalMinutes * 60;
			minutesPassed = (int)video.Time / 60;
			secondsPassed = (int)video.Time - minutesPassed * 60;

			time.text = string.Format("{0:00}:{1:00}", minutesPassed, secondsPassed) + " / " + string.Format("{0:00}:{1:00}", totalMinutes, totalSeconds);
		}
	}
}
