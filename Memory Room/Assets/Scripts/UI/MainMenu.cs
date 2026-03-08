using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenuPanel;    
    public GameObject joinWorldPanel;    

    public void LoadMyWorld()
    {
        SceneManager.LoadScene("Scene Level");
    }

    public void OpenJoinWorld()
    {
        mainMenuPanel.SetActive(false);
        joinWorldPanel.SetActive(true);
    }

    public void CloseJoinWorld()
    {
        joinWorldPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
    }
}
