﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Homework4.Classes
{
    public class Dog
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Race { get; set; }

        public string Eat()
        {
            return $"{Name} the {Race} is now eating";
        }

        public string Play()
        {
            return $"{Name} the {Race} is now Playing";
        }
        public string ChasingTail()
        {
            return $"{Name} which is a { Color} {Race} is now chasing it's tail";
        }
    }
}
