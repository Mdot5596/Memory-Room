using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Video;

public class MemoryUIController : MonoBehaviour
{

    public static bool uiOpen;

    [Header("Panels")]
    public GameObject memoryPanel;
    public GameObject choicePanel;
    public GameObject contentPanel;

    [Header("Memory Panel")]
    public Image portraitImage;
    public TextMeshProUGUI nameText;

    [Header("Content Views")]
    public GameObject photosView;
    public GameObject videosView;
    public GameObject wordsView;

    [Header("Video")]
    public VideoPlayer videoPlayer;

    [Header("Player Control")]
    public MonoBehaviour FirstPersonController;


    void Start()
    {
        CloseAll();
    }

    public void OpenMemory(Sprite portrait, string name)
    {
        uiOpen = true;
        ShowCursor();

        // Disable player control
        if (FirstPersonController != null)
            FirstPersonController.enabled = false;


        portraitImage.sprite = portrait;
        nameText.text = name;

        memoryPanel.SetActive(true);
        choicePanel.SetActive(false);
        contentPanel.SetActive(false);
    }

        void ShowCursor()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    void HideCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }


    public void RememberMore()
    {
        memoryPanel.SetActive(false);
        choicePanel.SetActive(true);
    }

    public void OpenPhotos()
    {
        OpenContent(photosView);
    }

    public void OpenVideos()
    {
        OpenContent(videosView);

        if (videoPlayer != null)
        {
            videoPlayer.Stop();
            videoPlayer.Play();
        }
    }


    public void OpenWords()
    {
        OpenContent(wordsView);
    }

void OpenContent(GameObject view)
{
    if (!contentPanel.activeSelf)
        contentPanel.SetActive(true);

    memoryPanel.SetActive(false);
    choicePanel.SetActive(false);

    photosView.SetActive(false);
    videosView.SetActive(false);
    wordsView.SetActive(false);

    view.SetActive(true);
}


    public void BackToChoices()
    {
        if (videoPlayer != null && videoPlayer.isPlaying)
            videoPlayer.Stop();

        contentPanel.SetActive(false);
        choicePanel.SetActive(true);
    }


public void CloseAll()
{
    if (videoPlayer != null)
        videoPlayer.Stop();

    uiOpen = false;
    HideCursor();

    // Re-enable player control
    if (FirstPersonController != null)
        FirstPersonController.enabled = true;

    memoryPanel.SetActive(false);
    choicePanel.SetActive(false);
    contentPanel.SetActive(false);
}

}
