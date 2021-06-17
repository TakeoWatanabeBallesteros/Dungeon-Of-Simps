using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlesGenerator : MonoBehaviour
{
    public GameObject dashParticle, barrilParticle;
    GameObject player;
    void Start()
    {
        player = PlayerSingleton.Instance;
    }

    void OnEnable(){
        PlayerAbilities.OnDash += DashParticle;
    }
    void OnDisable(){
        PlayerAbilities.OnDash -= DashParticle;
    }
    void DashParticle(){
        Instantiate(dashParticle, player.transform.position, Quaternion.identity);
    }
}
