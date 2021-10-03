using UnityEngine;

using UnityEngine.EventSystems;

 
// [RequireComponent(typeof(AudioSource))]
public class TapArea : MonoBehaviour, IPointerDownHandler

{
    public AudioClip impact;
    public AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void OnPointerDown (PointerEventData eventData)

    {

        GameManager.Instance.CollectByTap (eventData.position, transform);
        audioSource.PlayOneShot(impact, 1.0f);
    }

}