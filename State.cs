using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//here we we have voids that trigger the swaps or at the very least have the names
public abstract class State 
{
  protected StateController stateController;

  public abstract void Act();

  public abstract void CheckTransitions();

  public virtual void OnStateEnter(){}

  public virtual void OnStateExit(){}
  public bool dogisscared = false;

//Contructor
public State(StateController stateController){
    this.stateController = stateController;
}
    

}
