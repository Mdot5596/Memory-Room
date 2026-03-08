using UnityEngine;
using TMPro;

public class Guestbook : MonoBehaviour
{
    public GameObject guestbookUI;
    public GameObject promptText;
    public MonoBehaviour playerMovement;

    bool playerInside = false;

    void Update()
    {
        if (playerInside && Input.GetKeyDown(KeyCode.E))
        {
            OpenBook();
        }

        if (guestbookUI.activeSelf && Input.GetKeyDown(KeyCode.Escape))
        {
            CloseBook();
        }
    }

    void OpenBook()
    {
        guestbookUI.SetActive(true);
        promptText.SetActive(false);

        playerMovement.enabled = false;

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void CloseBook()
    {
        guestbookUI.SetActive(false);

        playerMovement.enabled = true;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        if (playerInside)
        {
            promptText.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInside = true;
            promptText.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInside = false;
            promptText.SetActive(false);
        }
    }
}