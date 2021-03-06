 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using LibGameAI.DecisionTrees;
using System;




public class NPC_AI_One : MonoBehaviour
{
    // Destiny of the AI Agents depending the actual status
    [SerializeField] private Transform stage_destiny;

    [SerializeField] private Transform bar_destiny;

    [SerializeField] private Transform greenZone_destiny;

    [SerializeField] private Transform exit_destiny;

    //AI Agent Status (Food)
    [SerializeField]
    [Range(0, 10)]
    private int food = 10;

    //AI Agent Status (stamina)
    [SerializeField]
    [Range(0, 10)]
    private int stamina = 10;

    //Speed of AI agent movement
    [SerializeField]
    [Range(0f, 20f)]
    private float speed = 5f;

    //Decision Tree root
    private IDecisionTreeNode root;

    private IDecisionTreeNode second_branch;

    private IDecisionTreeNode third_branch;

    private NavMeshAgent npc;

    private int DelayAmount = 120; //Delay time to AI Agent recover the food and  stamina status
    private int DelayAmount_Minus_food = 40; //Delay time to AI Agent loss 1 food bar
    private int DelayAmount_Minus_stamina = 160; //Delay time to AI Agent loss 1 stamina bar

    protected float Timer;

    public GameObject Explosion;

    
    
    //private int rnd;
    private void Awake()
    {
        npc = GetComponent<NavMeshAgent>();
        npc.SetDestination(stage_destiny.position);
    }
    // Start is called before the first frame update
    void Start()
    {
        
       

        //Create the leaf actions
        IDecisionTreeNode InDanger  = new ActionNode(InDangerAction);
        IDecisionTreeNode Tired     = new ActionNode(TiredAction);
        IDecisionTreeNode Hungry    = new ActionNode(HungryAction);
        IDecisionTreeNode Normal    = new ActionNode(NormalAction);

        // Create the root node
        
        third_branch = new DecisionNode(TiredState, Tired, Normal);

        second_branch = new DecisionNode(HungryState,Hungry,third_branch);

        root = new DecisionNode (InDangerState,InDanger, second_branch);

       // gameObject.tag = "AI_Agent_1";

    }

    //Update is called once per frame
    private void Update()
    {
        ActionNode actionNode = root.MakeDecision() as ActionNode;
        actionNode.Execute();

        // Time to recover food
        Timer += Time.deltaTime;

        if (food <= 2)
        {
            if (Timer >= DelayAmount)
            {
                Timer = 0f;
                food += 8;
                
            }
            
        }

        //Time to lose food
        else
        {
            if (Timer >= DelayAmount_Minus_food)
            {
                Timer = 0f;
                food--;
            }
        }

        //Time to gain stamina
        if (stamina <= 2)
        {
            if (Timer >= DelayAmount)
            {
                Timer = 0f;
                stamina += 8;
            }

        }

        //Time to lose stamina
        else
        {
            if (Timer >= DelayAmount_Minus_stamina)
            {
                Timer = 0f;
                stamina--;
            }
        }

    }


    //Check if AI_Agent is in danger
     private bool InDangerState()
    {
        if (Explosion == GameObject.FindGameObjectWithTag("Explosion")) return true; //if explosion <= 3 radius
        return false;
        
        
    }

   private void InDangerAction()
   {
        //go to waypoint
        npc.SetDestination(exit_destiny.position);
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
        npc.SetDestination(greenZone_destiny.position);
        
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
        npc.SetDestination(bar_destiny.position);

    }

   
    //Check if AI_Agent is normal
    private void NormalAction()
    {
        
        if (stamina > 2 && food > 2)
        npc.SetDestination(stage_destiny.position);
    }

    
   
}















