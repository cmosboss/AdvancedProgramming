using System;

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
    /// MainApp startup class for Real-World 
    /// Memento Design Pattern.
    /// </summary>
    class Originator : MonoBehaviour
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        /// 
        int pointer = 0;
        List<StateTaker> mem = new List<StateTaker>();
        UGameState s = new UGameState();


        void Start()
        {

        }
        void Update() 
        {
            if (Input.GetKeyDown("s")) 
            {
                // Save saved state
                saveScene();
            }
            if (Input.GetKeyDown("l"))
            {
                // Restore saved state

                loadScene();
            }

        }

        public void saveScene() 
        {
            StateTaker m = new StateTaker();

            GameObject player = GameObject.FindWithTag("Player");
            s.Name = player.gameObject.name;
            s.playerX = player.transform.position.x;
            s.playerY = player.transform.position.y;
            var myGameObjects = GameObject.FindGameObjectsWithTag("Enemy");
            string myGameObjectsString = "";
            foreach (GameObject myGameObject in myGameObjects) 
            {
                string obj = "";
                obj = obj+myGameObject.name.ToString()+"|";
                obj = obj + myGameObject.transform.position.x.ToString() + "|";
                obj = obj + myGameObject.transform.position.y.ToString() + "|";
                obj = obj + myGameObject.transform.rotation.ToString() + "|";
                obj = obj + myGameObject.transform.localScale.ToString() + "|";
                myGameObjectsString = myGameObjectsString + obj;
            }
            s.gameObj = myGameObjectsString;

            var myGameObjects2 = GameObject.FindGameObjectsWithTag("dodad");
            string myGameObjectsString2 = "";
            foreach (GameObject myGameObject in myGameObjects2)
            {
                string obj = "";
                obj = obj + myGameObject.name.ToString() + "|";
                obj = obj + myGameObject.transform.position.x.ToString() + "|";
                obj = obj + myGameObject.transform.position.y.ToString() + "|";
                obj = obj + myGameObject.transform.rotation.ToString() + "|";
                obj = obj + myGameObject.transform.localScale.ToString() + "|";
                myGameObjectsString2 = myGameObjectsString2+ obj;
            }
            s.gameObj = s.gameObj+myGameObjectsString2;

            // Store internal state
            m.Memento = s.SaveMemento();
            mem.Add(m);
            pointer++;
        }
        public void loadScene() 
        {
            if (pointer == 0)
            {
                Application.LoadLevel("TestScene");
            }
            else 
            {
                StateTaker m = mem[pointer - 1];
                s.RestoreMemento(m.Memento);
                pointer = pointer - 1;    
            }

        }
    }

    /// <summary>
    /// The 'Originator' class
    /// </summary>
    class UGameState : MonoBehaviour
    {
        private string _name;
        private string _gameObj;
        private string _phone;
        private float _playerX;
        private float _playerY;

        // Gets or sets name
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                Debug.Log("Name:  " + _name);
            }
        }

        // Gets or sets gameObjs
        public string gameObj
        {
            get { return _gameObj; }
            set
            {
                _gameObj = value;
                Debug.Log("Game Objects:  " + _gameObj);
            }
        }

        // Gets or sets playerX
        public float playerX
        {
            get { return _playerX; }
            set
            {
                _playerX = value;

                Debug.Log("playerX: " + _playerX);
            }
        }

        // Gets or sets playerY
        public float playerY
        {
            get { return _playerY; }
            set
            {
                _playerY = value;

                Debug.Log("playerY: " + _playerY);
            }
        }

        // Stores memento
        public Memento SaveMemento()
        {
            Debug.Log("\nSaving state --\n");
            return new Memento(_name, _gameObj, _playerX, _playerY);
        }

        // Restores memento
        public void RestoreMemento(Memento memento)
        {
            Debug.Log("\nRestoring state --\n");
            this.Name = memento.Name;
            this.gameObj = memento.gameObj;
            this.playerX = memento.playerX;
            this.playerY = memento.playerY;
            GameObject player = GameObject.FindWithTag("Player");
            player.transform.position = new Vector3(memento.playerX,memento.playerY,0);
            var myGameObjects = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject myGameObject in myGameObjects)
            {
                Destroy(myGameObject.gameObject);
            }
            var myGameObjects2 = GameObject.FindGameObjectsWithTag("dodad");
            foreach (GameObject myGameObject in myGameObjects2)
            {
                Destroy(myGameObject.gameObject);
            }
            string[] enemies = memento.gameObj.Split('|');
            int objectNum = enemies.Length - 1;
            objectNum = objectNum / 5;

            int partCounter = 0;
            for (int i = 0; i < objectNum; i++)
            {
                GameObject enemey = Instantiate(Resources.Load(enemies[partCounter])) as GameObject;
                partCounter++;
                float x = float.Parse(enemies[partCounter]);
                partCounter++;
                float y = float.Parse(enemies[partCounter]);
                partCounter++;
                enemey.transform.position = new Vector3(x, y, 0);
                enemies[partCounter] = enemies[partCounter].Replace("(", "");
                enemies[partCounter] = enemies[partCounter].Replace(")", "");
                string[] rotations = enemies[partCounter].Split(',');
                float rotx = float.Parse(rotations[0]);
                float roty = float.Parse(rotations[1]);
                float rotz = float.Parse(rotations[2]);
                float rotw = float.Parse(rotations[3]);
                enemey.transform.rotation = new Quaternion(rotx,roty,rotz,rotw);
                partCounter++;

                enemies[partCounter] = enemies[partCounter].Replace("(", "");
                enemies[partCounter] = enemies[partCounter].Replace(")", "");
                string[] scales = enemies[partCounter].Split(',');
                float scalex = float.Parse(scales[0]);
                float scaley = float.Parse(scales[1]);
                float scalez = float.Parse(scales[2]);
                enemey.transform.localScale = new Vector3(scalex, scaley, scalez);
                partCounter++;

        
                enemey.gameObject.name = enemies[partCounter-5];
                if (enemey.gameObject.name == "DoDads/Crate") 
                {
                    enemey.gameObject.tag = "dodad";

                }
                else
                {
                    enemey.gameObject.tag = "Enemy";
                }

            }
            Debug.Log("Objects Restored"+objectNum);




        }
    }

    /// <summary>
    /// The 'Memento' class
    /// </summary>
    class Memento
    {
        private string _name;
        private string _gameObj;
        private float _playerX;
        private float _playerY;


        // Constructor
        public Memento(string name, string gameObj, float playerX, float playerY)
        {
            this._name = name;
            this._gameObj = gameObj;
            this._playerX = playerX;
            this._playerY = playerY;

        }

        // Gets or sets name
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // Gets or set gameObj
        public string gameObj
        {
            get { return _gameObj; }
            set { _gameObj = value; }
        }

        // Gets or sets playerX
        public float playerX
        {
            get { return _playerX; }
            set { _playerX = value; }
        }
        // Gets or sets playerY
        public float playerY
        {
            get { return _playerY; }
            set { _playerY = value; }
        }
    }

    /// <summary>
    /// The 'Caretaker' class
    /// </summary>
    class StateTaker
    {
        private Memento _memento;

        // Property
        public Memento Memento
        {
            set { _memento = value; }
            get { return _memento; }
        }
    }


