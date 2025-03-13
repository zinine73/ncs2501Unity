using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class LinQExample : MonoBehaviour
{
    void Start()
    {
        string[] avengers = {"Iron Man", "Captain America", "Thor",
            "Hulk", "Black Panther", "Spider Man"};

        // OrderBy
        IEnumerable<string> query = from hero in avengers
                                    orderby hero.Length
                                    select hero;
        //Debuglog(query);

        // OrderByDescending
        query = from hero in avengers
                orderby hero.Substring(0, 1) descending
                select hero;
        //Debuglog(query);

        query = from hero in avengers
                orderby hero.Length, hero.Substring(0, 1)
                select hero;
        //Debuglog(query);
        query = from hero in avengers
                orderby hero.Length, hero.Substring(0, 1) descending
                select hero;
        //Debuglog(query);

        // Distinct
        string[] avengers1 = {"Iron Man", "Iron Man", "Captain America", "Thor"};
        query = from hero in avengers1.Distinct()
                select hero;
        //Debuglog(query);

        string[] avengers21 = {"Iron Man", "Captain America", "Thor"};
        string[] avengers22 = {"Iron Man", "Hulk", "Captain America"};
        query = from hero in avengers21.Intersect(avengers22)
                select hero;
        //Debuglog(query);

        query = from hero in avengers
                where hero.Length == 4
                select hero;
        Debuglog(query);
    }

    private void Debuglog(IEnumerable q)
    {
        foreach(var str in q)
        {
            Debug.Log(str);
        }
    }
}
