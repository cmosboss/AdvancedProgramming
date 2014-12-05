using UnityEngine;
using System;
using System.Collections.Generic;


public class Factory : MonoBehaviour
{
    void Start()
    {
        create();
    }

    void create() 
    {
        LevelFactory MyFactory = new LevelFactory();
        int rand = UnityEngine.Random.Range(1, 10);
        Level MyLevel;
        if (rand < 5)
        {
            MyLevel = MyFactory.create("Basic");
        }
        else if (rand > 5 && rand < 9)
        {
            MyLevel = MyFactory.create("Env");
        }
        else
        {
            MyLevel = MyFactory.create("Boss");
        }
        MyLevel.create();
        String MyType = MyLevel.Type();
        if (MyType == "Basic")
        {
            basic();
        }
        if (MyType == "Boss")
        {
            boss();
        }
        if (MyType == "Env")
        {
            env();
        }
    }

    public void destroyAll() 
    {
        foreach (GameObject o in GameObject.FindObjectsOfType<GameObject>())
        {
            if (o.tag == "Enemy" || o.tag == "dodad") 
            {
                Destroy(o);

            }
        }
        create();
 
    }

    public class LevelFactory
    {
        public Level create(String type)
        {
            if (type == "Basic")
            {
                return new Basic();
            }
            else if (type == "Env")
            {
                return new Env();
            }
            else if (type == "Boss")
            {
                return new Boss();
            }
            return null;
        }
    }

    public interface Level
    {
        void create();
        String Type();
    }

    public class Env : Level
    {
        public void create()
        {
            Debug.Log("Creating Environmental Level");
        }
        public String Type()
        {
            return "Env";
        }
    }
    public class Boss : Level
    {
        public void create()
        {
            Debug.Log("Creating Boss Level");
        }
        public String Type()
        {
            return "Boss";
        }
    }
    public class Basic : Level
    {
        public void create()
        {
            Debug.Log("Creating Basic Level");
        }
        public String Type() 
        {
            return "Basic";
        }
    }

    void Update() { }

    public void basic()
    {
        gameObject.AddComponent<BasicLevel>();
    }

    public void boss()
    {
        gameObject.AddComponent<BossLevel>();
    }
    public void env()
    {
        gameObject.AddComponent<EnvLevel>();
    }

}
