using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
public class VideoPlane : MonoBehaviour
{
    public VideoPlayer video;
    public GameObject VideoPlayCanvas;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<RawImage>().SizeToParent();

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
