using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public Slider volumeSlider;

    void Start()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("MusicVolume", 0.5f);
        MusicManager.Instance.SetVolume(volumeSlider.value);
    }

    public void OnVolumeChanged(float value)
    {
        MusicManager.Instance.SetVolume(value);
        PlayerPrefs.SetFloat("MusicVolume", value);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
