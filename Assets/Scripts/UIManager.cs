using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject ModelMain;
    private Button StartGame;
    Transform zhunxing;
    // Start is called before the first frame update
    void Start()
    {
        StartGame = transform.Find("start").GetComponent<Button>();
        zhunxing = transform.Find("Image");

        StartGame.onClick.AddListener(delegate() { startgame(); });
    }

    void startgame() {
        ModelMain.SetActive(true);
        GameManager.Instance.state = GameState.Start;
        StartGame.gameObject.SetActive(false);
        zhunxing.gameObject.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
