using UnityEngine;

public class PlayerInteractor : MonoBehaviour
{
    public float interactDistance = 3f;
    public GameObject interactPrompt;

    private Camera cam;
    private Gravestone currentGravestone;

    void Start()
    {
        cam = Camera.main;
        interactPrompt.SetActive(false);
    }

void Update()
{
    if (MemoryUIController.uiOpen)
    {
        interactPrompt.SetActive(false);
        return;
    }

    Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
    RaycastHit hit;

    if (Physics.Raycast(ray, out hit, interactDistance))
    {
        Gravestone gravestone = hit.collider.GetComponent<Gravestone>();

        if (gravestone != null)
        {
            interactPrompt.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                gravestone.Interact();
                interactPrompt.SetActive(false);
            }

            return;
        }
    }

    interactPrompt.SetActive(false);
}
}