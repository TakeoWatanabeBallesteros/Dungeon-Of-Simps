using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.InputSystem;

public class BulletSpawner : MonoBehaviour
{
    private float speed;
    public GameObject bulletPrefab;
    Vector2 mousePos;
    public static int indx;

    public delegate void OnShootDelegate();
    public static OnShootDelegate OnShoot;
    public delegate void GunPowerUpDelegate();
    public static GunPowerUpDelegate GunPowerUp;
    public delegate void GunTypeUpDelegate();
    public static GunTypeUpDelegate GunType;
    public static List<int>TypeAttack;

    private void OnEnable() {
        PlayerAttack.OnAttack += _Shoot;
        GameFlowControler.Restart += RestartGun;
    }
    private void OnDisable() {
        PlayerAttack.OnAttack -= _Shoot;
        GameFlowControler.Restart -= RestartGun;
    }
    // Start is called before the first frame update
    void Start()
    {
        TypeAttack = new List<int>();
        TypeAttack.Add(0);
        Controls.controls.PlayerControls.MouseAim.performed += ctx => mousePos = ctx.ReadValue<Vector2>();
        Controls.controls.PlayerControls.SwitchGun.started +=_=>SwitchGun();
        speed = 10.0f;
    }
    // Update is called once per frame
    void Update()
    {
        TriggerDirection();
    }
    public void TriggerDirection(){
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(mousePos);
        Vector3 aimDirection = (mousePosition - transform.position).normalized;
        float angle = Mathf.Atan2(aimDirection.y, aimDirection.x)*Mathf.Rad2Deg;
        gameObject.GetComponent<Transform>().rotation=Quaternion.Euler(0,0,angle);
        float xPos = Mathf.Cos(Mathf.Deg2Rad *angle) * 1.1f;
        float yPos = Mathf.Sin(Mathf.Deg2Rad *angle) * 1.1f;
        transform.localPosition = new Vector3(xPos, yPos, 1);
    }
    IEnumerator DefaultShoot(){
            yield return new WaitForSeconds(.3f);
            OnShoot?.Invoke();
            GameObject bulletClones = Instantiate(bulletPrefab);
            bulletClones.transform.position =  new Vector3(transform.position.x, transform.position.y, 1);
            bulletClones.transform.rotation = transform.rotation;
            bulletClones.GetComponent<Rigidbody2D>().velocity = transform.right*speed;
        
    }
    IEnumerator ThreeShoot(){
            yield return new WaitForSeconds(.3f);
            OnShoot?.Invoke();
            
            float startAngle = -15, endAngle = 15;
            int lines = 3;
            float angleStep = (endAngle - startAngle)/lines;
            float angle = startAngle;
            for (int i = 0; i < lines; i++)
            {
                GameObject bulletClones = Instantiate(bulletPrefab);
                bulletClones.transform.position =  new Vector3(transform.position.x, transform.position.y, 1);
                var direction = Quaternion.Euler(0, 0, angle)*transform.right;
                bulletClones.transform.rotation = transform.rotation;
                bulletClones.GetComponent<Rigidbody2D>().velocity = direction*speed;

                angle += angleStep;
            }
    }
    IEnumerator CircleShoot(){
            yield return new WaitForSeconds(.3f);
            OnShoot?.Invoke();
            
            float startAngle = 0, endAngle = 360;
            int lines = 10;
            float angleStep = (endAngle - startAngle)/lines;
            float angle = startAngle;
            for (int i = 0; i < lines; i++)
            {
                GameObject bulletClones = Instantiate(bulletPrefab);
                bulletClones.transform.position =  new Vector3(transform.position.x, transform.position.y, 1);
                var direction = Quaternion.Euler(0, 0, angle)*transform.right;
                bulletClones.transform.rotation = transform.rotation;
                bulletClones.GetComponent<Rigidbody2D>().velocity = direction*speed;

                angle += angleStep;
            }
    }
    void _Shoot(){
        switch (TypeAttack[indx])
        {
            case 0:
                StartCoroutine(DefaultShoot());
                break;
            case 1:
                StartCoroutine(ThreeShoot());
                break;
            case 2:
                StartCoroutine(CircleShoot());
                break;
            default:
                break;
        }
    }
    void SwitchGun(){
        if(TypeAttack.Count-1==indx){
            indx = 0;
        }else{
            indx++;
        }
        GunType?.Invoke();
    }
    void RestartGun(){
        TypeAttack.Clear();
        TypeAttack.Add(0);
        indx = 0;
        GunType?.Invoke();
    }
}
