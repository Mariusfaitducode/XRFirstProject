using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotBall : MonoBehaviour
{

    public GameObject ballToShoot;
    public Transform shootingPoint;
    public float shootingForce = 1000f;

    public void Shoot()
    {

        Debug.Log("SHOOOOT");

        GameObject bullet = Instantiate(ballToShoot, shootingPoint.position, shootingPoint.rotation); // Crée une copie de votre prefab à la position de tir
        Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody>(); // Accède au Rigidbody de la balle
        bulletRigidbody.AddForce(shootingPoint.forward * shootingForce); // Ajoute une force pour "tirer" la balle
    }
}
