using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class Inheritance : MonoBehaviour
{
    public List<Person> persons = new List<Person>();

    private void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Student student = new Student();
            persons.Add(student);

            Solider solider = new Solider();
            persons.Add(solider);
        }
    }

    public void AllMove()
    {
        foreach (var person in persons)
        {
            person.Walk();
        }
    }
}
