using UnityEngine;
using UnityEngine.UI;

public class SelectSkins : MonoBehaviour
{
    [SerializeField] private Button[] playerSkinButtons;
    [SerializeField] private Button[] bgSkinButtons;
    [SerializeField] private Button[] pipeSkinButtons;

    private void Start()
    {
        UpdateButtonsInteractable();
    }

    private void UpdateButtonsInteractable()
    {
        EnableAllButtons();
        playerSkinButtons[PlayerPrefs.GetInt("PlayerSkin")].interactable = false;
        bgSkinButtons[PlayerPrefs.GetInt("BgSkin")].interactable = false;
        pipeSkinButtons[PlayerPrefs.GetInt("PipeSkin")].interactable = false;
    }

    private void EnableAllButtons()
    {
        foreach (var button in playerSkinButtons)
            button.interactable = true;

        foreach (var button in bgSkinButtons)
            button.interactable = true;

        foreach (var button in pipeSkinButtons)
            button.interactable = true;
    }

    public void ChangePlayerSkin(int skinNumber)
    {
        PlayerPrefs.SetInt("PlayerSkin", skinNumber);
        UpdateButtonsInteractable();
    }

    public void ChangeBgSkin(int skinNumber)
    {
        PlayerPrefs.SetInt("BgSkin", skinNumber);
        UpdateButtonsInteractable();
    }

    public void ChangePipeSkin(int skinNumber)
    {
        PlayerPrefs.SetInt("PipeSkin", skinNumber);
        UpdateButtonsInteractable();
    }
}
