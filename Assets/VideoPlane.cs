using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class VideoPlane : MonoBehaviour
{
    public VideoPlayer video;
    public GameObject VideoPlayCanvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        video.renderMode = UnityEngine.Video.VideoRenderMode.CameraNearPlane;
        VideoPlayCanvas.SetActive(true);
    }
}
