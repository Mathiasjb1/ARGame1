using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isDoorDownBool : MonoBehaviour
{
    public triggerScript1 boolInHere1;
    public triggerScript1 boolInHere2;
    public triggerScript1 boolInHere3;

    public void isDOORDOWNF()
    {
        bool isDoorDown1 = boolInHere1.isDoorDown;

        isDoorDown1 = isDoorDown1 = false;

        bool isDoorDown2 = boolInHere1.isDoorDown;

        isDoorDown2 = isDoorDown2 = false;

        bool isDoorDown3 = boolInHere1.isDoorDown;

        isDoorDown3 = isDoorDown3 = false;
    }

    public void isDOORDOWNT()
    {
        bool isDoorDown1 = boolInHere1.isDoorDown;

        isDoorDown1 = isDoorDown1 = true;

        bool isDoorDown2 = boolInHere1.isDoorDown;

        isDoorDown2 = isDoorDown2 = true;

        bool isDoorDown3 = boolInHere1.isDoorDown;

        isDoorDown3 = isDoorDown3 = true;
    }

}
