using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayBackMenu : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [Tooltip("Reference to a UI image for fading in")]
    [SerializeField]
    private CanvasGroup cg;

    [Tooltip("Length of the fade")]
    [SerializeField]
    private float FadeTimer = 2f;

    [Tooltip("Delay until fades beghins")]
    [SerializeField]
    private float FadeInDelay = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void FadeOut(float val)
    {
        cg.alpha = (1f - val);
    }
    public void FadeIn(float val)
    {
        if (cg.alpha == 1) return;
        cg.alpha = (0f + val);
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        iTween.StopByName("PBFadeOut");
        iTween.ValueTo(gameObject, iTween.Hash("name", "PBFadeIn","from", 0f, "to", 3f, "delay", 0, "time", FadeTimer, "onupdate", "FadeIn"));
        Debug.Log("Mouse enter");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        iTween.StopByName("PBFadeIn");
        iTween.ValueTo(gameObject, iTween.Hash("name", "PBFadeOut","from", 0f, "to", 3f, "delay", FadeInDelay, "time", FadeTimer, "onupdate", "FadeOut"));
        Debug.Log("Mouse exit");
    }
}
