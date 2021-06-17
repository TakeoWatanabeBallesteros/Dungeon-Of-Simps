using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MouseCursor : MonoBehaviour
{
    public Texture2D mouseCursorMenu, mouseCursorGameplay, mouseCursorShooting;
    
    private void OnEnable() {
        PlayerAttack.OnAttack += SetCursorShooting;
        PlayerHealth.OnDeath += SetCursorMenu;
        BulletSpawner.OnShoot += SetCursorGameplay;
        GameFlowControler.OnMenu += SetCursorMenu;
        GameFlowControler.OnGame += SetCursorGameplay;
    }
    private void OnDisable() {
        PlayerAttack.OnAttack -= SetCursorShooting;
        PlayerHealth.OnDeath -= SetCursorMenu;
        BulletSpawner.OnShoot -= SetCursorGameplay;
        GameFlowControler.OnMenu -= SetCursorMenu;
        GameFlowControler.OnGame -= SetCursorGameplay;
    }

    void Start()
    {
        if(SceneManager.GetActiveScene().name=="MainMenu")
            SetCursorMenu();
        else
            SetCursorGameplay();
    #if UNITY_STANDALONE
        Cursor.lockState = CursorLockMode.Confined;
    #endif

    #if UNITY_EDITOR
        Cursor.lockState = CursorLockMode.None;
    #endif
    }
    public void SetCursorMenu(){//pause menu
        Cursor.SetCursor(mouseCursorMenu, Vector2.zero, CursorMode.Auto);
    }
    public void SetCursorGameplay(){//pause menu
        Cursor.SetCursor(mouseCursorGameplay, Vector2.zero, CursorMode.Auto);
    }
    public void SetCursorShooting(){
        Cursor.SetCursor(mouseCursorShooting, Vector2.zero, CursorMode.Auto);
    }
}
