using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState {
    Start,
    Pause,
    End,
}
public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    //public GameObject Attacker;
    public Transform[] StartPoints;
    public GameObject[] Girls;
    public Transform ModelParent;
    public GameState state=GameState.End;
    float index = 0;
    string c="";
    public static GameManager Instance { get => _instance; set => _instance = value; }
    private void Awake()
    {
        _instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
       //GameManager.Instance.state = GameState.Start;
    }
    private void OnGUI()
    {
        //GUI.Label(new Rect(100,100,80,40),new GUIContent(c));
    }
    void InstantiateAttacker() {
        int a = Random.Range(0,2);
        int b = Random.Range(0,Girls.Length);
        GameObject go=Instantiate(Girls[b], StartPoints[a].position,Quaternion.identity, ModelParent);
        //go.transform.localPosition = StartPoints[0].localPosition;
        //c=go.GetComponent<WaypointsNavMesh>().EndPoint3.y
    }
    // Update is called once per frame
    void Update()
    {
        if (state == GameState.Start && ModelParent.gameObject.activeSelf)
        {
            if ((index += Time.deltaTime) >= 2)
            {
                index = 0;
                InstantiateAttacker();
            }
        }
    }
}
