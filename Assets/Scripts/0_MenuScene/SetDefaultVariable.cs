using UnityEngine;

public class SetDefaultVariable : MonoBehaviour
{
    private void Awake()
    {
        if (!PlayerPrefs.HasKey("BestScore"))
            PlayerPrefs.SetInt("BestScore", 0);

        if (!PlayerPrefs.HasKey("MusicVolume"))
            PlayerPrefs.SetInt("MusicVolume", 5);

        if (!PlayerPrefs.HasKey("SoundVolume"))
            PlayerPrefs.SetInt("SoundVolume", 5);

        if (!PlayerPrefs.HasKey("PlayerSkin"))
            PlayerPrefs.SetInt("PlayerSkin", (int)PlayerSkins.Yellow);

        if (!PlayerPrefs.HasKey("BgSkin"))
            PlayerPrefs.SetInt("BgSkin", (int)BgSkins.Day);

        if (!PlayerPrefs.HasKey("PipeSkin"))
            PlayerPrefs.SetInt("PipeSkin", (int)PipeSkins.Green);
    }
}
