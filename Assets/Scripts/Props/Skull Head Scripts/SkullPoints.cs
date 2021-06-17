using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkullPoints : MonoBehaviour
{
    private int extraZone;
    // Start is called before the first frame update
    private void Update() {
        if(extraZone >=30){
            SceneManager.LoadScene("Level03");
        }
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Bullet"){
            PointsManager.pointsManager.PointsUpdate(1);
            extraZone++;
        }
    }
}
