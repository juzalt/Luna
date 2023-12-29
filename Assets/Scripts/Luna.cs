using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luna : MonoBehaviour
{
    [SerializeField] public Camera playerCam;

    // units per second
    public float speed = 99999;

    void Update()
    {
        // remember, 10 - 5 is 5, so target - position is always your direction.
        Vector3 dir = playerCam.transform.position - transform.position;

        // magnitude is the total length of a vector.
        // getting the magnitude of the direction gives us the amount left to move
        float dist = dir.magnitude;

        // this makes the length of dir 1 so that you can multiply by it.
        dir = dir.normalized;

        // the amount we can move this frame
        float move = speed * Time.deltaTime;

        // limit our move to what we can travel.
        if (move > dist) move = dist;

        // apply the movement to the object.
        transform.Translate(dir * move);
    }





    /**Vector3 _posicionLuna;
    Vector3 _posicionJugador;
    Vector3 _distancia;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 _posicionLuna = transform.position;
        Vector3 _posicionJugador = playerCam.transform.position;
        //float distanceToPlayer = Vector3.Distance(playerCam.transform.position, this.transform.position);
        //Debug.Log(distanceToPlayer);
        Vector3 _distancia = _posicionJugador - _posicionLuna;
    }


    void LateUpdate()
    {
        _posicionLuna = _distancia.normalized * _distancia.magnitude * Time.deltaTime;
        //Debug.Log("_posicionLuna" +  _posicionLuna);
        //Debug.Log("_distancia.normalized " + _distancia.normalized);
        //Debug.Log("_distancia.magnitude " + _distancia.magnitude);
        //Debug.Log("Time.deltaTime " + Time.deltaTime);
    }*/
}
