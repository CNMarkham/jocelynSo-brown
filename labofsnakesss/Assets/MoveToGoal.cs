using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveToGoal : MonoBehaviour
{
    public Transform goal;
    public Transform magicspell;
    private Animator animator;
    private NavMeshAgent agent;

    private void Start()
    {
        animator = GetComponentInChildren<Animator>();
        agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
    }

    private void Update()
    {
        if (agent.hasPath)
        {
            animator.SetBool("isRunning", true); 
        }
        else
        {
            animator.SetBool("IsRunning", false);
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        //i give upppppppppppppppppppppppppppp 
        if (collision.gameObject.CompareTag("magic"))
        {
            Destroy(collision.gameObject);
            agent.destination = magicspell.position;
        }
    }
}
