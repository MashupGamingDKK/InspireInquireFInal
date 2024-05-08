using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class promptDetail : MonoBehaviour
{

    public int roles;
    public int tasks;
    public int formats;
    public bool match = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (((tasks == formats) && tasks == roles) && tasks != 0){
            match = true;
        }
        else
        {
            match = false;
        }
    }

    public void setRole(int role)
    {
        roles = role;
     
    }

    public void setTask(int task)
    {
        tasks = task;
        
    }

    public void setFormat(int format)
    {
        formats = format;
       
    }
}
