using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class GazeInteractionBalok : MonoBehaviour
{
    //Level contorl
    int sceneIndex, levelPassed;
    //isi sendiri
    public Text TimerOFF;
    public int Jumlah3D;
    //Timer
    public Text TimerMinutes;
    public Text TimerSecond;
    private float startTime;
    private float stopTime;
    private float timerTime;
    private bool isRunning = false;
    
    //Program Level
    public GameObject TB, TB1, TB2, TB3, TB4, TB5, TB6, TB7, TB8, TB9, TB10, TB11, TB12, TB13, TB14, TB15, TB16, TB17, TB18, TB19, TB20;
    public GameObject TB21, TB22, TB23, TB24, TB25, TB26, TB27, TB28, TB29, TB30;

    public GameObject TM, TM1, TM2, TM3, TM4, TM5, TM6, TM7, TM8, TM9, TM10, TM11, TM12, TM13, TM14, TM15, TM16, TM17, TM18, TM19, TM20;
    public GameObject TM21, TM22, TM23, TM24, TM25, TM26, TM27, TM28, TM29, TM30;

    public GameObject TH, TH1, TH2, TH3, TH4, TH5, TH6, TH7, TH8, TH9, TH10, TH11, TH12, TH13, TH14, TH15, TH16, TH17, TH18, TH19, TH20;
    public GameObject TH21, TH22, TH23, TH24, TH25, TH26, TH27, TH28, TH29, TH30;

    public GameObject A, A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, A11, A12, A13, A14, A15, A16, A17, A18, A19, A20;
    public GameObject A21, A22, A23, A24, A25, A26, A27, A28, A29, A30;

    public GameObject J, J1, J2, J3, J4, J5, J6, J7, J8, J9, J10, J11, J12, J13, J14, J15, J16, J17, J18, J19, J20;
    public GameObject J21, J22, J23, J24, J25, J26, J27, J28, J29, J30;

    public GameObject UPertama, UBenar, UKeluar;
    int a, b, c, d;

    //PopUp
    public RectTransform MenuPopUp0, MenuPopUp1, MenuPopUp2, MenuPopUp3, MenuButton;
    public GameObject NextButton;

    void Start()
    {
        TimerReset();
        MenuPopUp0.DOAnchorPos(new Vector2(0, -2000), 1.0f);
        MenuPopUp1.DOAnchorPos(new Vector2(0, -2000), 1.0f);
        MenuPopUp2.DOAnchorPos(new Vector2(0, -2000), 1.0f);
        MenuPopUp3.DOAnchorPos(new Vector2(0, -2000), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, -2000), 1.0f);
        NextButton.SetActive(false);

        //Level Control
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        levelPassed = PlayerPrefs.GetInt("LevelPassed");
        // Mulai
        if (c == 0)
        {
            Mulai();
        }
        else if (c == 1)
        {
            FungsiKlikPertama();
        }
        else if (c == 2)
        {
            FungsiBS();
        }
        else
        {
            FungsiKlikKedua();
        }
    }
    void Update()
    {
        //Level Control
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        levelPassed = PlayerPrefs.GetInt("LevelPassed");

        // Mulai
        if (c==0)
        {
            Mulai();
        }
        else if (c==1)
        {
            FungsiKlikPertama();
        }
        else if (c==2)
        {
            FungsiBS();
        }
        else
        {
            FungsiKlikKedua();
        }
        
        // Selesai
        if (d < Jumlah3D)
        {
            if (TimerMinutes.text == TimerOFF.text)
            {
                TimerStop();
                if (d < (Jumlah3D/4))
                {
                    MenuPopUp0.DOAnchorPos(new Vector2(0, 0), 1.0f);
                    MenuPopUp1.DOAnchorPos(new Vector2(0, -2000), 1.0f);
                    MenuPopUp2.DOAnchorPos(new Vector2(0, -2000), 1.0f);
                    MenuPopUp3.DOAnchorPos(new Vector2(0, -2000), 1.0f);
                    MenuButton.DOAnchorPos(new Vector2(0, 0), 1.0f);
                    NextButton.SetActive(false);
                }
                else if ((d >= (Jumlah3D/4)) && (d < (Jumlah3D/2)))
                {
                    MenuPopUp0.DOAnchorPos(new Vector2(0, 0), 1.0f);
                    MenuPopUp1.DOAnchorPos(new Vector2(0, 0), 1.0f);
                    MenuPopUp2.DOAnchorPos(new Vector2(0, -2000), 1.0f);
                    MenuPopUp3.DOAnchorPos(new Vector2(0, -2000), 1.0f);
                    MenuButton.DOAnchorPos(new Vector2(0, 0), 1.0f);
                    NextButton.SetActive(true);
                }
                else if ((d >= (Jumlah3D/2)) && (d < (Jumlah3D/0.75)))
                {
                    MenuPopUp0.DOAnchorPos(new Vector2(0, 0), 1.0f);
                    MenuPopUp1.DOAnchorPos(new Vector2(0, 0), 1.0f);
                    MenuPopUp2.DOAnchorPos(new Vector2(0, 0), 1.0f);
                    MenuPopUp3.DOAnchorPos(new Vector2(0, -2000), 1.0f);
                    MenuButton.DOAnchorPos(new Vector2(0, 0), 1.0f);
                    NextButton.SetActive(true);
                }
                else if ((d >= (Jumlah3D/0.75)))
                {
                    MenuPopUp0.DOAnchorPos(new Vector2(0, 0), 1.0f);
                    MenuPopUp1.DOAnchorPos(new Vector2(0, 0), 1.0f);
                    MenuPopUp2.DOAnchorPos(new Vector2(0, 0), 1.0f);
                    MenuPopUp3.DOAnchorPos(new Vector2(0, 0), 1.0f);
                    MenuButton.DOAnchorPos(new Vector2(0, 0), 1.0f);
                    NextButton.SetActive(true);
                }
                else
                {
                    MenuPopUp0.DOAnchorPos(new Vector2(0, 0), 1.0f);
                    MenuPopUp1.DOAnchorPos(new Vector2(0, -2000), 1.0f);
                    MenuPopUp2.DOAnchorPos(new Vector2(0, -2000), 1.0f);
                    MenuPopUp3.DOAnchorPos(new Vector2(0, -2000), 1.0f);
                    MenuButton.DOAnchorPos(new Vector2(0, 0), 1.0f);
                    NextButton.SetActive(false);
                }
            }
        }
        else
        {
            TimerStop();
            MenuPopUp0.DOAnchorPos(new Vector2(0, 0), 1.0f);
            MenuPopUp1.DOAnchorPos(new Vector2(0, 0), 1.0f);
            MenuPopUp2.DOAnchorPos(new Vector2(0, 0), 1.0f);
            MenuPopUp3.DOAnchorPos(new Vector2(0, 0), 1.0f);
            MenuButton.DOAnchorPos(new Vector2(0, 0), 1.0f);
            NextButton.SetActive(true);
        }

        //Timer
        timerTime = stopTime + (Time.time - startTime);
        int minutesInt = (int)timerTime / 60;
        int secondsInt = (int)timerTime % 60;

        if (isRunning)
        {
            TimerMinutes.text = (minutesInt < 10) ? "0" + minutesInt : minutesInt.ToString();
            TimerSecond.text = (secondsInt < 10) ? "0" + secondsInt : secondsInt.ToString();
        }
    }
    
    //Timer
    public void TimerStart()
    {
        if (!isRunning)
        {
            isRunning = true;
            startTime = Time.time;
        }
    }
    public void TimerStop()
    {
        if (isRunning)
        {
            isRunning = false;
            stopTime = timerTime;
        }
    }
    public void TimerReset()
    {
        TimerMinutes.text = TimerSecond.text = "00";
    }

    //3D Level
    void Mulai()
    {
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
        {
            GameObject go = hit.collider.gameObject;
            if (go.CompareTag("1A"))
            {
                UPertama.SetActive(true);
            }
            else if (go.CompareTag("2A"))
            {
                UPertama.SetActive(true);
            }
            else if (go.CompareTag("3A"))
            {
                UPertama.SetActive(true);
            }
            else if (go.CompareTag("4A"))
            {
                UPertama.SetActive(true);
            }
            else if (go.CompareTag("5A"))
            {
                UPertama.SetActive(true);
            }
            else if (go.CompareTag("6A"))
            {
                UPertama.SetActive(true);
            }
            else if (go.CompareTag("7A"))
            {
                UPertama.SetActive(true);
            }
            else if (go.CompareTag("8A"))
            {
                UPertama.SetActive(true);
            }
            else if (go.CompareTag("9A"))
            {
                UPertama.SetActive(true);
            }
            else if (go.CompareTag("10A"))
            {
                UPertama.SetActive(true);
            }
            else if (go.CompareTag("11A"))
            {
                UPertama.SetActive(true);
            }
            else if (go.CompareTag("12A"))
            {
                UPertama.SetActive(true);
            }
            else if (go.CompareTag("13A"))
            {
                UPertama.SetActive(true);
            }
            else if (go.CompareTag("14A"))
            {
                UPertama.SetActive(true);
            }
            else if (go.CompareTag("15A"))
            {
                UPertama.SetActive(true);
            }
            else if (go.CompareTag("16A"))
            {
                UPertama.SetActive(true);
            }
            else if (go.CompareTag("17A"))
            {
                UPertama.SetActive(true);
            }
            else if (go.CompareTag("18A"))
            {
                UPertama.SetActive(true);
            }
            else if (go.CompareTag("19A"))
            {
                UPertama.SetActive(true);
            }
            else if (go.CompareTag("20A"))
            {
                UPertama.SetActive(true);
            }
            else if (go.CompareTag("21A"))
            {
                UPertama.SetActive(true);
            }
            else if (go.CompareTag("22A"))
            {
                UPertama.SetActive(true);
            }
            else if (go.CompareTag("23A"))
            {
                UPertama.SetActive(true);
            }
            else if (go.CompareTag("24A"))
            {
                UPertama.SetActive(true);
            }
            else if (go.CompareTag("25A"))
            {
                UPertama.SetActive(true);
            }
            else if (go.CompareTag("26A"))
            {
                UPertama.SetActive(true);
            }
            else if (go.CompareTag("27A"))
            {
                UPertama.SetActive(true);
            }
            else if (go.CompareTag("28A"))
            {
                UPertama.SetActive(true);
            }
            else if (go.CompareTag("29A"))
            {
                UPertama.SetActive(true);
            }
            else if (go.CompareTag("30A"))
            {
                UPertama.SetActive(true);
            }
            else
            {
                UPertama.SetActive(false);
            }
        }
        else
        {
            UPertama.SetActive(false);
        }
    }
    public void FungsiUPertama()
    {
        c = 1;
    }
    void FungsiKlikPertama()
    {
       if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
        {
            GameObject go = hit.collider.gameObject;
            if (go.CompareTag("1A"))
            {
                GameObject.Find("1A").SetActive(false);
                a = 1;
                FungsiBS();
                c = 2;
            }
            else if (go.CompareTag("2A"))
            {
                GameObject.Find("2A").SetActive(false);
                a = 2;
                FungsiBS();
                c = 2;
            }
            else if (go.CompareTag("3A"))
            {
                GameObject.Find("3A").SetActive(false);
                a = 3;
                FungsiBS();
                c = 2;
            }
            else if (go.CompareTag("4A"))
            {
                GameObject.Find("4A").SetActive(false);
                a = 4;
                FungsiBS();
                c = 2;
            }
            else if (go.CompareTag("5A"))
            {
                GameObject.Find("5A").SetActive(false);
                a = 5;
                FungsiBS();
                c = 2;
            }
            else if (go.CompareTag("6A"))
            {
                GameObject.Find("6A").SetActive(false);
                a = 6;
                FungsiBS();
                c = 2;

            }
            else if (go.CompareTag("7A"))
            {
                GameObject.Find("7A").SetActive(false);
                a = 7;
                FungsiBS();
                c = 2;
            }
            else if (go.CompareTag("8A"))
            {
                GameObject.Find("8A").SetActive(false);
                a = 8;
                FungsiBS();
                c = 2;
            }
            else if (go.CompareTag("9A"))
            {
                GameObject.Find("9A").SetActive(false);
                a = 9;
                FungsiBS();
                c = 2;
            }
            else if (go.CompareTag("10A"))
            {
                GameObject.Find("10A").SetActive(false);
                a = 10;
                FungsiBS();
                c = 2;
            }
            else if (go.CompareTag("11A"))
            {
                GameObject.Find("11A").SetActive(false);
                a = 11;
                FungsiBS();
                c = 2;
            }
            else if (go.CompareTag("12A"))
            {
                GameObject.Find("12A").SetActive(false);
                a = 12;
                FungsiBS();
                c = 2;
            }
            else if (go.CompareTag("13A"))
            {
                GameObject.Find("13A").SetActive(false);
                a = 13;
                FungsiBS();
                c = 2;
            }
            else if (go.CompareTag("14A"))
            {
                GameObject.Find("14A").SetActive(false);
                a = 14;
                FungsiBS();
                c = 2;
            }
            else if (go.CompareTag("15A"))
            {
                 GameObject.Find("15A").SetActive(false);
                a = 15;
                FungsiBS();
                c = 2;
            }
            else if (go.CompareTag("16A"))
            {
                GameObject.Find("16A").SetActive(false);
                a = 16;
                FungsiBS();
                c = 2;
            }
            else if (go.CompareTag("17A"))
            {
                 GameObject.Find("17A").SetActive(false);
                a = 17;
                FungsiBS();
                c = 2;
            }
            else if (go.CompareTag("18A"))
            {
                GameObject.Find("18A").SetActive(false);
                a = 18;
                FungsiBS();
                c = 2;
            }
            else if (go.CompareTag("19A"))
            {
                GameObject.Find("19A").SetActive(false);
                a = 19;
                FungsiBS();
                c = 2;
            }
            else if (go.CompareTag("20A"))
            {
                GameObject.Find("20A").SetActive(false);
                a = 20;
                FungsiBS();
                c = 2;
            }
            else if (go.CompareTag("21A"))
            {
                GameObject.Find("21A").SetActive(false);
                a = 21;
                FungsiBS();
                c = 2;
            }
            else if (go.CompareTag("22A"))
            {
                GameObject.Find("22A").SetActive(false);
                a = 22;
                FungsiBS();
                c = 2;
            }
            else if (go.CompareTag("23A"))
            {
                 GameObject.Find("23A").SetActive(false);
                a = 23;
                FungsiBS();
                c = 2;
            }
            else if (go.CompareTag("24A"))
            {
                GameObject.Find("24A").SetActive(false);
                a = 24;
                FungsiBS();
                c = 2;
            }
            else if (go.CompareTag("25A"))
            {
               GameObject.Find("25A").SetActive(false);
                a = 25;
                FungsiBS();
                c = 2;
            }
            else if (go.CompareTag("26A"))
            {
                GameObject.Find("26A").SetActive(false);
                a = 26;
                FungsiBS();
                c = 2;
            }
            else if (go.CompareTag("27A"))
            {
                GameObject.Find("27A").SetActive(false);
                a = 27;
                FungsiBS();
                c = 2;
            }
            else if (go.CompareTag("28A"))
            {
                GameObject.Find("28A").SetActive(false);
                a = 28;
                FungsiBS();
                c = 2;
            }
            else if (go.CompareTag("29A"))
            {
                 GameObject.Find("29A").SetActive(false);
                a = 29;
                FungsiBS();
                c = 2;
            }
            else if (go.CompareTag("30A"))
            {
                GameObject.Find("30A").SetActive(false);
                a = 30;
                FungsiBS();
                c = 2;
            }
            else
            {
               
            }
        }
        else
        {
            
        }
    }
    void FungsiBS()
    {
        if (a == 1) 
        {
            if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
            {
                GameObject go = hit.collider.gameObject;
                if (go.CompareTag("1B"))
                {
                    TH1.SetActive(true);
                    TM1.SetActive(false);
                    UBenar.SetActive(true);
                    b = 1;
                }
                else if (go.CompareTag("2B"))
                {
                    TH2.SetActive(false);
                    TM2.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("3B"))
                {
                    TH3.SetActive(false);
                    TM3.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("4B"))
                {
                    TH4.SetActive(false);
                    TM4.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("5B"))
                {
                    TH5.SetActive(false);
                    TM5.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("6B"))
                {
                    TH6.SetActive(false);
                    TM6.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("7B"))
                {
                    TH7.SetActive(false);
                    TM7.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("8B"))
                {
                    TH8.SetActive(false);
                    TM8.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("9B"))
                {
                    TH9.SetActive(false);
                    TM9.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("10B"))
                {
                    TH10.SetActive(false);
                    TM10.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("11B"))
                {
                    TH11.SetActive(false);
                    TM11.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("12B"))
                {
                    TH12.SetActive(false);
                    TM12.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("13B"))
                {
                    TH13.SetActive(false);
                    TM13.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("14B"))
                {
                    TH14.SetActive(false);
                    TM14.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("15B"))
                {
                    TH15.SetActive(false);
                    TM15.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("16B"))
                {
                    TH16.SetActive(false);
                    TM16.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("17B"))
                {
                    TH17.SetActive(false);
                    TM17.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("18B"))
                {
                    TH18.SetActive(false);
                    TM18.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("19B"))
                {
                    TH19.SetActive(false);
                    TM19.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("20B"))
                {
                    TH20.SetActive(false);
                    TM20.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("21B"))
                {
                    TH21.SetActive(false);
                    TM21.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("22B"))
                {
                    TH22.SetActive(false);
                    TM22.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("23B"))
                {
                    TH23.SetActive(false);
                    TM23.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("24B"))
                {
                    TH24.SetActive(false);
                    TM24.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("25B"))
                {
                    TH25.SetActive(false);
                    TM25.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("26B"))
                {
                    TH26.SetActive(false);
                    TM26.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("27B"))
                {
                    TH27.SetActive(false);
                    TM27.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("28B"))
                {
                    TH28.SetActive(false);
                    TM28.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("29B"))
                {
                    TH29.SetActive(false);
                    TM29.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("30B"))
                {
                    TH30.SetActive(false);
                    TM30.SetActive(true);
                    UBenar.SetActive(false);
                }
                else
                {
                    TB.SetActive(true);
                    TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                    TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                    TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                    TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                    TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                    TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                    UBenar.SetActive(false);
                }
            }
            else
            {
                TB.SetActive(true);
                TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                UBenar.SetActive(false);
            }
        }
        else if (a == 2)
        {
            if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
            {
                GameObject go = hit.collider.gameObject;
                if (go.CompareTag("2B"))
                {
                    TH2.SetActive(true);
                    TM2.SetActive(false);
                    UBenar.SetActive(true);
                    b = 2;
                }
                else if (go.CompareTag("1B"))
                {
                    TH1.SetActive(false);
                    TM1.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("3B"))
                {
                    TH3.SetActive(false);
                    TM3.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("4B"))
                {
                    TH4.SetActive(false);
                    TM4.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("5B"))
                {
                    TH5.SetActive(false);
                    TM5.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("6B"))
                {
                    TH6.SetActive(false);
                    TM6.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("7B"))
                {
                    TH7.SetActive(false);
                    TM7.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("8B"))
                {
                    TH8.SetActive(false);
                    TM8.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("9B"))
                {
                    TH9.SetActive(false);
                    TM9.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("10B"))
                {
                    TH10.SetActive(false);
                    TM10.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("11B"))
                {
                    TH11.SetActive(false);
                    TM11.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("12B"))
                {
                    TH12.SetActive(false);
                    TM12.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("13B"))
                {
                    TH13.SetActive(false);
                    TM13.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("14B"))
                {
                    TH14.SetActive(false);
                    TM14.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("15B"))
                {
                    TH15.SetActive(false);
                    TM15.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("16B"))
                {
                    TH16.SetActive(false);
                    TM16.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("17B"))
                {
                    TH17.SetActive(false);
                    TM17.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("18B"))
                {
                    TH18.SetActive(false);
                    TM18.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("19B"))
                {
                    TH19.SetActive(false);
                    TM19.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("20B"))
                {
                    TH20.SetActive(false);
                    TM20.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("21B"))
                {
                    TH21.SetActive(false);
                    TM21.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("22B"))
                {
                    TH22.SetActive(false);
                    TM22.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("23B"))
                {
                    TH23.SetActive(false);
                    TM23.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("24B"))
                {
                    TH24.SetActive(false);
                    TM24.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("25B"))
                {
                    TH25.SetActive(false);
                    TM25.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("26B"))
                {
                    TH26.SetActive(false);
                    TM26.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("27B"))
                {
                    TH27.SetActive(false);
                    TM27.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("28B"))
                {
                    TH28.SetActive(false);
                    TM28.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("29B"))
                {
                    TH29.SetActive(false);
                    TM29.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("30B"))
                {
                    TH30.SetActive(false);
                    TM30.SetActive(true);
                    UBenar.SetActive(false);
                }
                else
                {
                    TB.SetActive(true);
                    TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                    TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                    TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                    TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                    TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                    TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                    UBenar.SetActive(false);
                }
            }
            else
            {
                TB.SetActive(true);
                TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                UBenar.SetActive(false);
            }
        }
        else if (a == 3)
        {
            if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
            {
                GameObject go = hit.collider.gameObject;
                if (go.CompareTag("3B"))
                {
                    TH3.SetActive(true);
                    TM3.SetActive(false);
                    UBenar.SetActive(true);
                    b = 3;
                }
                else if (go.CompareTag("2B"))
                {
                    TH2.SetActive(false);
                    TM2.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("1B"))
                {
                    TH1.SetActive(false);
                    TM1.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("4B"))
                {
                    TH4.SetActive(false);
                    TM4.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("5B"))
                {
                    TH5.SetActive(false);
                    TM5.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("6B"))
                {
                    TH6.SetActive(false);
                    TM6.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("7B"))
                {
                    TH7.SetActive(false);
                    TM7.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("8B"))
                {
                    TH8.SetActive(false);
                    TM8.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("9B"))
                {
                    TH9.SetActive(false);
                    TM9.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("10B"))
                {
                    TH10.SetActive(false);
                    TM10.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("11B"))
                {
                    TH11.SetActive(false);
                    TM11.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("12B"))
                {
                    TH12.SetActive(false);
                    TM12.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("13B"))
                {
                    TH13.SetActive(false);
                    TM13.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("14B"))
                {
                    TH14.SetActive(false);
                    TM14.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("15B"))
                {
                    TH15.SetActive(false);
                    TM15.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("16B"))
                {
                    TH16.SetActive(false);
                    TM16.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("17B"))
                {
                    TH17.SetActive(false);
                    TM17.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("18B"))
                {
                    TH18.SetActive(false);
                    TM18.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("19B"))
                {
                    TH19.SetActive(false);
                    TM19.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("20B"))
                {
                    TH20.SetActive(false);
                    TM20.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("21B"))
                {
                    TH21.SetActive(false);
                    TM21.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("22B"))
                {
                    TH22.SetActive(false);
                    TM22.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("23B"))
                {
                    TH23.SetActive(false);
                    TM23.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("24B"))
                {
                    TH24.SetActive(false);
                    TM24.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("25B"))
                {
                    TH25.SetActive(false);
                    TM25.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("26B"))
                {
                    TH26.SetActive(false);
                    TM26.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("27B"))
                {
                    TH27.SetActive(false);
                    TM27.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("28B"))
                {
                    TH28.SetActive(false);
                    TM28.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("29B"))
                {
                    TH29.SetActive(false);
                    TM29.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("30B"))
                {
                    TH30.SetActive(false);
                    TM30.SetActive(true);
                    UBenar.SetActive(false);
                }
                else
                {
                    TB.SetActive(true);
                    TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                    TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                    TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                    TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                    TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                    TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                    UBenar.SetActive(false);
                }
            }
            else
            {
                TB.SetActive(true);
                TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                UBenar.SetActive(false);
            }
        }
        else if (a == 4)
        {
            if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
            {
                GameObject go = hit.collider.gameObject;
                if (go.CompareTag("4B"))
                {
                    TH4.SetActive(true);
                    TM4.SetActive(false);
                    UBenar.SetActive(true);
                    b = 4;
                }
                else if (go.CompareTag("2B"))
                {
                    TH2.SetActive(false);
                    TM2.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("3B"))
                {
                    TH3.SetActive(false);
                    TM3.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("1B"))
                {
                    TH1.SetActive(false);
                    TM1.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("5B"))
                {
                    TH5.SetActive(false);
                    TM5.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("6B"))
                {
                    TH6.SetActive(false);
                    TM6.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("7B"))
                {
                    TH7.SetActive(false);
                    TM7.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("8B"))
                {
                    TH8.SetActive(false);
                    TM8.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("9B"))
                {
                    TH9.SetActive(false);
                    TM9.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("10B"))
                {
                    TH10.SetActive(false);
                    TM10.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("11B"))
                {
                    TH11.SetActive(false);
                    TM11.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("12B"))
                {
                    TH12.SetActive(false);
                    TM12.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("13B"))
                {
                    TH13.SetActive(false);
                    TM13.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("14B"))
                {
                    TH14.SetActive(false);
                    TM14.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("15B"))
                {
                    TH15.SetActive(false);
                    TM15.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("16B"))
                {
                    TH16.SetActive(false);
                    TM16.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("17B"))
                {
                    TH17.SetActive(false);
                    TM17.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("18B"))
                {
                    TH18.SetActive(false);
                    TM18.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("19B"))
                {
                    TH19.SetActive(false);
                    TM19.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("20B"))
                {
                    TH20.SetActive(false);
                    TM20.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("21B"))
                {
                    TH21.SetActive(false);
                    TM21.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("22B"))
                {
                    TH22.SetActive(false);
                    TM22.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("23B"))
                {
                    TH23.SetActive(false);
                    TM23.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("24B"))
                {
                    TH24.SetActive(false);
                    TM24.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("25B"))
                {
                    TH25.SetActive(false);
                    TM25.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("26B"))
                {
                    TH26.SetActive(false);
                    TM26.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("27B"))
                {
                    TH27.SetActive(false);
                    TM27.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("28B"))
                {
                    TH28.SetActive(false);
                    TM28.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("29B"))
                {
                    TH29.SetActive(false);
                    TM29.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("30B"))
                {
                    TH30.SetActive(false);
                    TM30.SetActive(true);
                    UBenar.SetActive(false);
                }
                else
                {
                    TB.SetActive(true);
                    TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                    TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                    TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                    TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                    TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                    TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                    UBenar.SetActive(false);
                }
            }
            else
            {
                TB.SetActive(true);
                TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                UBenar.SetActive(false);
            }
        }
        else if (a == 5)
        {
            if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
            {
                GameObject go = hit.collider.gameObject;
                if (go.CompareTag("5B"))
                {
                    TH5.SetActive(true);
                    TM5.SetActive(false);
                    UBenar.SetActive(true);
                    b = 5;
                }
                else if (go.CompareTag("2B"))
                {
                    TH2.SetActive(false);
                    TM2.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("3B"))
                {
                    TH3.SetActive(false);
                    TM3.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("4B"))
                {
                    TH4.SetActive(false);
                    TM4.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("1B"))
                {
                    TH1.SetActive(false);
                    TM1.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("6B"))
                {
                    TH6.SetActive(false);
                    TM6.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("7B"))
                {
                    TH7.SetActive(false);
                    TM7.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("8B"))
                {
                    TH8.SetActive(false);
                    TM8.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("9B"))
                {
                    TH9.SetActive(false);
                    TM9.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("10B"))
                {
                    TH10.SetActive(false);
                    TM10.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("11B"))
                {
                    TH11.SetActive(false);
                    TM11.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("12B"))
                {
                    TH12.SetActive(false);
                    TM12.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("13B"))
                {
                    TH13.SetActive(false);
                    TM13.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("14B"))
                {
                    TH14.SetActive(false);
                    TM14.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("15B"))
                {
                    TH15.SetActive(false);
                    TM15.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("16B"))
                {
                    TH16.SetActive(false);
                    TM16.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("17B"))
                {
                    TH17.SetActive(false);
                    TM17.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("18B"))
                {
                    TH18.SetActive(false);
                    TM18.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("19B"))
                {
                    TH19.SetActive(false);
                    TM19.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("20B"))
                {
                    TH20.SetActive(false);
                    TM20.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("21B"))
                {
                    TH21.SetActive(false);
                    TM21.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("22B"))
                {
                    TH22.SetActive(false);
                    TM22.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("23B"))
                {
                    TH23.SetActive(false);
                    TM23.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("24B"))
                {
                    TH24.SetActive(false);
                    TM24.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("25B"))
                {
                    TH25.SetActive(false);
                    TM25.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("26B"))
                {
                    TH26.SetActive(false);
                    TM26.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("27B"))
                {
                    TH27.SetActive(false);
                    TM27.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("28B"))
                {
                    TH28.SetActive(false);
                    TM28.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("29B"))
                {
                    TH29.SetActive(false);
                    TM29.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("30B"))
                {
                    TH30.SetActive(false);
                    TM30.SetActive(true);
                    UBenar.SetActive(false);
                }
                else
                {
                    TB.SetActive(true);
                    TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                    TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                    TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                    TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                    TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                    TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                    UBenar.SetActive(false);
                }
            }
            else
            {
                TB.SetActive(true);
                TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                UBenar.SetActive(false);
            }
        }
        else if (a == 6)
        {
            if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
            {
                GameObject go = hit.collider.gameObject;
                if (go.CompareTag("6B"))
                {
                    TH6.SetActive(true);
                    TM6.SetActive(false);
                    UBenar.SetActive(true);
                    b = 6;
                }
                else if (go.CompareTag("2B"))
                {
                    TH2.SetActive(false);
                    TM2.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("3B"))
                {
                    TH3.SetActive(false);
                    TM3.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("4B"))
                {
                    TH4.SetActive(false);
                    TM4.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("5B"))
                {
                    TH5.SetActive(false);
                    TM5.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("1B"))
                {
                    TH1.SetActive(false);
                    TM1.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("7B"))
                {
                    TH7.SetActive(false);
                    TM7.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("8B"))
                {
                    TH8.SetActive(false);
                    TM8.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("9B"))
                {
                    TH9.SetActive(false);
                    TM9.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("10B"))
                {
                    TH10.SetActive(false);
                    TM10.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("11B"))
                {
                    TH11.SetActive(false);
                    TM11.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("12B"))
                {
                    TH12.SetActive(false);
                    TM12.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("13B"))
                {
                    TH13.SetActive(false);
                    TM13.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("14B"))
                {
                    TH14.SetActive(false);
                    TM14.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("15B"))
                {
                    TH15.SetActive(false);
                    TM15.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("16B"))
                {
                    TH16.SetActive(false);
                    TM16.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("17B"))
                {
                    TH17.SetActive(false);
                    TM17.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("18B"))
                {
                    TH18.SetActive(false);
                    TM18.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("19B"))
                {
                    TH19.SetActive(false);
                    TM19.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("20B"))
                {
                    TH20.SetActive(false);
                    TM20.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("21B"))
                {
                    TH21.SetActive(false);
                    TM21.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("22B"))
                {
                    TH22.SetActive(false);
                    TM22.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("23B"))
                {
                    TH23.SetActive(false);
                    TM23.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("24B"))
                {
                    TH24.SetActive(false);
                    TM24.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("25B"))
                {
                    TH25.SetActive(false);
                    TM25.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("26B"))
                {
                    TH26.SetActive(false);
                    TM26.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("27B"))
                {
                    TH27.SetActive(false);
                    TM27.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("28B"))
                {
                    TH28.SetActive(false);
                    TM28.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("29B"))
                {
                    TH29.SetActive(false);
                    TM29.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("30B"))
                {
                    TH30.SetActive(false);
                    TM30.SetActive(true);
                    UBenar.SetActive(false);
                }
                else
                {
                    TB.SetActive(true);
                    TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                    TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                    TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                    TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                    TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                    TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                    UBenar.SetActive(false);
                }
            }
            else
            {
                TB.SetActive(true);
                TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                UBenar.SetActive(false);
            }
        }
        else if (a == 7)
        {
            if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
            {
                GameObject go = hit.collider.gameObject;
                if (go.CompareTag("7B"))
                {
                    TH7.SetActive(true);
                    TM7.SetActive(false);
                    UBenar.SetActive(true);
                    b = 7;
                }
                else if (go.CompareTag("2B"))
                {
                    TH2.SetActive(false);
                    TM2.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("3B"))
                {
                    TH3.SetActive(false);
                    TM3.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("4B"))
                {
                    TH4.SetActive(false);
                    TM4.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("5B"))
                {
                    TH5.SetActive(false);
                    TM5.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("6B"))
                {
                    TH6.SetActive(false);
                    TM6.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("1B"))
                {
                    TH1.SetActive(false);
                    TM1.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("8B"))
                {
                    TH8.SetActive(false);
                    TM8.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("9B"))
                {
                    TH9.SetActive(false);
                    TM9.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("10B"))
                {
                    TH10.SetActive(false);
                    TM10.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("11B"))
                {
                    TH11.SetActive(false);
                    TM11.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("12B"))
                {
                    TH12.SetActive(false);
                    TM12.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("13B"))
                {
                    TH13.SetActive(false);
                    TM13.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("14B"))
                {
                    TH14.SetActive(false);
                    TM14.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("15B"))
                {
                    TH15.SetActive(false);
                    TM15.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("16B"))
                {
                    TH16.SetActive(false);
                    TM16.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("17B"))
                {
                    TH17.SetActive(false);
                    TM17.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("18B"))
                {
                    TH18.SetActive(false);
                    TM18.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("19B"))
                {
                    TH19.SetActive(false);
                    TM19.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("20B"))
                {
                    TH20.SetActive(false);
                    TM20.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("21B"))
                {
                    TH21.SetActive(false);
                    TM21.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("22B"))
                {
                    TH22.SetActive(false);
                    TM22.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("23B"))
                {
                    TH23.SetActive(false);
                    TM23.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("24B"))
                {
                    TH24.SetActive(false);
                    TM24.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("25B"))
                {
                    TH25.SetActive(false);
                    TM25.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("26B"))
                {
                    TH26.SetActive(false);
                    TM26.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("27B"))
                {
                    TH27.SetActive(false);
                    TM27.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("28B"))
                {
                    TH28.SetActive(false);
                    TM28.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("29B"))
                {
                    TH29.SetActive(false);
                    TM29.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("30B"))
                {
                    TH30.SetActive(false);
                    TM30.SetActive(true);
                    UBenar.SetActive(false);
                }
                else
                {
                    TB.SetActive(true);
                    TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                    TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                    TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                    TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                    TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                    TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                    UBenar.SetActive(false);
                }
            }
            else
            {
                TB.SetActive(true);
                TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                UBenar.SetActive(false);
            }
        }
        else if (a == 8)
        {
            if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
            {
                GameObject go = hit.collider.gameObject;
                if (go.CompareTag("8B"))
                {
                    TH8.SetActive(true);
                    TM8.SetActive(false);
                    UBenar.SetActive(true);
                    b = 8;
                }
                else if (go.CompareTag("2B"))
                {
                    TH2.SetActive(false);
                    TM2.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("3B"))
                {
                    TH3.SetActive(false);
                    TM3.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("4B"))
                {
                    TH4.SetActive(false);
                    TM4.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("5B"))
                {
                    TH5.SetActive(false);
                    TM5.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("6B"))
                {
                    TH6.SetActive(false);
                    TM6.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("7B"))
                {
                    TH7.SetActive(false);
                    TM7.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("1B"))
                {
                    TH1.SetActive(false);
                    TM1.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("9B"))
                {
                    TH9.SetActive(false);
                    TM9.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("10B"))
                {
                    TH10.SetActive(false);
                    TM10.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("11B"))
                {
                    TH11.SetActive(false);
                    TM11.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("12B"))
                {
                    TH12.SetActive(false);
                    TM12.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("13B"))
                {
                    TH13.SetActive(false);
                    TM13.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("14B"))
                {
                    TH14.SetActive(false);
                    TM14.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("15B"))
                {
                    TH15.SetActive(false);
                    TM15.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("16B"))
                {
                    TH16.SetActive(false);
                    TM16.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("17B"))
                {
                    TH17.SetActive(false);
                    TM17.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("18B"))
                {
                    TH18.SetActive(false);
                    TM18.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("19B"))
                {
                    TH19.SetActive(false);
                    TM19.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("20B"))
                {
                    TH20.SetActive(false);
                    TM20.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("21B"))
                {
                    TH21.SetActive(false);
                    TM21.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("22B"))
                {
                    TH22.SetActive(false);
                    TM22.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("23B"))
                {
                    TH23.SetActive(false);
                    TM23.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("24B"))
                {
                    TH24.SetActive(false);
                    TM24.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("25B"))
                {
                    TH25.SetActive(false);
                    TM25.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("26B"))
                {
                    TH26.SetActive(false);
                    TM26.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("27B"))
                {
                    TH27.SetActive(false);
                    TM27.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("28B"))
                {
                    TH28.SetActive(false);
                    TM28.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("29B"))
                {
                    TH29.SetActive(false);
                    TM29.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("30B"))
                {
                    TH30.SetActive(false);
                    TM30.SetActive(true);
                    UBenar.SetActive(false);
                }
                else
                {
                    TB.SetActive(true);
                    TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                    TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                    TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                    TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                    TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                    TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                    UBenar.SetActive(false);
                }
            }
            else
            {
                TB.SetActive(true);
                TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                UBenar.SetActive(false);
            }
        }
        else if (a == 9)
        {
            if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
            {
                GameObject go = hit.collider.gameObject;
                if (go.CompareTag("9B"))
                {
                    TH9.SetActive(true);
                    TM9.SetActive(false);
                    UBenar.SetActive(true);
                    b = 9;
                }
                else if (go.CompareTag("2B"))
                {
                    TH2.SetActive(false);
                    TM2.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("3B"))
                {
                    TH3.SetActive(false);
                    TM3.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("4B"))
                {
                    TH4.SetActive(false);
                    TM4.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("5B"))
                {
                    TH5.SetActive(false);
                    TM5.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("6B"))
                {
                    TH6.SetActive(false);
                    TM6.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("7B"))
                {
                    TH7.SetActive(false);
                    TM7.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("8B"))
                {
                    TH8.SetActive(false);
                    TM8.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("1B"))
                {
                    TH1.SetActive(false);
                    TM1.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("10B"))
                {
                    TH10.SetActive(false);
                    TM10.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("11B"))
                {
                    TH11.SetActive(false);
                    TM11.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("12B"))
                {
                    TH12.SetActive(false);
                    TM12.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("13B"))
                {
                    TH13.SetActive(false);
                    TM13.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("14B"))
                {
                    TH14.SetActive(false);
                    TM14.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("15B"))
                {
                    TH15.SetActive(false);
                    TM15.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("16B"))
                {
                    TH16.SetActive(false);
                    TM16.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("17B"))
                {
                    TH17.SetActive(false);
                    TM17.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("18B"))
                {
                    TH18.SetActive(false);
                    TM18.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("19B"))
                {
                    TH19.SetActive(false);
                    TM19.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("20B"))
                {
                    TH20.SetActive(false);
                    TM20.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("21B"))
                {
                    TH21.SetActive(false);
                    TM21.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("22B"))
                {
                    TH22.SetActive(false);
                    TM22.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("23B"))
                {
                    TH23.SetActive(false);
                    TM23.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("24B"))
                {
                    TH24.SetActive(false);
                    TM24.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("25B"))
                {
                    TH25.SetActive(false);
                    TM25.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("26B"))
                {
                    TH26.SetActive(false);
                    TM26.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("27B"))
                {
                    TH27.SetActive(false);
                    TM27.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("28B"))
                {
                    TH28.SetActive(false);
                    TM28.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("29B"))
                {
                    TH29.SetActive(false);
                    TM29.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("30B"))
                {
                    TH30.SetActive(false);
                    TM30.SetActive(true);
                    UBenar.SetActive(false);
                }
                else
                {
                    TB.SetActive(true);
                    TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                    TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                    TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                    TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                    TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                    TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                    UBenar.SetActive(false);
                }
            }
            else
            {
                TB.SetActive(true);
                TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                UBenar.SetActive(false);
            }
        }
        else if (a == 10)
        {
            if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
            {
                GameObject go = hit.collider.gameObject;
                if (go.CompareTag("10B"))
                {
                    TH10.SetActive(true);
                    TM10.SetActive(false);
                    UBenar.SetActive(true);
                    b = 10;
                }
                else if (go.CompareTag("2B"))
                {
                    TH2.SetActive(false);
                    TM2.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("3B"))
                {
                    TH3.SetActive(false);
                    TM3.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("4B"))
                {
                    TH4.SetActive(false);
                    TM4.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("5B"))
                {
                    TH5.SetActive(false);
                    TM5.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("6B"))
                {
                    TH6.SetActive(false);
                    TM6.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("7B"))
                {
                    TH7.SetActive(false);
                    TM7.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("8B"))
                {
                    TH8.SetActive(false);
                    TM8.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("9B"))
                {
                    TH9.SetActive(false);
                    TM9.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("1B"))
                {
                    TH1.SetActive(false);
                    TM1.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("11B"))
                {
                    TH11.SetActive(false);
                    TM11.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("12B"))
                {
                    TH12.SetActive(false);
                    TM12.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("13B"))
                {
                    TH13.SetActive(false);
                    TM13.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("14B"))
                {
                    TH14.SetActive(false);
                    TM14.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("15B"))
                {
                    TH15.SetActive(false);
                    TM15.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("16B"))
                {
                    TH16.SetActive(false);
                    TM16.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("17B"))
                {
                    TH17.SetActive(false);
                    TM17.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("18B"))
                {
                    TH18.SetActive(false);
                    TM18.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("19B"))
                {
                    TH19.SetActive(false);
                    TM19.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("20B"))
                {
                    TH20.SetActive(false);
                    TM20.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("21B"))
                {
                    TH21.SetActive(false);
                    TM21.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("22B"))
                {
                    TH22.SetActive(false);
                    TM22.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("23B"))
                {
                    TH23.SetActive(false);
                    TM23.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("24B"))
                {
                    TH24.SetActive(false);
                    TM24.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("25B"))
                {
                    TH25.SetActive(false);
                    TM25.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("26B"))
                {
                    TH26.SetActive(false);
                    TM26.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("27B"))
                {
                    TH27.SetActive(false);
                    TM27.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("28B"))
                {
                    TH28.SetActive(false);
                    TM28.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("29B"))
                {
                    TH29.SetActive(false);
                    TM29.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("30B"))
                {
                    TH30.SetActive(false);
                    TM30.SetActive(true);
                    UBenar.SetActive(false);
                }
                else
                {
                    TB.SetActive(true);
                    TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                    TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                    TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                    TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                    TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                    TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                    UBenar.SetActive(false);
                }
            }
            else
            {
                TB.SetActive(true);
                TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                UBenar.SetActive(false);
            }
        }
        else if (a == 11)
        {
            if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
            {
                GameObject go = hit.collider.gameObject;
                if (go.CompareTag("11B"))
                {
                    TH11.SetActive(true);
                    TM11.SetActive(false);
                    UBenar.SetActive(true);
                    b = 11;
                }
                else if (go.CompareTag("2B"))
                {
                    TH2.SetActive(false);
                    TM2.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("3B"))
                {
                    TH3.SetActive(false);
                    TM3.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("4B"))
                {
                    TH4.SetActive(false);
                    TM4.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("5B"))
                {
                    TH5.SetActive(false);
                    TM5.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("6B"))
                {
                    TH6.SetActive(false);
                    TM6.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("7B"))
                {
                    TH7.SetActive(false);
                    TM7.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("8B"))
                {
                    TH8.SetActive(false);
                    TM8.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("9B"))
                {
                    TH9.SetActive(false);
                    TM9.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("10B"))
                {
                    TH10.SetActive(false);
                    TM10.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("1B"))
                {
                    TH1.SetActive(false);
                    TM1.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("12B"))
                {
                    TH12.SetActive(false);
                    TM12.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("13B"))
                {
                    TH13.SetActive(false);
                    TM13.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("14B"))
                {
                    TH14.SetActive(false);
                    TM14.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("15B"))
                {
                    TH15.SetActive(false);
                    TM15.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("16B"))
                {
                    TH16.SetActive(false);
                    TM16.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("17B"))
                {
                    TH17.SetActive(false);
                    TM17.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("18B"))
                {
                    TH18.SetActive(false);
                    TM18.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("19B"))
                {
                    TH19.SetActive(false);
                    TM19.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("20B"))
                {
                    TH20.SetActive(false);
                    TM20.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("21B"))
                {
                    TH21.SetActive(false);
                    TM21.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("22B"))
                {
                    TH22.SetActive(false);
                    TM22.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("23B"))
                {
                    TH23.SetActive(false);
                    TM23.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("24B"))
                {
                    TH24.SetActive(false);
                    TM24.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("25B"))
                {
                    TH25.SetActive(false);
                    TM25.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("26B"))
                {
                    TH26.SetActive(false);
                    TM26.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("27B"))
                {
                    TH27.SetActive(false);
                    TM27.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("28B"))
                {
                    TH28.SetActive(false);
                    TM28.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("29B"))
                {
                    TH29.SetActive(false);
                    TM29.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("30B"))
                {
                    TH30.SetActive(false);
                    TM30.SetActive(true);
                    UBenar.SetActive(false);
                }
                else
                {
                    TB.SetActive(true);
                    TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                    TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                    TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                    TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                    TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                    TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                    UBenar.SetActive(false);
                }
            }
            else
            {
                TB.SetActive(true);
                TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                UBenar.SetActive(false);
            }
        }
        else if (a == 12)
        {
            if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
            {
                GameObject go = hit.collider.gameObject;
                if (go.CompareTag("12B"))
                {
                    TH12.SetActive(true);
                    TM12.SetActive(false);
                    UBenar.SetActive(true);
                    b = 12;
                }
                else if (go.CompareTag("1B"))
                {
                    TH1.SetActive(false);
                    TM1.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("3B"))
                {
                    TH3.SetActive(false);
                    TM3.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("4B"))
                {
                    TH4.SetActive(false);
                    TM4.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("5B"))
                {
                    TH5.SetActive(false);
                    TM5.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("6B"))
                {
                    TH6.SetActive(false);
                    TM6.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("7B"))
                {
                    TH7.SetActive(false);
                    TM7.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("8B"))
                {
                    TH8.SetActive(false);
                    TM8.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("9B"))
                {
                    TH9.SetActive(false);
                    TM9.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("10B"))
                {
                    TH10.SetActive(false);
                    TM10.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("11B"))
                {
                    TH11.SetActive(false);
                    TM11.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("2B"))
                {
                    TH2.SetActive(false);
                    TM2.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("13B"))
                {
                    TH13.SetActive(false);
                    TM13.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("14B"))
                {
                    TH14.SetActive(false);
                    TM14.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("15B"))
                {
                    TH15.SetActive(false);
                    TM15.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("16B"))
                {
                    TH16.SetActive(false);
                    TM16.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("17B"))
                {
                    TH17.SetActive(false);
                    TM17.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("18B"))
                {
                    TH18.SetActive(false);
                    TM18.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("19B"))
                {
                    TH19.SetActive(false);
                    TM19.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("20B"))
                {
                    TH20.SetActive(false);
                    TM20.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("21B"))
                {
                    TH21.SetActive(false);
                    TM21.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("22B"))
                {
                    TH22.SetActive(false);
                    TM22.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("23B"))
                {
                    TH23.SetActive(false);
                    TM23.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("24B"))
                {
                    TH24.SetActive(false);
                    TM24.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("25B"))
                {
                    TH25.SetActive(false);
                    TM25.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("26B"))
                {
                    TH26.SetActive(false);
                    TM26.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("27B"))
                {
                    TH27.SetActive(false);
                    TM27.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("28B"))
                {
                    TH28.SetActive(false);
                    TM28.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("29B"))
                {
                    TH29.SetActive(false);
                    TM29.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("30B"))
                {
                    TH30.SetActive(false);
                    TM30.SetActive(true);
                    UBenar.SetActive(false);
                }
                else
                {
                    TB.SetActive(true);
                    TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                    TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                    TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                    TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                    TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                    TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                    UBenar.SetActive(false);
                }
            }
            else
            {
                TB.SetActive(true);
                TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                UBenar.SetActive(false);
            }
        }
        else if (a == 13)
        {
            if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
            {
                GameObject go = hit.collider.gameObject;
                if (go.CompareTag("13B"))
                {
                    TH13.SetActive(true);
                    TM13.SetActive(false);
                    UBenar.SetActive(true);
                    b = 13;
                }
                else if (go.CompareTag("2B"))
                {
                    TH2.SetActive(false);
                    TM2.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("1B"))
                {
                    TH1.SetActive(false);
                    TM1.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("4B"))
                {
                    TH4.SetActive(false);
                    TM4.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("5B"))
                {
                    TH5.SetActive(false);
                    TM5.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("6B"))
                {
                    TH6.SetActive(false);
                    TM6.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("7B"))
                {
                    TH7.SetActive(false);
                    TM7.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("8B"))
                {
                    TH8.SetActive(false);
                    TM8.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("9B"))
                {
                    TH9.SetActive(false);
                    TM9.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("10B"))
                {
                    TH10.SetActive(false);
                    TM10.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("11B"))
                {
                    TH11.SetActive(false);
                    TM11.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("12B"))
                {
                    TH12.SetActive(false);
                    TM12.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("3B"))
                {
                    TH3.SetActive(false);
                    TM3.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("14B"))
                {
                    TH14.SetActive(false);
                    TM14.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("15B"))
                {
                    TH15.SetActive(false);
                    TM15.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("16B"))
                {
                    TH16.SetActive(false);
                    TM16.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("17B"))
                {
                    TH17.SetActive(false);
                    TM17.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("18B"))
                {
                    TH18.SetActive(false);
                    TM18.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("19B"))
                {
                    TH19.SetActive(false);
                    TM19.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("20B"))
                {
                    TH20.SetActive(false);
                    TM20.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("21B"))
                {
                    TH21.SetActive(false);
                    TM21.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("22B"))
                {
                    TH22.SetActive(false);
                    TM22.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("23B"))
                {
                    TH23.SetActive(false);
                    TM23.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("24B"))
                {
                    TH24.SetActive(false);
                    TM24.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("25B"))
                {
                    TH25.SetActive(false);
                    TM25.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("26B"))
                {
                    TH26.SetActive(false);
                    TM26.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("27B"))
                {
                    TH27.SetActive(false);
                    TM27.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("28B"))
                {
                    TH28.SetActive(false);
                    TM28.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("29B"))
                {
                    TH29.SetActive(false);
                    TM29.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("30B"))
                {
                    TH30.SetActive(false);
                    TM30.SetActive(true);
                    UBenar.SetActive(false);
                }
                else
                {
                    TB.SetActive(true);
                    TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                    TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                    TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                    TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                    TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                    TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                    UBenar.SetActive(false);
                }
            }
            else
            {
                TB.SetActive(true);
                TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                UBenar.SetActive(false);
            }
        }
        else if (a == 14)
        {
            if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
            {
                GameObject go = hit.collider.gameObject;
                if (go.CompareTag("14B"))
                {
                    TH14.SetActive(true);
                    TM14.SetActive(false);
                    UBenar.SetActive(true);
                    b = 14;
                }
                else if (go.CompareTag("2B"))
                {
                    TH2.SetActive(false);
                    TM2.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("3B"))
                {
                    TH3.SetActive(false);
                    TM3.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("1B"))
                {
                    TH1.SetActive(false);
                    TM1.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("5B"))
                {
                    TH5.SetActive(false);
                    TM5.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("6B"))
                {
                    TH6.SetActive(false);
                    TM6.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("7B"))
                {
                    TH7.SetActive(false);
                    TM7.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("8B"))
                {
                    TH8.SetActive(false);
                    TM8.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("9B"))
                {
                    TH9.SetActive(false);
                    TM9.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("10B"))
                {
                    TH10.SetActive(false);
                    TM10.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("11B"))
                {
                    TH11.SetActive(false);
                    TM11.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("12B"))
                {
                    TH12.SetActive(false);
                    TM12.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("13B"))
                {
                    TH13.SetActive(false);
                    TM13.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("4B"))
                {
                    TH4.SetActive(false);
                    TM4.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("15B"))
                {
                    TH15.SetActive(false);
                    TM15.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("16B"))
                {
                    TH16.SetActive(false);
                    TM16.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("17B"))
                {
                    TH17.SetActive(false);
                    TM17.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("18B"))
                {
                    TH18.SetActive(false);
                    TM18.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("19B"))
                {
                    TH19.SetActive(false);
                    TM19.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("20B"))
                {
                    TH20.SetActive(false);
                    TM20.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("21B"))
                {
                    TH21.SetActive(false);
                    TM21.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("22B"))
                {
                    TH22.SetActive(false);
                    TM22.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("23B"))
                {
                    TH23.SetActive(false);
                    TM23.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("24B"))
                {
                    TH24.SetActive(false);
                    TM24.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("25B"))
                {
                    TH25.SetActive(false);
                    TM25.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("26B"))
                {
                    TH26.SetActive(false);
                    TM26.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("27B"))
                {
                    TH27.SetActive(false);
                    TM27.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("28B"))
                {
                    TH28.SetActive(false);
                    TM28.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("29B"))
                {
                    TH29.SetActive(false);
                    TM29.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("30B"))
                {
                    TH30.SetActive(false);
                    TM30.SetActive(true);
                    UBenar.SetActive(false);
                }
                else
                {
                    TB.SetActive(true);
                    TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                    TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                    TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                    TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                    TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                    TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                    UBenar.SetActive(false);
                }
            }
            else
            {
                TB.SetActive(true);
                TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                UBenar.SetActive(false);
            }
        }
        else if (a == 15)
        {
            if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
            {
                GameObject go = hit.collider.gameObject;
                if (go.CompareTag("15B"))
                {
                    TH15.SetActive(true);
                    TM15.SetActive(false);
                    UBenar.SetActive(true);
                    b = 15;
                }
                else if (go.CompareTag("2B"))
                {
                    TH2.SetActive(false);
                    TM2.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("3B"))
                {
                    TH3.SetActive(false);
                    TM3.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("4B"))
                {
                    TH4.SetActive(false);
                    TM4.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("1B"))
                {
                    TH1.SetActive(false);
                    TM1.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("6B"))
                {
                    TH6.SetActive(false);
                    TM6.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("7B"))
                {
                    TH7.SetActive(false);
                    TM7.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("8B"))
                {
                    TH8.SetActive(false);
                    TM8.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("9B"))
                {
                    TH9.SetActive(false);
                    TM9.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("10B"))
                {
                    TH10.SetActive(false);
                    TM10.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("11B"))
                {
                    TH11.SetActive(false);
                    TM11.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("12B"))
                {
                    TH12.SetActive(false);
                    TM12.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("13B"))
                {
                    TH13.SetActive(false);
                    TM13.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("14B"))
                {
                    TH14.SetActive(false);
                    TM14.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("5B"))
                {
                    TH5.SetActive(false);
                    TM5.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("16B"))
                {
                    TH16.SetActive(false);
                    TM16.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("17B"))
                {
                    TH17.SetActive(false);
                    TM17.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("18B"))
                {
                    TH18.SetActive(false);
                    TM18.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("19B"))
                {
                    TH19.SetActive(false);
                    TM19.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("20B"))
                {
                    TH20.SetActive(false);
                    TM20.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("21B"))
                {
                    TH21.SetActive(false);
                    TM21.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("22B"))
                {
                    TH22.SetActive(false);
                    TM22.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("23B"))
                {
                    TH23.SetActive(false);
                    TM23.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("24B"))
                {
                    TH24.SetActive(false);
                    TM24.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("25B"))
                {
                    TH25.SetActive(false);
                    TM25.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("26B"))
                {
                    TH26.SetActive(false);
                    TM26.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("27B"))
                {
                    TH27.SetActive(false);
                    TM27.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("28B"))
                {
                    TH28.SetActive(false);
                    TM28.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("29B"))
                {
                    TH29.SetActive(false);
                    TM29.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("30B"))
                {
                    TH30.SetActive(false);
                    TM30.SetActive(true);
                    UBenar.SetActive(false);
                }
                else
                {
                    TB.SetActive(true);
                    TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                    TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                    TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                    TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                    TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                    TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                    UBenar.SetActive(false);
                }
            }
            else
            {
                TB.SetActive(true);
                TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                UBenar.SetActive(false);
            }
        }
        else if (a == 16)
        {
            if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
            {
                GameObject go = hit.collider.gameObject;
                if (go.CompareTag("16B"))
                {
                    TH16.SetActive(true);
                    TM16.SetActive(false);
                    UBenar.SetActive(true);
                    b = 16;
                }
                else if (go.CompareTag("2B"))
                {
                    TH2.SetActive(false);
                    TM2.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("3B"))
                {
                    TH3.SetActive(false);
                    TM3.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("4B"))
                {
                    TH4.SetActive(false);
                    TM4.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("5B"))
                {
                    TH5.SetActive(false);
                    TM5.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("1B"))
                {
                    TH1.SetActive(false);
                    TM1.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("7B"))
                {
                    TH7.SetActive(false);
                    TM7.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("8B"))
                {
                    TH8.SetActive(false);
                    TM8.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("9B"))
                {
                    TH9.SetActive(false);
                    TM9.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("10B"))
                {
                    TH10.SetActive(false);
                    TM10.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("11B"))
                {
                    TH11.SetActive(false);
                    TM11.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("12B"))
                {
                    TH12.SetActive(false);
                    TM12.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("13B"))
                {
                    TH13.SetActive(false);
                    TM13.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("14B"))
                {
                    TH14.SetActive(false);
                    TM14.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("15B"))
                {
                    TH15.SetActive(false);
                    TM15.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("6B"))
                {
                    TH6.SetActive(false);
                    TM6.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("17B"))
                {
                    TH17.SetActive(false);
                    TM17.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("18B"))
                {
                    TH18.SetActive(false);
                    TM18.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("19B"))
                {
                    TH19.SetActive(false);
                    TM19.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("20B"))
                {
                    TH20.SetActive(false);
                    TM20.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("21B"))
                {
                    TH21.SetActive(false);
                    TM21.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("22B"))
                {
                    TH22.SetActive(false);
                    TM22.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("23B"))
                {
                    TH23.SetActive(false);
                    TM23.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("24B"))
                {
                    TH24.SetActive(false);
                    TM24.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("25B"))
                {
                    TH25.SetActive(false);
                    TM25.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("26B"))
                {
                    TH26.SetActive(false);
                    TM26.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("27B"))
                {
                    TH27.SetActive(false);
                    TM27.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("28B"))
                {
                    TH28.SetActive(false);
                    TM28.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("29B"))
                {
                    TH29.SetActive(false);
                    TM29.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("30B"))
                {
                    TH30.SetActive(false);
                    TM30.SetActive(true);
                    UBenar.SetActive(false);
                }
                else
                {
                    TB.SetActive(true);
                    TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                    TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                    TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                    TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                    TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                    TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                    UBenar.SetActive(false);
                }
            }
            else
            {
                TB.SetActive(true);
                TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                UBenar.SetActive(false);
            }
        }
        else if (a == 17)
        {
            if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
            {
                GameObject go = hit.collider.gameObject;
                if (go.CompareTag("17B"))
                {
                    TH17.SetActive(true);
                    TM17.SetActive(false);
                    UBenar.SetActive(true);
                    b = 17;
                }
                else if (go.CompareTag("2B"))
                {
                    TH2.SetActive(false);
                    TM2.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("3B"))
                {
                    TH3.SetActive(false);
                    TM3.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("4B"))
                {
                    TH4.SetActive(false);
                    TM4.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("5B"))
                {
                    TH5.SetActive(false);
                    TM5.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("6B"))
                {
                    TH6.SetActive(false);
                    TM6.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("1B"))
                {
                    TH1.SetActive(false);
                    TM1.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("8B"))
                {
                    TH8.SetActive(false);
                    TM8.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("9B"))
                {
                    TH9.SetActive(false);
                    TM9.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("10B"))
                {
                    TH10.SetActive(false);
                    TM10.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("11B"))
                {
                    TH11.SetActive(false);
                    TM11.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("12B"))
                {
                    TH12.SetActive(false);
                    TM12.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("13B"))
                {
                    TH13.SetActive(false);
                    TM13.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("14B"))
                {
                    TH14.SetActive(false);
                    TM14.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("15B"))
                {
                    TH15.SetActive(false);
                    TM15.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("16B"))
                {
                    TH16.SetActive(false);
                    TM16.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("7B"))
                {
                    TH7.SetActive(false);
                    TM7.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("18B"))
                {
                    TH18.SetActive(false);
                    TM18.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("19B"))
                {
                    TH19.SetActive(false);
                    TM19.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("20B"))
                {
                    TH20.SetActive(false);
                    TM20.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("21B"))
                {
                    TH21.SetActive(false);
                    TM21.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("22B"))
                {
                    TH22.SetActive(false);
                    TM22.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("23B"))
                {
                    TH23.SetActive(false);
                    TM23.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("24B"))
                {
                    TH24.SetActive(false);
                    TM24.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("25B"))
                {
                    TH25.SetActive(false);
                    TM25.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("26B"))
                {
                    TH26.SetActive(false);
                    TM26.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("27B"))
                {
                    TH27.SetActive(false);
                    TM27.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("28B"))
                {
                    TH28.SetActive(false);
                    TM28.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("29B"))
                {
                    TH29.SetActive(false);
                    TM29.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("30B"))
                {
                    TH30.SetActive(false);
                    TM30.SetActive(true);
                    UBenar.SetActive(false);
                }
                else
                {
                    TB.SetActive(true);
                    TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                    TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                    TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                    TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                    TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                    TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                    UBenar.SetActive(false);
                }
            }
            else
            {
                TB.SetActive(true);
                TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                UBenar.SetActive(false);
            }
        }
        else if (a == 18)
        {
            if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
            {
                GameObject go = hit.collider.gameObject;
                if (go.CompareTag("18B"))
                {
                    TH18.SetActive(true);
                    TM18.SetActive(false);
                    UBenar.SetActive(true);
                    b = 18;
                }
                else if (go.CompareTag("2B"))
                {
                    TH2.SetActive(false);
                    TM2.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("3B"))
                {
                    TH3.SetActive(false);
                    TM3.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("4B"))
                {
                    TH4.SetActive(false);
                    TM4.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("5B"))
                {
                    TH5.SetActive(false);
                    TM5.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("6B"))
                {
                    TH6.SetActive(false);
                    TM6.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("7B"))
                {
                    TH7.SetActive(false);
                    TM7.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("1B"))
                {
                    TH1.SetActive(false);
                    TM1.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("9B"))
                {
                    TH9.SetActive(false);
                    TM9.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("10B"))
                {
                    TH10.SetActive(false);
                    TM10.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("11B"))
                {
                    TH11.SetActive(false);
                    TM11.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("12B"))
                {
                    TH12.SetActive(false);
                    TM12.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("13B"))
                {
                    TH13.SetActive(false);
                    TM13.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("14B"))
                {
                    TH14.SetActive(false);
                    TM14.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("15B"))
                {
                    TH15.SetActive(false);
                    TM15.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("16B"))
                {
                    TH16.SetActive(false);
                    TM16.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("17B"))
                {
                    TH17.SetActive(false);
                    TM17.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("8B"))
                {
                    TH8.SetActive(false);
                    TM8.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("19B"))
                {
                    TH19.SetActive(false);
                    TM19.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("20B"))
                {
                    TH20.SetActive(false);
                    TM20.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("21B"))
                {
                    TH21.SetActive(false);
                    TM21.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("22B"))
                {
                    TH22.SetActive(false);
                    TM22.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("23B"))
                {
                    TH23.SetActive(false);
                    TM23.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("24B"))
                {
                    TH24.SetActive(false);
                    TM24.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("25B"))
                {
                    TH25.SetActive(false);
                    TM25.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("26B"))
                {
                    TH26.SetActive(false);
                    TM26.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("27B"))
                {
                    TH27.SetActive(false);
                    TM27.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("28B"))
                {
                    TH28.SetActive(false);
                    TM28.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("29B"))
                {
                    TH29.SetActive(false);
                    TM29.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("30B"))
                {
                    TH30.SetActive(false);
                    TM30.SetActive(true);
                    UBenar.SetActive(false);
                }
                else
                {
                    TB.SetActive(true);
                    TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                    TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                    TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                    TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                    TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                    TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                    UBenar.SetActive(false);
                }
            }
            else
            {
                TB.SetActive(true);
                TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                UBenar.SetActive(false);
            }
        }
        else if (a == 19)
        {
            if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
            {
                GameObject go = hit.collider.gameObject;
                if (go.CompareTag("19B"))
                {
                    TH19.SetActive(true);
                    TM19.SetActive(false);
                    UBenar.SetActive(true);
                    b = 19;
                }
                else if (go.CompareTag("2B"))
                {
                    TH2.SetActive(false);
                    TM2.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("3B"))
                {
                    TH3.SetActive(false);
                    TM3.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("4B"))
                {
                    TH4.SetActive(false);
                    TM4.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("5B"))
                {
                    TH5.SetActive(false);
                    TM5.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("6B"))
                {
                    TH6.SetActive(false);
                    TM6.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("7B"))
                {
                    TH7.SetActive(false);
                    TM7.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("8B"))
                {
                    TH8.SetActive(false);
                    TM8.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("1B"))
                {
                    TH1.SetActive(false);
                    TM1.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("10B"))
                {
                    TH10.SetActive(false);
                    TM10.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("11B"))
                {
                    TH11.SetActive(false);
                    TM11.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("12B"))
                {
                    TH12.SetActive(false);
                    TM12.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("13B"))
                {
                    TH13.SetActive(false);
                    TM13.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("14B"))
                {
                    TH14.SetActive(false);
                    TM14.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("15B"))
                {
                    TH15.SetActive(false);
                    TM15.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("16B"))
                {
                    TH16.SetActive(false);
                    TM16.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("17B"))
                {
                    TH17.SetActive(false);
                    TM17.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("18B"))
                {
                    TH18.SetActive(false);
                    TM18.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("9B"))
                {
                    TH9.SetActive(false);
                    TM9.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("20B"))
                {
                    TH20.SetActive(false);
                    TM20.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("21B"))
                {
                    TH21.SetActive(false);
                    TM21.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("22B"))
                {
                    TH22.SetActive(false);
                    TM22.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("23B"))
                {
                    TH23.SetActive(false);
                    TM23.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("24B"))
                {
                    TH24.SetActive(false);
                    TM24.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("25B"))
                {
                    TH25.SetActive(false);
                    TM25.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("26B"))
                {
                    TH26.SetActive(false);
                    TM26.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("27B"))
                {
                    TH27.SetActive(false);
                    TM27.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("28B"))
                {
                    TH28.SetActive(false);
                    TM28.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("29B"))
                {
                    TH29.SetActive(false);
                    TM29.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("30B"))
                {
                    TH30.SetActive(false);
                    TM30.SetActive(true);
                    UBenar.SetActive(false);
                }
                else
                {
                    TB.SetActive(true);
                    TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                    TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                    TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                    TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                    TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                    TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                    UBenar.SetActive(false);
                }
            }
            else
            {
                TB.SetActive(true);
                TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                UBenar.SetActive(false);
            }
        }
        else if (a == 20)
        {
            if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
            {
                GameObject go = hit.collider.gameObject;
                if (go.CompareTag("20B"))
                {
                    TH20.SetActive(true);
                    TM20.SetActive(false);
                    UBenar.SetActive(true);
                    b = 20;
                }
                else if (go.CompareTag("2B"))
                {
                    TH2.SetActive(false);
                    TM2.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("3B"))
                {
                    TH3.SetActive(false);
                    TM3.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("4B"))
                {
                    TH4.SetActive(false);
                    TM4.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("5B"))
                {
                    TH5.SetActive(false);
                    TM5.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("6B"))
                {
                    TH6.SetActive(false);
                    TM6.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("7B"))
                {
                    TH7.SetActive(false);
                    TM7.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("8B"))
                {
                    TH8.SetActive(false);
                    TM8.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("9B"))
                {
                    TH9.SetActive(false);
                    TM9.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("1B"))
                {
                    TH1.SetActive(false);
                    TM1.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("11B"))
                {
                    TH11.SetActive(false);
                    TM11.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("12B"))
                {
                    TH12.SetActive(false);
                    TM12.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("13B"))
                {
                    TH13.SetActive(false);
                    TM13.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("14B"))
                {
                    TH14.SetActive(false);
                    TM14.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("15B"))
                {
                    TH15.SetActive(false);
                    TM15.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("16B"))
                {
                    TH16.SetActive(false);
                    TM16.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("17B"))
                {
                    TH17.SetActive(false);
                    TM17.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("18B"))
                {
                    TH18.SetActive(false);
                    TM18.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("19B"))
                {
                    TH19.SetActive(false);
                    TM19.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("10B"))
                {
                    TH10.SetActive(false);
                    TM10.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("21B"))
                {
                    TH21.SetActive(false);
                    TM21.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("22B"))
                {
                    TH22.SetActive(false);
                    TM22.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("23B"))
                {
                    TH23.SetActive(false);
                    TM23.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("24B"))
                {
                    TH24.SetActive(false);
                    TM24.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("25B"))
                {
                    TH25.SetActive(false);
                    TM25.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("26B"))
                {
                    TH26.SetActive(false);
                    TM26.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("27B"))
                {
                    TH27.SetActive(false);
                    TM27.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("28B"))
                {
                    TH28.SetActive(false);
                    TM28.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("29B"))
                {
                    TH29.SetActive(false);
                    TM29.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("30B"))
                {
                    TH30.SetActive(false);
                    TM30.SetActive(true);
                    UBenar.SetActive(false);
                }
                else
                {
                    TB.SetActive(true);
                    TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                    TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                    TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                    TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                    TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                    TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                    UBenar.SetActive(false);
                }
            }
            else
            {
                TB.SetActive(true);
                TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                UBenar.SetActive(false);
            }
        }
        else if (a == 21)
        {
            if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
            {
                GameObject go = hit.collider.gameObject;
                if (go.CompareTag("21B"))
                {
                    TH21.SetActive(true);
                    TM21.SetActive(false);
                    UBenar.SetActive(true);
                    b = 21;
                }
                else if (go.CompareTag("2B"))
                {
                    TH2.SetActive(false);
                    TM2.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("3B"))
                {
                    TH3.SetActive(false);
                    TM3.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("4B"))
                {
                    TH4.SetActive(false);
                    TM4.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("5B"))
                {
                    TH5.SetActive(false);
                    TM5.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("6B"))
                {
                    TH6.SetActive(false);
                    TM6.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("7B"))
                {
                    TH7.SetActive(false);
                    TM7.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("8B"))
                {
                    TH8.SetActive(false);
                    TM8.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("9B"))
                {
                    TH9.SetActive(false);
                    TM9.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("10B"))
                {
                    TH10.SetActive(false);
                    TM10.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("11B"))
                {
                    TH11.SetActive(false);
                    TM11.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("12B"))
                {
                    TH12.SetActive(false);
                    TM12.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("13B"))
                {
                    TH13.SetActive(false);
                    TM13.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("14B"))
                {
                    TH14.SetActive(false);
                    TM14.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("15B"))
                {
                    TH15.SetActive(false);
                    TM15.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("16B"))
                {
                    TH16.SetActive(false);
                    TM16.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("17B"))
                {
                    TH17.SetActive(false);
                    TM17.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("18B"))
                {
                    TH18.SetActive(false);
                    TM18.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("19B"))
                {
                    TH19.SetActive(false);
                    TM19.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("20B"))
                {
                    TH20.SetActive(false);
                    TM20.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("1B"))
                {
                    TH1.SetActive(false);
                    TM1.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("22B"))
                {
                    TH22.SetActive(false);
                    TM22.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("23B"))
                {
                    TH23.SetActive(false);
                    TM23.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("24B"))
                {
                    TH24.SetActive(false);
                    TM24.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("25B"))
                {
                    TH25.SetActive(false);
                    TM25.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("26B"))
                {
                    TH26.SetActive(false);
                    TM26.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("27B"))
                {
                    TH27.SetActive(false);
                    TM27.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("28B"))
                {
                    TH28.SetActive(false);
                    TM28.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("29B"))
                {
                    TH29.SetActive(false);
                    TM29.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("30B"))
                {
                    TH30.SetActive(false);
                    TM30.SetActive(true);
                    UBenar.SetActive(false);
                }
                else
                {
                    TB.SetActive(true);
                    TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                    TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                    TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                    TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                    TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                    TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                    UBenar.SetActive(false);
                }
            }
            else
            {
                TB.SetActive(true);
                TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                UBenar.SetActive(false);
            }
        }
        else if (a == 22)
        {
            if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
            {
                GameObject go = hit.collider.gameObject;
                if (go.CompareTag("22B"))
                {
                    TH22.SetActive(true);
                    TM22.SetActive(false);
                    UBenar.SetActive(true);
                    b = 22;
                }
                else if (go.CompareTag("1B"))
                {
                    TH1.SetActive(false);
                    TM1.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("3B"))
                {
                    TH3.SetActive(false);
                    TM3.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("4B"))
                {
                    TH4.SetActive(false);
                    TM4.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("5B"))
                {
                    TH5.SetActive(false);
                    TM5.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("6B"))
                {
                    TH6.SetActive(false);
                    TM6.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("7B"))
                {
                    TH7.SetActive(false);
                    TM7.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("8B"))
                {
                    TH8.SetActive(false);
                    TM8.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("9B"))
                {
                    TH9.SetActive(false);
                    TM9.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("10B"))
                {
                    TH10.SetActive(false);
                    TM10.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("11B"))
                {
                    TH11.SetActive(false);
                    TM11.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("12B"))
                {
                    TH12.SetActive(false);
                    TM12.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("13B"))
                {
                    TH13.SetActive(false);
                    TM13.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("14B"))
                {
                    TH14.SetActive(false);
                    TM14.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("15B"))
                {
                    TH15.SetActive(false);
                    TM15.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("16B"))
                {
                    TH16.SetActive(false);
                    TM16.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("17B"))
                {
                    TH17.SetActive(false);
                    TM17.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("18B"))
                {
                    TH18.SetActive(false);
                    TM18.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("19B"))
                {
                    TH19.SetActive(false);
                    TM19.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("20B"))
                {
                    TH20.SetActive(false);
                    TM20.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("21B"))
                {
                    TH21.SetActive(false);
                    TM21.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("2B"))
                {
                    TH2.SetActive(false);
                    TM2.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("23B"))
                {
                    TH23.SetActive(false);
                    TM23.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("24B"))
                {
                    TH24.SetActive(false);
                    TM24.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("25B"))
                {
                    TH25.SetActive(false);
                    TM25.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("26B"))
                {
                    TH26.SetActive(false);
                    TM26.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("27B"))
                {
                    TH27.SetActive(false);
                    TM27.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("28B"))
                {
                    TH28.SetActive(false);
                    TM28.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("29B"))
                {
                    TH29.SetActive(false);
                    TM29.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("30B"))
                {
                    TH30.SetActive(false);
                    TM30.SetActive(true);
                    UBenar.SetActive(false);
                }
                else
                {
                    TB.SetActive(true);
                    TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                    TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                    TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                    TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                    TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                    TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                    UBenar.SetActive(false);
                }
            }
            else
            {
                TB.SetActive(true);
                TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                UBenar.SetActive(false);
            }
        }
        else if (a == 23)
        {
            if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
            {
                GameObject go = hit.collider.gameObject;
                if (go.CompareTag("23B"))
                {
                    TH23.SetActive(true);
                    TM23.SetActive(false);
                    UBenar.SetActive(true);
                    b = 23;
                }
                else if (go.CompareTag("2B"))
                {
                    TH2.SetActive(false);
                    TM2.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("1B"))
                {
                    TH1.SetActive(false);
                    TM1.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("4B"))
                {
                    TH4.SetActive(false);
                    TM4.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("5B"))
                {
                    TH5.SetActive(false);
                    TM5.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("6B"))
                {
                    TH6.SetActive(false);
                    TM6.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("7B"))
                {
                    TH7.SetActive(false);
                    TM7.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("8B"))
                {
                    TH8.SetActive(false);
                    TM8.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("9B"))
                {
                    TH9.SetActive(false);
                    TM9.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("10B"))
                {
                    TH10.SetActive(false);
                    TM10.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("11B"))
                {
                    TH11.SetActive(false);
                    TM11.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("12B"))
                {
                    TH12.SetActive(false);
                    TM12.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("13B"))
                {
                    TH13.SetActive(false);
                    TM13.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("14B"))
                {
                    TH14.SetActive(false);
                    TM14.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("15B"))
                {
                    TH15.SetActive(false);
                    TM15.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("16B"))
                {
                    TH16.SetActive(false);
                    TM16.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("17B"))
                {
                    TH17.SetActive(false);
                    TM17.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("18B"))
                {
                    TH18.SetActive(false);
                    TM18.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("19B"))
                {
                    TH19.SetActive(false);
                    TM19.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("20B"))
                {
                    TH20.SetActive(false);
                    TM20.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("21B"))
                {
                    TH21.SetActive(false);
                    TM21.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("22B"))
                {
                    TH22.SetActive(false);
                    TM22.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("3B"))
                {
                    TH3.SetActive(false);
                    TM3.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("24B"))
                {
                    TH24.SetActive(false);
                    TM24.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("25B"))
                {
                    TH25.SetActive(false);
                    TM25.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("26B"))
                {
                    TH26.SetActive(false);
                    TM26.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("27B"))
                {
                    TH27.SetActive(false);
                    TM27.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("28B"))
                {
                    TH28.SetActive(false);
                    TM28.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("29B"))
                {
                    TH29.SetActive(false);
                    TM29.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("30B"))
                {
                    TH30.SetActive(false);
                    TM30.SetActive(true);
                    UBenar.SetActive(false);
                }
                else
                {
                    TB.SetActive(true);
                    TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                    TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                    TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                    TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                    TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                    TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                    UBenar.SetActive(false);
                }
            }
            else
            {
                TB.SetActive(true);
                TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                UBenar.SetActive(false);
            }
        }
        else if (a == 24)
        {
            if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
            {
                GameObject go = hit.collider.gameObject;
                if (go.CompareTag("24B"))
                {
                    TH24.SetActive(true);
                    TM24.SetActive(false);
                    UBenar.SetActive(true);
                    b = 24;
                }
                else if (go.CompareTag("2B"))
                {
                    TH2.SetActive(false);
                    TM2.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("3B"))
                {
                    TH3.SetActive(false);
                    TM3.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("1B"))
                {
                    TH1.SetActive(false);
                    TM1.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("5B"))
                {
                    TH5.SetActive(false);
                    TM5.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("6B"))
                {
                    TH6.SetActive(false);
                    TM6.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("7B"))
                {
                    TH7.SetActive(false);
                    TM7.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("8B"))
                {
                    TH8.SetActive(false);
                    TM8.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("9B"))
                {
                    TH9.SetActive(false);
                    TM9.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("10B"))
                {
                    TH10.SetActive(false);
                    TM10.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("11B"))
                {
                    TH11.SetActive(false);
                    TM11.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("12B"))
                {
                    TH12.SetActive(false);
                    TM12.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("13B"))
                {
                    TH13.SetActive(false);
                    TM13.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("14B"))
                {
                    TH14.SetActive(false);
                    TM14.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("15B"))
                {
                    TH15.SetActive(false);
                    TM15.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("16B"))
                {
                    TH16.SetActive(false);
                    TM16.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("17B"))
                {
                    TH17.SetActive(false);
                    TM17.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("18B"))
                {
                    TH18.SetActive(false);
                    TM18.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("19B"))
                {
                    TH19.SetActive(false);
                    TM19.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("20B"))
                {
                    TH20.SetActive(false);
                    TM20.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("21B"))
                {
                    TH21.SetActive(false);
                    TM21.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("22B"))
                {
                    TH22.SetActive(false);
                    TM22.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("23B"))
                {
                    TH23.SetActive(false);
                    TM23.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("4B"))
                {
                    TH4.SetActive(false);
                    TM4.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("25B"))
                {
                    TH25.SetActive(false);
                    TM25.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("26B"))
                {
                    TH26.SetActive(false);
                    TM26.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("27B"))
                {
                    TH27.SetActive(false);
                    TM27.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("28B"))
                {
                    TH28.SetActive(false);
                    TM28.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("29B"))
                {
                    TH29.SetActive(false);
                    TM29.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("30B"))
                {
                    TH30.SetActive(false);
                    TM30.SetActive(true);
                    UBenar.SetActive(false);
                }
                else
                {
                    TB.SetActive(true);
                    TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                    TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                    TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                    TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                    TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                    TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                    UBenar.SetActive(false);
                }
            }
            else
            {
                TB.SetActive(true);
                TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                UBenar.SetActive(false);
            }
        }
        else if (a == 25)
        {
            if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
            {
                GameObject go = hit.collider.gameObject;
                if (go.CompareTag("25B"))
                {
                    TH25.SetActive(true);
                    TM25.SetActive(false);
                    UBenar.SetActive(true);
                    b = 25;
                }
                else if (go.CompareTag("2B"))
                {
                    TH2.SetActive(false);
                    TM2.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("3B"))
                {
                    TH3.SetActive(false);
                    TM3.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("4B"))
                {
                    TH4.SetActive(false);
                    TM4.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("1B"))
                {
                    TH1.SetActive(false);
                    TM1.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("6B"))
                {
                    TH6.SetActive(false);
                    TM6.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("7B"))
                {
                    TH7.SetActive(false);
                    TM7.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("8B"))
                {
                    TH8.SetActive(false);
                    TM8.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("9B"))
                {
                    TH9.SetActive(false);
                    TM9.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("10B"))
                {
                    TH10.SetActive(false);
                    TM10.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("11B"))
                {
                    TH11.SetActive(false);
                    TM11.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("12B"))
                {
                    TH12.SetActive(false);
                    TM12.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("13B"))
                {
                    TH13.SetActive(false);
                    TM13.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("14B"))
                {
                    TH14.SetActive(false);
                    TM14.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("15B"))
                {
                    TH15.SetActive(false);
                    TM15.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("16B"))
                {
                    TH16.SetActive(false);
                    TM16.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("17B"))
                {
                    TH17.SetActive(false);
                    TM17.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("18B"))
                {
                    TH18.SetActive(false);
                    TM18.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("19B"))
                {
                    TH19.SetActive(false);
                    TM19.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("20B"))
                {
                    TH20.SetActive(false);
                    TM20.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("21B"))
                {
                    TH21.SetActive(false);
                    TM21.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("22B"))
                {
                    TH22.SetActive(false);
                    TM22.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("23B"))
                {
                    TH23.SetActive(false);
                    TM23.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("24B"))
                {
                    TH24.SetActive(false);
                    TM24.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("5B"))
                {
                    TH5.SetActive(false);
                    TM5.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("26B"))
                {
                    TH26.SetActive(false);
                    TM26.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("27B"))
                {
                    TH27.SetActive(false);
                    TM27.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("28B"))
                {
                    TH28.SetActive(false);
                    TM28.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("29B"))
                {
                    TH29.SetActive(false);
                    TM29.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("30B"))
                {
                    TH30.SetActive(false);
                    TM30.SetActive(true);
                    UBenar.SetActive(false);
                }
                else
                {
                    TB.SetActive(true);
                    TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                    TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                    TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                    TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                    TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                    TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                    UBenar.SetActive(false);
                }
            }
            else
            {
                TB.SetActive(true);
                TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                UBenar.SetActive(false);
            }
        }
        else if (a == 26)
        {
            if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
            {
                GameObject go = hit.collider.gameObject;
                if (go.CompareTag("26B"))
                {
                    TH26.SetActive(true);
                    TM26.SetActive(false);
                    UBenar.SetActive(true);
                    b = 26;
                }
                else if (go.CompareTag("2B"))
                {
                    TH2.SetActive(false);
                    TM2.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("3B"))
                {
                    TH3.SetActive(false);
                    TM3.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("4B"))
                {
                    TH4.SetActive(false);
                    TM4.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("5B"))
                {
                    TH5.SetActive(false);
                    TM5.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("1B"))
                {
                    TH1.SetActive(false);
                    TM1.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("7B"))
                {
                    TH7.SetActive(false);
                    TM7.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("8B"))
                {
                    TH8.SetActive(false);
                    TM8.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("9B"))
                {
                    TH9.SetActive(false);
                    TM9.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("10B"))
                {
                    TH10.SetActive(false);
                    TM10.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("11B"))
                {
                    TH11.SetActive(false);
                    TM11.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("12B"))
                {
                    TH12.SetActive(false);
                    TM12.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("13B"))
                {
                    TH13.SetActive(false);
                    TM13.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("14B"))
                {
                    TH14.SetActive(false);
                    TM14.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("15B"))
                {
                    TH15.SetActive(false);
                    TM15.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("16B"))
                {
                    TH16.SetActive(false);
                    TM16.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("17B"))
                {
                    TH17.SetActive(false);
                    TM17.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("18B"))
                {
                    TH18.SetActive(false);
                    TM18.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("19B"))
                {
                    TH19.SetActive(false);
                    TM19.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("20B"))
                {
                    TH20.SetActive(false);
                    TM20.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("21B"))
                {
                    TH21.SetActive(false);
                    TM21.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("22B"))
                {
                    TH22.SetActive(false);
                    TM22.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("23B"))
                {
                    TH23.SetActive(false);
                    TM23.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("24B"))
                {
                    TH24.SetActive(false);
                    TM24.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("25B"))
                {
                    TH25.SetActive(false);
                    TM25.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("6B"))
                {
                    TH6.SetActive(false);
                    TM6.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("27B"))
                {
                    TH27.SetActive(false);
                    TM27.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("28B"))
                {
                    TH28.SetActive(false);
                    TM28.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("29B"))
                {
                    TH29.SetActive(false);
                    TM29.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("30B"))
                {
                    TH30.SetActive(false);
                    TM30.SetActive(true);
                    UBenar.SetActive(false);
                }
                else
                {
                    TB.SetActive(true);
                    TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                    TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                    TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                    TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                    TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                    TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                    UBenar.SetActive(false);
                }
            }
            else
            {
                TB.SetActive(true);
                TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                UBenar.SetActive(false);
            }
        }
        else if (a == 27)
        {
            if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
            {
                GameObject go = hit.collider.gameObject;
                if (go.CompareTag("27B"))
                {
                    TH27.SetActive(true);
                    TM27.SetActive(false);
                    UBenar.SetActive(true);
                    b = 27;
                }
                else if (go.CompareTag("2B"))
                {
                    TH2.SetActive(false);
                    TM2.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("3B"))
                {
                    TH3.SetActive(false);
                    TM3.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("4B"))
                {
                    TH4.SetActive(false);
                    TM4.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("5B"))
                {
                    TH5.SetActive(false);
                    TM5.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("6B"))
                {
                    TH6.SetActive(false);
                    TM6.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("1B"))
                {
                    TH1.SetActive(false);
                    TM1.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("8B"))
                {
                    TH8.SetActive(false);
                    TM8.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("9B"))
                {
                    TH9.SetActive(false);
                    TM9.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("10B"))
                {
                    TH10.SetActive(false);
                    TM10.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("11B"))
                {
                    TH11.SetActive(false);
                    TM11.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("12B"))
                {
                    TH12.SetActive(false);
                    TM12.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("13B"))
                {
                    TH13.SetActive(false);
                    TM13.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("14B"))
                {
                    TH14.SetActive(false);
                    TM14.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("15B"))
                {
                    TH15.SetActive(false);
                    TM15.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("16B"))
                {
                    TH16.SetActive(false);
                    TM16.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("17B"))
                {
                    TH17.SetActive(false);
                    TM17.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("18B"))
                {
                    TH18.SetActive(false);
                    TM18.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("19B"))
                {
                    TH19.SetActive(false);
                    TM19.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("20B"))
                {
                    TH20.SetActive(false);
                    TM20.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("21B"))
                {
                    TH21.SetActive(false);
                    TM21.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("22B"))
                {
                    TH22.SetActive(false);
                    TM22.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("23B"))
                {
                    TH23.SetActive(false);
                    TM23.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("24B"))
                {
                    TH24.SetActive(false);
                    TM24.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("25B"))
                {
                    TH25.SetActive(false);
                    TM25.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("26B"))
                {
                    TH26.SetActive(false);
                    TM26.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("7B"))
                {
                    TH7.SetActive(false);
                    TM7.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("28B"))
                {
                    TH28.SetActive(false);
                    TM28.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("29B"))
                {
                    TH29.SetActive(false);
                    TM29.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("30B"))
                {
                    TH30.SetActive(false);
                    TM30.SetActive(true);
                    UBenar.SetActive(false);
                }
                else
                {
                    TB.SetActive(true);
                    TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                    TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                    TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                    TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                    TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                    TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                    UBenar.SetActive(false);
                }
            }
            else
            {
                TB.SetActive(true);
                TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                UBenar.SetActive(false);
            }
        }
        else if (a == 28)
        {
            if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
            {
                GameObject go = hit.collider.gameObject;
                if (go.CompareTag("28B"))
                {
                    TH28.SetActive(true);
                    TM28.SetActive(false);
                    UBenar.SetActive(true);
                    b = 28;
                }
                else if (go.CompareTag("2B"))
                {
                    TH2.SetActive(false);
                    TM2.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("3B"))
                {
                    TH3.SetActive(false);
                    TM3.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("4B"))
                {
                    TH4.SetActive(false);
                    TM4.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("5B"))
                {
                    TH5.SetActive(false);
                    TM5.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("6B"))
                {
                    TH6.SetActive(false);
                    TM6.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("7B"))
                {
                    TH7.SetActive(false);
                    TM7.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("1B"))
                {
                    TH1.SetActive(false);
                    TM1.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("9B"))
                {
                    TH9.SetActive(false);
                    TM9.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("10B"))
                {
                    TH10.SetActive(false);
                    TM10.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("11B"))
                {
                    TH11.SetActive(false);
                    TM11.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("12B"))
                {
                    TH12.SetActive(false);
                    TM12.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("13B"))
                {
                    TH13.SetActive(false);
                    TM13.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("14B"))
                {
                    TH14.SetActive(false);
                    TM14.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("15B"))
                {
                    TH15.SetActive(false);
                    TM15.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("16B"))
                {
                    TH16.SetActive(false);
                    TM16.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("17B"))
                {
                    TH17.SetActive(false);
                    TM17.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("18B"))
                {
                    TH18.SetActive(false);
                    TM18.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("19B"))
                {
                    TH19.SetActive(false);
                    TM19.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("20B"))
                {
                    TH20.SetActive(false);
                    TM20.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("21B"))
                {
                    TH21.SetActive(false);
                    TM21.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("22B"))
                {
                    TH22.SetActive(false);
                    TM22.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("23B"))
                {
                    TH23.SetActive(false);
                    TM23.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("24B"))
                {
                    TH24.SetActive(false);
                    TM24.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("25B"))
                {
                    TH25.SetActive(false);
                    TM25.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("26B"))
                {
                    TH26.SetActive(false);
                    TM26.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("27B"))
                {
                    TH27.SetActive(false);
                    TM27.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("8B"))
                {
                    TH8.SetActive(false);
                    TM8.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("29B"))
                {
                    TH29.SetActive(false);
                    TM29.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("30B"))
                {
                    TH30.SetActive(false);
                    TM30.SetActive(true);
                    UBenar.SetActive(false);
                }
                else
                {
                    TB.SetActive(true);
                    TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                    TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                    TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                    TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                    TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                    TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                    UBenar.SetActive(false);
                }
            }
            else
            {
                TB.SetActive(true);
                TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                UBenar.SetActive(false);
            }
        }
        else if (a == 29)
        {
            if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
            {
                GameObject go = hit.collider.gameObject;
                if (go.CompareTag("29B"))
                {
                    TH29.SetActive(true);
                    TM29.SetActive(false);
                    UBenar.SetActive(true);
                    b = 29;
                }
                else if (go.CompareTag("2B"))
                {
                    TH2.SetActive(false);
                    TM2.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("3B"))
                {
                    TH3.SetActive(false);
                    TM3.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("4B"))
                {
                    TH4.SetActive(false);
                    TM4.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("5B"))
                {
                    TH5.SetActive(false);
                    TM5.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("6B"))
                {
                    TH6.SetActive(false);
                    TM6.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("7B"))
                {
                    TH7.SetActive(false);
                    TM7.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("8B"))
                {
                    TH8.SetActive(false);
                    TM8.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("1B"))
                {
                    TH1.SetActive(false);
                    TM1.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("10B"))
                {
                    TH10.SetActive(false);
                    TM10.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("11B"))
                {
                    TH11.SetActive(false);
                    TM11.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("12B"))
                {
                    TH12.SetActive(false);
                    TM12.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("13B"))
                {
                    TH13.SetActive(false);
                    TM13.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("14B"))
                {
                    TH14.SetActive(false);
                    TM14.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("15B"))
                {
                    TH15.SetActive(false);
                    TM15.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("16B"))
                {
                    TH16.SetActive(false);
                    TM16.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("17B"))
                {
                    TH17.SetActive(false);
                    TM17.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("18B"))
                {
                    TH18.SetActive(false);
                    TM18.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("19B"))
                {
                    TH19.SetActive(false);
                    TM19.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("20B"))
                {
                    TH20.SetActive(false);
                    TM20.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("21B"))
                {
                    TH21.SetActive(false);
                    TM21.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("22B"))
                {
                    TH22.SetActive(false);
                    TM22.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("23B"))
                {
                    TH23.SetActive(false);
                    TM23.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("24B"))
                {
                    TH24.SetActive(false);
                    TM24.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("25B"))
                {
                    TH25.SetActive(false);
                    TM25.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("26B"))
                {
                    TH26.SetActive(false);
                    TM26.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("27B"))
                {
                    TH27.SetActive(false);
                    TM27.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("28B"))
                {
                    TH28.SetActive(false);
                    TM28.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("9B"))
                {
                    TH9.SetActive(false);
                    TM9.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("30B"))
                {
                    TH30.SetActive(false);
                    TM30.SetActive(true);
                    UBenar.SetActive(false);
                }
                else
                {
                    TB.SetActive(true);
                    TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                    TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                    TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                    TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                    TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                    TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                    UBenar.SetActive(false);
                }
            }
            else
            {
                TB.SetActive(true);
                TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                UBenar.SetActive(false);
            }
        }
        else if (a == 30)
        {
            if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
            {
                GameObject go = hit.collider.gameObject;
                if (go.CompareTag("30B"))
                {
                    TH10.SetActive(true);
                    TM10.SetActive(false);
                    UBenar.SetActive(true);
                    b = 30;
                }
                else if (go.CompareTag("2B"))
                {
                    TH2.SetActive(false);
                    TM2.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("3B"))
                {
                    TH3.SetActive(false);
                    TM3.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("4B"))
                {
                    TH4.SetActive(false);
                    TM4.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("5B"))
                {
                    TH5.SetActive(false);
                    TM5.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("6B"))
                {
                    TH6.SetActive(false);
                    TM6.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("7B"))
                {
                    TH7.SetActive(false);
                    TM7.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("8B"))
                {
                    TH8.SetActive(false);
                    TM8.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("9B"))
                {
                    TH9.SetActive(false);
                    TM9.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("1B"))
                {
                    TH1.SetActive(false);
                    TM1.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("11B"))
                {
                    TH11.SetActive(false);
                    TM11.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("12B"))
                {
                    TH12.SetActive(false);
                    TM12.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("13B"))
                {
                    TH13.SetActive(false);
                    TM13.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("14B"))
                {
                    TH14.SetActive(false);
                    TM14.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("15B"))
                {
                    TH15.SetActive(false);
                    TM15.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("16B"))
                {
                    TH16.SetActive(false);
                    TM16.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("17B"))
                {
                    TH17.SetActive(false);
                    TM17.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("18B"))
                {
                    TH18.SetActive(false);
                    TM18.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("19B"))
                {
                    TH19.SetActive(false);
                    TM19.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("20B"))
                {
                    TH20.SetActive(false);
                    TM20.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("21B"))
                {
                    TH21.SetActive(false);
                    TM21.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("22B"))
                {
                    TH22.SetActive(false);
                    TM22.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("23B"))
                {
                    TH23.SetActive(false);
                    TM23.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("24B"))
                {
                    TH24.SetActive(false);
                    TM24.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("25B"))
                {
                    TH25.SetActive(false);
                    TM25.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("26B"))
                {
                    TH26.SetActive(false);
                    TM26.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("27B"))
                {
                    TH27.SetActive(false);
                    TM27.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("28B"))
                {
                    TH28.SetActive(false);
                    TM28.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("29B"))
                {
                    TH29.SetActive(false);
                    TM29.SetActive(true);
                    UBenar.SetActive(false);
                }
                else if (go.CompareTag("10B"))
                {
                    TH10.SetActive(false);
                    TM10.SetActive(true);
                    UBenar.SetActive(false);
                }
                else
                {
                    TB.SetActive(true);
                    TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                    TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                    TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                    TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                    TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                    TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                    UBenar.SetActive(false);
                }
            }
            else
            {
                TB.SetActive(true);
                TM1.SetActive(false); TM2.SetActive(false); TM3.SetActive(false); TM4.SetActive(false); TM5.SetActive(false); TM6.SetActive(false); TM7.SetActive(false); TM8.SetActive(false); TM9.SetActive(false); TM10.SetActive(false);
                TM11.SetActive(false); TM12.SetActive(false); TM13.SetActive(false); TM14.SetActive(false); TM15.SetActive(false); TM16.SetActive(false); TM17.SetActive(false); TM18.SetActive(false); TM19.SetActive(false); TM20.SetActive(false);
                TM21.SetActive(false); TM22.SetActive(false); TM23.SetActive(false); TM24.SetActive(false); TM25.SetActive(false); TM26.SetActive(false); TM27.SetActive(false); TM28.SetActive(false); TM29.SetActive(false); TM30.SetActive(false);
                TH1.SetActive(false); TH2.SetActive(false); TH3.SetActive(false); TH4.SetActive(false); TH5.SetActive(false); TH6.SetActive(false); TH7.SetActive(false); TH8.SetActive(false); TH9.SetActive(false); TH10.SetActive(false);
                TH11.SetActive(false); TH12.SetActive(false); TH13.SetActive(false); TH14.SetActive(false); TH15.SetActive(false); TH16.SetActive(false); TH17.SetActive(false); TH18.SetActive(false); TH19.SetActive(false); TH20.SetActive(false);
                TH21.SetActive(false); TH22.SetActive(false); TH23.SetActive(false); TH24.SetActive(false); TH25.SetActive(false); TH26.SetActive(false); TH27.SetActive(false); TH28.SetActive(false); TH29.SetActive(false); TH30.SetActive(false);
                UBenar.SetActive(false);
            }
        }
    }
    public void FungsiBenar()
    {
        d = d + 1;
        c = 3;
    }
    void FungsiKlikKedua()
    { 
        if (b==1)
        {
            TB1.SetActive(false);
            TM1.SetActive(false);
            TH1.SetActive(false);
            A1.SetActive(false);
            J1.SetActive(true);
            c = 0;
        }
        else if (b ==2)
        {
            TB2.SetActive(false);
            TM2.SetActive(false);
            TH2.SetActive(false);
            A2.SetActive(false);
            J2.SetActive(true);
            c = 0;
        }
        else if (b ==3)
        {
            TB3.SetActive(false);
            TM3.SetActive(false);
            TH3.SetActive(false);
            A3.SetActive(false);
            J3.SetActive(true);
            c = 0;
        }
        else if (b ==4)
        {
            TB4.SetActive(false);
            TM4.SetActive(false);
            TH4.SetActive(false);
            A4.SetActive(false);
            J4.SetActive(true);
            c = 0;
        }
        else if (b ==5)
        {
            TB5.SetActive(false);
            TM5.SetActive(false);
            TH5.SetActive(false);
            A5.SetActive(false);
            J5.SetActive(true);
            c = 0;
        }
        else if (b ==6)
        {
            TB6.SetActive(false);
            TM6.SetActive(false);
            TH6.SetActive(false);
            A6.SetActive(false);
            J6.SetActive(true);
            c = 0;
        }
        else if (b ==7)
        {
            TB7.SetActive(false);
            TM7.SetActive(false);
            TH7.SetActive(false);
            A7.SetActive(false);
            J7.SetActive(true);
            c = 0;
        }
        else if (b ==8)
        {
            TB8.SetActive(false);
            TM8.SetActive(false);
            TH8.SetActive(false);
            A8.SetActive(false);
            J8.SetActive(true);
            c = 0;
        }
        else if (b ==9)
        {
            TB9.SetActive(false);
            TM9.SetActive(false);
            TH9.SetActive(false);
            A9.SetActive(false);
            J9.SetActive(true);
            c = 0;
        }
        else if (b ==10)
        {
            TB10.SetActive(false);
            TM10.SetActive(false);
            TH10.SetActive(false);
            A10.SetActive(false);
            J10.SetActive(true);
            c = 0;
        }
        else if (b == 11)
        {
            TB11.SetActive(false);
            TM11.SetActive(false);
            TH11.SetActive(false);
            A11.SetActive(false);
            J11.SetActive(true);
            c = 0;
        }
        else if (b == 12)
        {
            TB12.SetActive(false);
            TM12.SetActive(false);
            TH12.SetActive(false);
            A12.SetActive(false);
            J12.SetActive(true);
            c = 0;
        }
        else if (b == 13)
        {
            TB13.SetActive(false);
            TM13.SetActive(false);
            TH13.SetActive(false);
            A13.SetActive(false);
            J13.SetActive(true);
            c = 0;
        }
        else if (b == 14)
        {
            TB14.SetActive(false);
            TM14.SetActive(false);
            TH14.SetActive(false);
            A14.SetActive(false);
            J14.SetActive(true);
            c = 0;
        }
        else if (b == 15)
        {
            TB15.SetActive(false);
            TM15.SetActive(false);
            TH15.SetActive(false);
            A15.SetActive(false);
            J15.SetActive(true);
            c = 0;
        }
        else if (b == 16)
        {
            TB16.SetActive(false);
            TM16.SetActive(false);
            TH16.SetActive(false);
            A16.SetActive(false);
            J16.SetActive(true);
            c = 0;
        }
        else if (b == 17)
        {
            TB17.SetActive(false);
            TM17.SetActive(false);
            TH17.SetActive(false);
            A17.SetActive(false);
            J7.SetActive(true);
            c = 0;
        }
        else if (b == 18)
        {
            TB18.SetActive(false);
            TM18.SetActive(false);
            TH18.SetActive(false);
            A18.SetActive(false);
            J18.SetActive(true);
            c = 0;
        }
        else if (b == 19)
        {
            TB19.SetActive(false);
            TM19.SetActive(false);
            TH19.SetActive(false);
            A19.SetActive(false);
            J19.SetActive(true);
            c = 0;
        }
        else if (b == 20)
        {
            TB20.SetActive(false);
            TM20.SetActive(false);
            TH20.SetActive(false);
            A20.SetActive(false);
            J20.SetActive(true);
            c = 0;
        }
        else if (b == 21)
        {
            TB21.SetActive(false);
            TM21.SetActive(false);
            TH21.SetActive(false);
            A21.SetActive(false);
            J21.SetActive(true);
            c = 0;
        }
        else if (b == 22)
        {
            TB22.SetActive(false);
            TM22.SetActive(false);
            TH22.SetActive(false);
            A22.SetActive(false);
            J22.SetActive(true);
            c = 0;
        }
        else if (b == 23)
        {
            TB23.SetActive(false);
            TM23.SetActive(false);
            TH23.SetActive(false);
            A23.SetActive(false);
            J23.SetActive(true);
            c = 0;
        }
        else if (b == 24)
        {
            TB24.SetActive(false);
            TM24.SetActive(false);
            TH24.SetActive(false);
            A24.SetActive(false);
            J24.SetActive(true);
            c = 0;
        }
        else if (b == 25)
        {
            TB25.SetActive(false);
            TM25.SetActive(false);
            TH25.SetActive(false);
            A25.SetActive(false);
            J25.SetActive(true);
            c = 0;
        }
        else if (b == 26)
        {
            TB26.SetActive(false);
            TM26.SetActive(false);
            TH26.SetActive(false);
            A26.SetActive(false);
            J26.SetActive(true);
            c = 0;
        }
        else if (b == 27)
        {
            TB27.SetActive(false);
            TM27.SetActive(false);
            TH27.SetActive(false);
            A27.SetActive(false);
            J27.SetActive(true);
            c = 0;
        }
        else if (b == 28)
        {
            TB28.SetActive(false);
            TM28.SetActive(false);
            TH28.SetActive(false);
            A28.SetActive(false);
            J28.SetActive(true);
            c = 0;
        }
        else if (b == 29)
        {
            TB29.SetActive(false);
            TM29.SetActive(false);
            TH29.SetActive(false);
            A29.SetActive(false);
            J29.SetActive(true);
            c = 0;
        }
        else if (b == 30)
        {
            TB30.SetActive(false);
            TM30.SetActive(false);
            TH30.SetActive(false);
            A30.SetActive(false);
            J30.SetActive(true);
            c = 0;
        }
    }
    
    //Level Control
    public void youWin()
    {
        if (sceneIndex == 6)
            Invoke("loadMainMenu", 1f);
        else
        {
            if (levelPassed < sceneIndex)
                PlayerPrefs.SetInt("LevelPassed", sceneIndex);
            Invoke("loadNextLevel", 1f);
        }
    }
    public void youBack()
    {
        Invoke("LoadMainMenu", 1f);
    }
    public void youReply()
    {
        Invoke("LoadAgain", 1f);
    }
    void LoadNextLevel()
    {
        SceneManager.LoadScene(sceneIndex + 1);
    }
    void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    void LoadAgain()
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
