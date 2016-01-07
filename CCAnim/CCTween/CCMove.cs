﻿//*********************************************************************
//
//					   ScriptName 	: CCMove
//
//                     Project	    : CCAnim                                 
//                                 
//*********************************************************************
using UnityEngine;
using System.Collections;
public class CCMove : CCActionTime
{

    protected Vector3 StartPos;
    protected Vector3 EndPos;
    protected Vector3 Dictance;

    public static CCMove Create(Vector3 startPos, Vector3 endPos, float time)
    {
        return  new CCMove()
        {
            StartPos    = startPos,
            EndPos      = endPos,
            _duration   = time,
            Dictance    = (endPos - startPos)/time
        };
    }
    protected override void StartRun()
    {
        _target.position = StartPos;
    }

    protected override void OnUpdate(float ratio)
    {
        _target.position += Dictance * ratio;
    }

    protected override void EndRun()
    {
        _target.position = EndPos;
    }
}