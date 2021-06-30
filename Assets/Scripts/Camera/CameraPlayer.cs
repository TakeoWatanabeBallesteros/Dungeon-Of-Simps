using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayer : MonoBehaviour
{
    public float smoothSpeed;
    public static bool normal = true;
    [SerializeField]
    float normalSize;
    [SerializeField]
    float zoomOutSize;
    Transform player;
    Rigidbody2D rb;
    Vector3 velocity;
    public Vector3 offset;
    Camera cam;
    private void Start() {
        cam = GetComponent<Camera>();
        player = PlayerSingleton.Instance.GetComponent<Transform>();
        rb = PlayerSingleton.Instance.GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate() {
        FollowPlayer();
        CameraSize();
    }
    void FollowPlayer(){
        float xDif = PlayerSingleton.Instance.transform.position.x - transform.position.x;
        float yDif = PlayerSingleton.Instance.transform.position.y - transform.position.y;
        //if((xDif>.55||xDif<-.55)||(yDif>.3||yDif<-.3)){
            Vector3 desiredPosition = new Vector3(player.position.x + offset.x + rb.velocity.x*1.2f, player.position.y+offset.y*1.2f + rb.velocity.y, -10);
            Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredPosition,ref velocity,smoothSpeed*Time.fixedDeltaTime);
            transform.position = smoothedPosition;
        //}
    }
    void CameraSize(){
        if(normal){
            cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, normalSize, 0.1f);
        }else{
            cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, zoomOutSize, 0.1f);
        }
    }
}
