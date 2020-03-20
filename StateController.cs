using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateController : MonoBehaviour
{
  public State currentState;
  public GameObject[] navPoints;
  public GameObject enemyToChase;
  public int navPointNum;
  public float remainingDistance;
  public Transform destination;
  public UnityStandardAssets.Characters.ThirdPerson.AICharacterControl aI;
  public Renderer[] childrenRend;
  public  GameObject[] enemies;
  public float detectionRange = 8;
  public float DogDetectionrange = 60;
  public GameObject[] Dog;
  public GameObject DogToChase;

  public Transform GetNextNavPoint()
  {
      navPointNum = (navPointNum + 1) % navPoints.Length;
      return navPoints[navPointNum].transform;
  }
  public void ChangeColor(Color color){
      foreach(Renderer r in childrenRend){
          foreach(Material m in r.materials){
              m.color = color;
          }
      }
  }//this one detects objects with certain tags
  public bool CheckIfInRange(string tag){
     enemies = GameObject.FindGameObjectsWithTag(tag);
     if (enemies != null){
         foreach (GameObject g in enemies){
             if(Vector3.Distance(g.transform.position, transform.position) < detectionRange){
                enemyToChase = g;
                return true;
             }
         }
     }
     return false;
  }
    //Yay Here we have the dog code that allows the hunter or dog to run to each other
  public bool CheckForDog(string tag){
      Dog = GameObject.FindGameObjectsWithTag("Dog");
      if(Dog != null){
          foreach(GameObject d in Dog){
              if(Vector3.Distance(d.transform.position, transform.position) < DogDetectionrange){
                DogToChase = d;
                return true;
              }
          }
      }
      return false;
  }
    
    void Start()
    {
        //We have nave points that  allow for the ai to go to certain points
        navPoints = GameObject.FindGameObjectsWithTag("navpoint");
        aI = GetComponent<UnityStandardAssets.Characters.ThirdPerson.AICharacterControl>();
        childrenRend = GetComponentsInChildren<Renderer>();
        //Set initial state
        SetState(new PatrolState(this));
    }

    // Update is called once per frame
    void Update()
    {
        currentState.CheckTransitions();
        currentState.Act();

    }
    public void SetState(State state){
        if(currentState != null ){
            currentState.OnStateExit();
        }
        currentState = state;
        gameObject.name = "AI agent in state" + state.GetType().Name;
        if (currentState != null ){
            currentState.OnStateEnter();
        }
    }

}
