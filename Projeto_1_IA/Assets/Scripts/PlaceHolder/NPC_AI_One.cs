using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using LibGameAI.DecisionTrees;
using System;


public class NPC_AI_One : MonoBehaviour
{
    // Destiny of the AI Agents depending the actual status
    [SerializeField] private Transform stage_destiny_1;
    [SerializeField] private Transform stage_destiny_2;
    [SerializeField] private Transform bar_destiny_1;
    [SerializeField] private Transform bar_destiny_2;
    [SerializeField] private Transform bar_destiny_3;
    [SerializeField] private Transform bar_destiny_4;
    [SerializeField] private Transform greenZone_destiny_1;
    [SerializeField] private Transform greenZone_destiny_2;
    [SerializeField] private Transform greenZone_destiny_3;
    [SerializeField] private Transform greenZone_destiny_4;

    //AI Agent Status
    [SerializeField]
    [Range(0, 10)]
    private int health = 10;
     

    [SerializeField]
    [Range(0, 10)]
    private int food = 10;

    [SerializeField]
    [Range(0, 10)]
    private int stamina = 10;

    //Speed of AI agent movement
    [SerializeField]
    [Range(0f, 20f)]
    private float speed = 5f;

    //Decision Tree root
    private IDecisionTreeNode root;

    //private IDecisionTreeNode second_branch;

    private IDecisionTreeNode third_branch;

    private NavMeshAgent npc;

    private int DelayAmount = 120; //Delay time to AI Agent recover the food and  stamina status
    private int DelayAmount_Minus_food = 40; //Delay time to AI Agent loss 1 food bar
    private int DelayAmount_Minus_stamina = 160; //Delay time to AI Agent loss 1 stamina bar

    protected float Timer;

    private int digit;
    
    //private int rnd;
    private void Awake()
    {
        npc = GetComponent<NavMeshAgent>();
        npc.SetDestination(stage_destiny_1.position);
    }
    // Start is called before the first frame update
    void Start()
    {
       // digit = UnityEngine.Random.Range(0, 101);

        //Create the leaf actions
        //IDecisionTreeNode InDanger = new ActionNode(InDangerAction);
        IDecisionTreeNode Tired = new ActionNode(TiredAction);
        IDecisionTreeNode Hungry = new ActionNode(HungryAction);
        IDecisionTreeNode Normal = new ActionNode(NormalAction);

        // Create the root node
        // root = new DecisionNode (Danger,InDanger, Hungry);
        third_branch = new DecisionNode(TiredState, Tired, Normal);

        root = new DecisionNode(HungryState,Hungry,third_branch);

        

    }

    //Update is called once per frame
    private void Update()
    {
        ActionNode actionNode = root.MakeDecision() as ActionNode;
        actionNode.Execute();

        Timer += Time.deltaTime;

        if (food <= 2)
        {
            if (Timer >= DelayAmount)
            {
                Timer = 0f;
                food = food + 8;
                digit = UnityEngine.Random.Range(0, 101);
            }
            //digit = UnityEngine.Random.Range(0, 101);
        }

        else
        {
            if (Timer >= DelayAmount_Minus_food)
            {
                Timer = 0f;
                food--;
            }
        }

        if (stamina <= 2)
        {
            if (Timer >= DelayAmount)
            {
                Timer = 0f;
                stamina = stamina + 8;
            }

        }

        else
        {
            if (Timer >= DelayAmount_Minus_stamina)
            {
                Timer = 0f;
                stamina--;
            }
        }


        //digit = UnityEngine.Random.Range(0, 101);
        UnityEngine.Debug.Log(digit);



    }


    //Check if AI_Agent is Tired
    private bool TiredState()
    {
        if (stamina <= 2) return true;
        return false;
    }

    private void TiredAction()
    {
        // go to waypoint (GreenZone)
        //digit = UnityEngine.Random.Range(0, 101);
        if(digit >= 1 && digit <= 25)
        {
            npc.SetDestination(greenZone_destiny_1.position);
        }

        if (digit >= 25 && digit <= 50)
        {
            npc.SetDestination(greenZone_destiny_2.position);
        }

        if (digit >= 50 && digit <= 75)
        {
            npc.SetDestination(greenZone_destiny_3.position);
        }

        if (digit >= 75 && digit <= 100)
        {
            npc.SetDestination(greenZone_destiny_4.position);
        }


    }



    //Check if AI_Agent is Hungry
    private bool HungryState()
    {
        if (food <= 2) return true;
        return false;
     
    }

    private void HungryAction()
    {
        // go to waypoint (Bar)
        npc.SetDestination(bar_destiny_1.position);

    }

   
    //Check if AI_Agent is normal
    private void NormalAction()
    {
        
        if (stamina > 2 && food > 2)
        npc.SetDestination(stage_destiny_1.position);
    }

    //Check if AI_Agent is in danger

   private void InDangerAction()
   {
        //if agent in danger, go to exit (Stage)
       // MoveTowardsTarget(CurrentWaypoint);
   }
   // private void OnTriggerEnter(Collider col)
   // {
   //     if (col.name == "Destiny")
   //     {
   //         rnd = Random.Range(0, 5);
   //         Invoke("Destination", rnd);
    //    }
    //}

   // private void Destination()
    //{
    //    npc.SetDestination(normal_destiny.position);
    //}
}















