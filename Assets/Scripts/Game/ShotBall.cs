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

        GameObject bullet = Instantiate(ballToShoot, shootingPoint.position, shootingPoint.rotation); // Cr�e une copie de votre prefab � la position de tir
        Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody>(); // Acc�de au Rigidbody de la balle
        bulletRigidbody.AddForce(shootingPoint.forward * shootingForce); // Ajoute une force pour "tirer" la balle
    }
}
