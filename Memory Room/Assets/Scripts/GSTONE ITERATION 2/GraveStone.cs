using UnityEngine;

public class Gravestone : MonoBehaviour
{
    public Sprite portrait;
    public string personName;

    public MemoryUIController uiController;

    public void Interact()
    {
        uiController.OpenMemory(portrait, personName);
    }

    void OnMouseDown()
    {
        if (MemoryUIController.uiOpen)
            return;

        Interact();
    }


}
