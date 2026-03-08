using UnityEngine;

[CreateAssetMenu(fileName = "NewGravestoneData", menuName = "Memorial/Gravestone Data")]
public class GravestoneData : ScriptableObject
{
    [Header("Basic Information")]
    public string fullName;
    public string nickname;
    public string dateOfBirth;

    [Header("Visual")]
    public Sprite portraitImage;
}
