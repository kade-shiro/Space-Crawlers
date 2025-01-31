using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    public static int enemy;
    void OnCollisionEnter2D(Collision2D other) {
        ManageScenes sceneManager = GameObject.FindObjectOfType(typeof(ManageScenes)) as ManageScenes;

        if(other.gameObject.tag == "Octocat") {
            StartCoroutine(sceneManager.LoadScene("Battle"));
            StartCoroutine(DestroyEnemy(other.gameObject));
            enemy = 0;
        }

        if(other.gameObject.tag == "Worm") {
            StartCoroutine(sceneManager.LoadScene("Battle"));
            StartCoroutine(DestroyEnemy(other.gameObject));
            enemy = 1;
        }
    }

    IEnumerator DestroyEnemy(GameObject enemy) {
        yield return new WaitForSeconds(2f);
        Destroy(enemy.gameObject);
    }
}
