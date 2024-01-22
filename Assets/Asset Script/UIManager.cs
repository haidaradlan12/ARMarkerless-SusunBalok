using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    public RectTransform MenuOrnamenAtas, MenuOrnamenKiri, MenuOrnamenKanan, MenuPetunjuk, MenuInformasi, MenuButton, MenuLevel;
    // Start is called before the first frame update
    void Start()
    {
        MenuOrnamenAtas.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuOrnamenKiri.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuOrnamenKanan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, -2000), 1.0f);
        MenuInformasi.DOAnchorPos(new Vector2(0, -2000), 1.0f);
        MenuLevel.DOAnchorPos(new Vector2(0, -2000), 1.0f);
    }
    public void MenuKembalibutton()
    {
        MenuOrnamenAtas.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuOrnamenKiri.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuOrnamenKanan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, -2000), 1.0f);
        MenuInformasi.DOAnchorPos(new Vector2(0, -2000), 1.0f);
        MenuLevel.DOAnchorPos(new Vector2(0, -2000), 1.0f);
    }
    public void MenuInformasibutton()
    {
        MenuOrnamenAtas.DOAnchorPos(new Vector2(0, 2000), 1.0f);
        MenuOrnamenKiri.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        MenuOrnamenKanan.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, -2000), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, -2000), 1.0f);
        MenuInformasi.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuLevel.DOAnchorPos(new Vector2(0, -2000), 1.0f);
    }
    public void MenuPetunjukbutton()
    {
        MenuOrnamenAtas.DOAnchorPos(new Vector2(0, 2000), 1.0f);
        MenuOrnamenKiri.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        MenuOrnamenKanan.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, -2000), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuInformasi.DOAnchorPos(new Vector2(0, -2000), 1.0f);
        MenuLevel.DOAnchorPos(new Vector2(0, -2000), 1.0f);
    }
    public void MenuPlayButton()
    {
        MenuOrnamenAtas.DOAnchorPos(new Vector2(0, 2000), 1.0f);
        MenuOrnamenKiri.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        MenuOrnamenKanan.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, -2000), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, -2000), 1.0f);
        MenuInformasi.DOAnchorPos(new Vector2(0, -2000), 1.0f);
        MenuLevel.DOAnchorPos(new Vector2(0, 0), 1.0f);
    }

}
