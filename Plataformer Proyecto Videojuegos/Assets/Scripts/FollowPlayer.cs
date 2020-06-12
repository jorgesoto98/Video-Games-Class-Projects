using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private Vector3 posicion;
    public GameObject Player;

    void Start()
    {
        posicion = transform.position - Player.transform.position;
    }

    void Update()
    {
        transform.position = new Vector3 (Player.transform.position.x + posicion.x,-2,-4);
    }
}
