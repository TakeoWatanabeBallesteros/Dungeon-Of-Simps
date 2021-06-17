using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PointsManager : MonoBehaviour
{
    int points = 0;
    public Text pointsText;
    public GameObject text;
    public static PointsManager pointsManager;
    // Start is called before the first frame update
    void Start()
    {
        if (pointsManager == null)
        {
            pointsManager = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        Destroy(this);
    }

    // Update is called once per frame
    void Update()
    {
        if (pointsText == null)
        {
            pointsText = GameObject.Find("Points").GetComponent<Text>();
            pointsText.text = points.ToString("");
        }
    }
    public void PointsUpdate(int plus)
    {
        points+= plus;
        pointsText.text = points.ToString("");
    }
}
