using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats {

    public Health health;
    public Stamina stamina;

    public Stats() {
        health = new Health();
        stamina = new Stamina(); 
    }
}
