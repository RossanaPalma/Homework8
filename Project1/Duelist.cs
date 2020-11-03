using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    class Duelist
    {
        private String _name;
        private double _accuracy;
        private bool _alive;
        private Random rand;


        public Duelist(string name) // constructor 
        {
            _name = name;
        }

        public Duelist(double accuracy) // constructor
        {
            _accuracy = accuracy;
        }
                

        public string Name { get => _name; set => _name = value; }
        public double Accuracy { get => _accuracy; set => _accuracy = value; }
        public bool Alive { get => _alive; set => _alive = value; }

        public void ShootAtTarget(Duelist duel)
        {
            if(rand.NextDouble() < _accuracy)
            {
                duel.Alive = false;
            }
        }

    }
    }


