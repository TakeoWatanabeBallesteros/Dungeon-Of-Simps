using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorsLocation : MonoBehaviour
{
    LevelActions _levelActions;
    public List<Transform>Locations;
    private void Start() {
        StartCoroutine(Positions());
    }
    IEnumerator Positions(){
        yield return new WaitForSeconds(0.001f);
        _levelActions=FindObjectOfType<LevelActions>();
        _levelActions.Restore();
    }
}
