﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Observe
{
    public class ConstelObsData
    {
        public string name;
        public List<int> charas;
        public Dictionary<int, float> charWeights;

        public ConstelObsData()
        {
            charas = new List<int>();
            charWeights = new Dictionary<int, float>();
        }

        public ConstelObsData(string n)
        {
            name = n;
            charas = new List<int>();
            charWeights = new Dictionary<int, float>();
        }

        public void AddCharacter(int charKey, float charWeight)
        {
            charas.Add(charKey);
            charWeights.Add(charKey, charWeight);
        }
    }
}