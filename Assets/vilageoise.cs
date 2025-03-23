using UnityEngine;

public class NPCInteraction : MonoBehaviour
{
    public Transform player;  // Référence au transform du joueur
    public float detectionRadius = 2f;  // Rayon de détection

    void Update()
    {
        // Calcule la distance entre le NPC et le joueur
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        // Vérifie si le joueur est à moins de 2 unités
        if (distanceToPlayer <= detectionRadius)
        {
            Debug.Log("Le joueur est proche du NPC !");
        }
    }
}