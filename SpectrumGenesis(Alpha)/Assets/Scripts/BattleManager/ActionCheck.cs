using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionCheck {

    public static void Check(CharClass Player, CharClass Enemy, TurnManager Manager)
    {

        if (Player.ActionUsed == true && Enemy.ActionUsed == true)
        {
            //call enmd turn sequence
        }
        else if (Player.ActionUsed == true)
        {
            //call enemyTurn
        }
        else if (Enemy.ActionUsed == true)
        {
            //call playerTurn
        }
        else if (Player.ActionUsed ==false && Enemy.ActionUsed == false)
        {
            //call startTunrSequence
        }

    }

}
