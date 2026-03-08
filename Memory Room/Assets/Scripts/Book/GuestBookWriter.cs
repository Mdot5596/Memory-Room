using UnityEngine;
using TMPro;

public class GuestbookWriter : MonoBehaviour
{
    public TMP_InputField inputField;
    public TMP_Text bookText;

    public void WriteMessage()
    {
        string message = inputField.text;

        if (message != "")
        {
            bookText.text += "\n" + message;
            inputField.text = "";
        }
    }
}