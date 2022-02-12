using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndLiterals : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    string name = "Isaac";
    print("Hello, " + "my name is " + name + ". "); 

    string teamates = "Jonathan, Quincy, and Vijay";
    print("My teamates are, " + teamates + ". ");

    string PersonalMessage = "I would like to say that I will be looking forward to working with ";
    print(PersonalMessage + teamates + " in the future. ");  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
