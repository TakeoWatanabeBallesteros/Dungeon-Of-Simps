using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PatrolAI : MonoBehaviour
{
    enum EPatrol
    {
        Start,
        Patrol,
        Wait
    }

    FSM<EPatrol> brain;

    public Transform path;
    Rigidbody2D rb;

    List<Transform> waypoints;

    int nextWaypoint;

    float counterTimer, speed = 2f;
    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        waypoints = path.GetComponentsInChildren<Transform>().ToList();

        brain = new FSM<EPatrol>(EPatrol.Start);

        // Start
        brain.SetOnStay(EPatrol.Start, () =>
        {
            nextWaypoint = 0;
            brain.ChangeState(EPatrol.Patrol);
        });

        // Patrol
        brain.SetOnStay(EPatrol.Patrol, PatrolUpdate);
        brain.SetOnExit(EPatrol.Patrol, () => ++nextWaypoint);

        // Wait
        brain.SetOnStay(EPatrol.Wait, WaitUpdate);
        brain.SetOnEnter(EPatrol.Wait, () =>
        {
            counterTimer = 0.0f;
        });
    }

    void PatrolUpdate()
    {
        Vector2 dir = (waypoints[nextWaypoint].position - transform.position).normalized;
        rb.velocity = new Vector2(dir.x*speed, dir.y*speed);
        if (Vector2.Distance(waypoints[nextWaypoint].position, transform.position) < 0.1f)
        {
            rb.velocity = Vector2.zero;
            brain.ChangeState(EPatrol.Wait);
            return;
        }
    }

    void WaitUpdate()
    {
        counterTimer += Time.deltaTime;

        if (counterTimer > 1.0f)
        {
            if (nextWaypoint >= waypoints.Count)
            {
                //waypoints.Reverse();
                brain.ChangeState(EPatrol.Start);
                return;
            }

            brain.ChangeState(EPatrol.Patrol);
            return;
        }
    }

    public void PatrolAIUpdate()
    {
        brain.Update();
    }
}
