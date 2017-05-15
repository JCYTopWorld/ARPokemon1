using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public Button btn1, btn2;
    public Text appName;
    // Use this for initialization
    void Start()
    {
        btn1.onClick.AddListener(OnClick_btn1);
        btn2.onClick.AddListener(OnClick_btn2);
        appName.text = Application.loadedLevelName;
    }

    void OnClick_btn1()
    {
        Application.LoadLevel("IOPMGO_MAIN");
    }

    void OnClick_btn2()
    {
        Application.LoadLevel("IOPMGO_TEST");
    }
    // Update is called once per frame
    void Update()
    {
        if (Application.platform == RuntimePlatform.Android && (Input.GetKeyDown(KeyCode.Escape)))
        {
            Application.Quit();
        }

    }

}
