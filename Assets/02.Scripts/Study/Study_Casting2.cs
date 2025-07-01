using System;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;


public class Study_Casting2 : MonoBehaviour
{
    List<Orc> orcs = new List<Orc>();
    List<Goblin> goblins = new List<Goblin>();

    List<Monster> monsters = new List<Monster>();

    private void Start()
    {
        Orc o = new Orc();
        Goblin g = new Goblin();

        // 명시적 형변환 가시성 좋음
        Monster m1 = (Monster) o;
        //Monster m2 = (Monster) g;


        // 암시적 형변환 개발 효율 올라감
        Monster m3 = o;
        // Monster m4 = g;


        monsters.Add(o);
        // monsters.Add(g);
    }
}
