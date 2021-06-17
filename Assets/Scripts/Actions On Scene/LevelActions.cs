using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Linq;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class LevelActions : MonoBehaviour 
{
    static LevelActions levelActions;
    List<GameObject> leaverSwitch;
    CheckPoint checkPoint;
    List<Transform>Locations;
    Transform Location;
    private void Awake() {
        if(levelActions == null){
            levelActions = this;
            DontDestroyOnLoad(gameObject);
        } else{
            Destroy(gameObject);
        }
    }
    private void Start(){
        Restore();
        Controls.controls.PlayerControls.Use.performed +=_=>Actions();
    }
    public void Actions(){
        foreach (GameObject leaver in leaverSwitch)
        {
            if(leaver.gameObject.transform.parent.gameObject.activeSelf){
                leaver.GetComponent<LeaverSwitch>().OpenTheDoor();
            }
        }
        checkPoint.CheckPoint_();
    }
    public void Restore(){
        leaverSwitch = GetAllObjectsInScene();
        checkPoint = FindObjectOfType<CheckPoint>();
        Locations = FindObjectOfType<DoorsLocation>().Locations;
        Location = FindObjectOfType<CheckPointLocation>().Location;
        for(int i = 0; i < leaverSwitch.Count; i++)
        {
            if(Locations.Count > i){
                leaverSwitch[i].transform.parent.transform.position = Locations[i].position;
                leaverSwitch[i].transform.parent.gameObject.SetActive(true);
                if(leaverSwitch[i].GetComponent<LeaverSwitch>().Open){
                    leaverSwitch[i].GetComponent<LeaverSwitch>().CloseDoor();
                }
            }else{
                leaverSwitch[i].transform.parent.gameObject.SetActive(false);
            }
        }
        checkPoint.transform.position = Location.position;
        checkPoint.fireLight.SetActive(false);
        checkPoint.TurnOff();
    }
    private static List<GameObject> GetAllObjectsInScene() { 
        List<GameObject> objectsInScene = new List<GameObject>();

        foreach (GameObject go in Resources.FindObjectsOfTypeAll(typeof(GameObject)) as GameObject[])
        {
            //!EditorUtility.IsPersistent(go.transform.root.gameObject) && 
            if (go.scene.name!=null&&!(go.hideFlags == HideFlags.NotEditable || go.hideFlags == HideFlags.HideAndDontSave)
                &&go.GetComponent<LeaverSwitch>()!=null)
                objectsInScene.Add(go);
        }

        return objectsInScene;
     }
}