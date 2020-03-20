using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolState : State
{
    // Start is called before the first frame update
    Transform destination;
   public PatrolState(StateController stateController): base(stateController){}

   public override void CheckTransitions(){
       //todo check if player is in range! if so switch to  to attack/chase
       if(stateController.CheckIfInRange("PlayerLight")){
           Debug.Log("Player Detected");
           stateController.SetState(new ChaseState(stateController));
            //dogisscared = true;
       }
       //if(dogisscared == true){
       //    Debug.Log("Dog is scared");
       //    stateController.SetState(new RunToDog(stateController));
            
       //}
       
   }
   public override void Act(){
       if(destination == null || stateController.aI.DestinationReached()){
           destination = stateController.GetNextNavPoint();
           stateController.aI.SetTarget(destination);
       }
   }
   public override void OnStateEnter(){
       destination = stateController.GetNextNavPoint();
       if(stateController.aI.agent != null){
        stateController.aI.agent.speed = 5.38f;
       }
       stateController.aI.SetTarget(destination);
      // stateController.ChangeColor(Color.blue);
        
   }
    

}
