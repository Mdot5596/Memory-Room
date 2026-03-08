using UnityEngine;
using UnityEngine.UI;

public class PlayerInteraction : MonoBehaviour
{
    public Camera playerCamera;
    public Image lookImage;
    public float lookDistance = 3f;

    void Start()
    {
        lookImage.enabled = false;
    }

    void Update()
    {
        Ray ray = new Ray(playerCamera.transform.position, playerCamera.transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, lookDistance))
        {
            Interactable interactable = hit.collider.GetComponent<Interactable>();

            if (interactable != null && interactable.imageToShow != null)
            {
                lookImage.sprite = interactable.imageToShow;
                lookImage.enabled = true;
                return;
            }
        }

        lookImage.enabled = false;
    }
}
