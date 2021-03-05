using System;
using System.Collections.Generic;
using UnityEngine;

public class TakeSword : QuestPhaseListener
{
    private RootMotionControlScript player_script;
    public override void _action()
    {
        player_script = gameObject.GetComponent<RootMotionControlScript>();
        if (player_script)
        {
            player_script.hasSword = false;
            player_script.sheath();
        }
        else Debug.Log("Could not find RootMotionControlScript");
    }
}