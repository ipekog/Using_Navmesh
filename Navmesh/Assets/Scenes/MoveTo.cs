using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class MoveTo : MonoBehaviour
{

    public NavMeshAgent player;
    public Transform moveTo;
    public Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        player.destination = moveTo.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray click = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit clicked;
            
            if(Physics.Raycast(click, out clicked))
            {
                player.SetDestination(clicked.point);
            }
        }
    }
}
