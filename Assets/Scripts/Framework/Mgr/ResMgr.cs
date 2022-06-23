using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResMgr
{
    private static ResMgr _inst;
    public static ResMgr inst
    {
        get {
            if (_inst == null)
            {
                _inst = new ResMgr();
            }
            return _inst; 
        }
    }

    public void load()
    {

    }
}
