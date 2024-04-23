using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslatePlatform : MonoBehaviour
{
    public float distance = 5.0f; // Distance que l'objet va parcourir
    public float speed = 1.0f; // Vitesse de l'animation

    private Vector3 startPosition; // Position de départ
    private Vector3 endPosition; // Position de fin
    private bool movingForward = true; // Direction du mouvement
    private float startTime; // Temps au début du mouvement

    void Start()
    {
        startPosition = transform.position;
        endPosition = startPosition + transform.right * distance; // Calcule la position finale en avant
        startTime = Time.time;
    }

    void Update()
    {
        // Calculer le facteur d'interpolation
        float t = (Mathf.Sin((Time.time - startTime) * speed) + 1.0f) / 2.0f;

        // Lerp la position de l'objet
        transform.position = Vector3.Lerp(startPosition, endPosition, t);
    }
}
