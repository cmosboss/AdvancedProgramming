using UnityEngine;
using System.Collections;

class Originator : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Invoke("save",1.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void save() 
    {
        Debug.Log("no you");
    }
    private string state;
    // The class could also contain additional data that is not part of the
    // state saved in the memento.

    public void Set(string state) 
    {
        Debug.Log("Originator: Setting state to " + state);
        this.state = state;
    }

    public Memento SaveToMemento() 
    {
        Debug.Log("Originator: Saving to Memento.");
        return new Memento(state);
    }

    public void RestoreFromMemento(Memento memento) 
    {
        state = memento.SavedState;
        Debug.Log("Originator: State after restoring from Memento: " + state);
    }

    public class Memento 
    {
        public readonly string SavedState;

        public Memento(string stateToSave)  
        {
            SavedState = stateToSave;
        }
    }
}


