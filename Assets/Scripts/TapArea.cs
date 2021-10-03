using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TapArea : MonoBehaviour, IPointerDownHandler
{
    public AudioClip impact;
    public AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void OnPointerDown(PointerEventData eventData)

    {

        GameManager.Instance.CollectByTap(eventData.position, transform);
        audioSource.PlayOneShot(impact, 1.0f);
    }
}
