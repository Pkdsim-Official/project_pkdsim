using System;
using UnityEngine;

namespace Project_Pkdsim.Pkpedia.Npc.Database.Modules.Noivern
{
    public class NoivernDex : MonoBehaviour
    {
        // Update is called once per frame
        private void Update()
        {
            Pkpedia_link();
        }

        public void Pkpedia_link()
        {
            Noivern();
        }

        private void Noivern()
        {
            Console.WriteLine(" this will be in a later version");
            Console.WriteLine("Personality: ");
            Console.WriteLine("Parental Relationship: ");
            Console.WriteLine("gender: female ");
            Console.WriteLine("Backstory: ");
        }
    }
}