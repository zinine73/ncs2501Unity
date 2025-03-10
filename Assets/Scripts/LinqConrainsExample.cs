using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

class Avengers
{
    public string Name { get; set; }
    public string[] Weapon { get; set; }
}

public class LinqConrainsExample : MonoBehaviour
{
    List<Avengers> avengers = new List<Avengers>
    {
        new Avengers { Name = "Iron Man", Weapon = new string[] {"Mk.01", "Mk.44", "Mk.85"}},
        new Avengers { Name = "Thor", Weapon = new string[] {"Mjolnir", "Storm Breaker"}},
        new Avengers { Name = "Captain America", Weapon = new string[] {"Mjolnir", "Shield"}}
    };

    void Start()
    {
        // All
        IEnumerable<string> names = from hero in avengers
                            where hero.Weapon.All(item => item.Length == 5)
                            select hero.Name;
        //Debuglog(names);

        // Any
        names = from hero in avengers
                where hero.Weapon.Any(item => item.StartsWith("M"))
                select hero.Name;
        //Debuglog(names);

        // Contains
        names = from hero in avengers
                where hero.Weapon.Contains("Mjolnir")
                select hero.Name;
        Debuglog(names);
    }

    private void Debuglog(IEnumerable q)
    {
        foreach(var str in q)
        {
            Debug.Log(str);
        }
    }
}
