using UnityEngine;

public class Hitted_bu_hero : MonoBehaviour
{

    GameObject GameObject;
    Animator animator;

    bool fight = false;

    void Start()
    {
        GameObject = GetComponent<GameObject>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (fight == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Was hitted!");
                animator.SetBool("Fight", true);
            }
            else
                animator.SetBool("Fight", false);
        }
    }

    void OnTriggerEnter(Collider myTrigger)
    {
        if (myTrigger.gameObject.name == "Hero")
        {
            Debug.Log("Was through!");
            fight = true;
        }
    }
}
