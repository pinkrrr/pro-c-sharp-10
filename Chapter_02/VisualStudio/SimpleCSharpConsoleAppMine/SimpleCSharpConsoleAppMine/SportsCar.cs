﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleCSharpConsoleAppMine
{
    public class SportsCar : Car
    {
        public string GetPetName()
        {
            PetName = "red";
            return PetName;
        }
    }
}