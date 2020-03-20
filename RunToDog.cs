using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunToDog : State
{
   //Basicly This Script adds a state where the dog will call over the the hunter and the hunter will run over
   // Right now though its working in the opsite 
     Transform destination;
   public RunToDog(StateController stateController): base(stateController){}

   public override void CheckTransitions(){
        //Checks if Dog or hunter is not in range to run to
        if (!stateController.CheckForDog("Dog"))
        {
            stateController.SetState(new PatrolState(stateController));

        }//Also Checks if player is not 
        if (!stateController.CheckIfInRange("Player"))
        {
            stateController.SetState(new PatrolState(stateController));

        }

    }
   public override void Act(){
        //Here is where it actually overrides and sets this state
        // problem here is with boolean it constantly causes problems in the patroller state 
        //so I moved here.
       if(stateController.DogToChase != null){
           destination = stateController.DogToChase.transform;
           stateController.aI.SetTarget(destination);
            dogisscared = false;
       }
   }
   public override void OnStateEnter(){
        //simple color changer
       stateController.ChangeColor(Color.yellow);
       stateController.aI.agent.speed = 1f;
      
       
   }
  

}
