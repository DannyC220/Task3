﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_POE_task_3
{
    class Map
    {
        public const int SIZE = 20;
        public int mapWidth = 20;
        public int mapHeight = 20;

        Unit[] units;
        
        Building[] buildings;

        string[,] map;
        string[] factions = { "A-Team", "B-Team", "N-Team" };

        int numUnits;
        int numBuildings;

        public Map(int numUnits, int numBuildings, int width, int height )
        {
            this.numUnits = numUnits;
            this.numBuildings = numBuildings;
            mapWidth = width;
            mapHeight = height;
            Reset();
        }


        public Unit[] Units
        {
            get
            {
                return units;
            }

        }

        

 
        public Building[] Buildings
        {
            get { return buildings; }
        }

        public int Size
        {
            get { return SIZE; }
        }

        public int MapWidth
        {
            get { return mapWidth; }
        }

        public int MapHeight
        {
            get { return mapHeight; }
        }

        private void InitializeUnits()
        {
            units = new Unit[numUnits];

            for (int i = 0; i < units.Length; i++)
            {
                int x = GameEngine.random.Next(0, mapWidth);
                int y = GameEngine.random.Next(0, mapHeight);
                int factionlndex = GameEngine.random.Next(0, 3);
                int unitType = GameEngine.random.Next(0, 3);

                while (map[x, y] != null)
                {
                    x = GameEngine.random.Next(0, mapWidth);
                    y = GameEngine.random.Next(0, mapHeight);
                }

                if (unitType == 0 )
                {
                    units[i] = new MeleeUnit(x, y, factions[factionlndex]);
                }

                else if (unitType == 1 )
                {
                    units[i] = new RangedUnit(x, y, factions[factionlndex]);
                }

                else if (unitType == 2)
                {
                    units[i] = new WizardUnit(x, y, factions[2]);
                }
                map[x, y] = units[i].Faction[0] + "/" + units[i].Symbol;
            }
        }

        private void InitializeBuildings()
        {
            buildings = new Building[numBuildings];

            for (int i = 0; i < buildings.Length; i++)
            {
                int x = GameEngine.random.Next(0, mapWidth);
                int y = GameEngine.random.Next(0, mapHeight);
                int factionlndex = GameEngine.random.Next(0, 2);
                int buildingType = GameEngine.random.Next(0, 2);

                while (map[x, y] != null)
                {
                    x = GameEngine.random.Next(0, mapWidth);
                    y = GameEngine.random.Next(0, mapHeight);

                }
                if (buildingType == 0)
                {
                    buildings[i] = new ResourceBuilding(x, y, factions[factionlndex]);
                }

                else
                {
                    buildings[i] = new FactoryBuilding(x, y, factions[factionlndex]);
                }
                map[x, y] = buildings[i].Faction[0] + "/" + buildings[i].Symbol;
            }
        }

        public void AddUnit(Unit unit)
        {

            Unit[] resizeUnits = new Unit[units.Length + 1];

            for (int i = 0; i < units.Length; i++)
            {
                resizeUnits[i] = units[i];
            }
            resizeUnits[resizeUnits.Length - 1] = unit;
            units = resizeUnits;
        }

        public void AddBuilding(Building building)
        {
            Array.Resize(ref buildings, buildings.Length + 1);
            buildings[buildings.Length - 1] = building;
        }

        public void UpdateMap()
        {
            for (int y = 0; y < mapHeight; y++)
            {
                for (int x = 0; x < mapWidth; x++)
                {
                    map[x, y] = "  ";

                }
            }

            foreach (Unit unit in units)
            {
                map[unit.X, unit.Y] = unit.Symbol + "|" + unit.Faction[0];
            }

            //foreach(WizardUnit wizard in wizards)
            //{
            //    map[wizard.X, wizard.Y] = wizard.Symbol + "|" + wizard.Faction[0];
            //}

            foreach (Building building in buildings)
            {
                map[building.X, building.Y] = building.Symbol + "|" + building.Faction[0];

            }
        }

        public string GetMapDisplay()
        {
            string mapString = "";
            for (int y = 0; y < mapHeight; y++)
            {
                for (int x = 0; x < mapWidth; x++)
                {
                    mapString += map[x, y];
                }
                mapString += "\n";
            }
            return mapString;
        }

        public void Clear()
        {
            units = new Unit[0];
            buildings = new Building[0];
        }

        public void Reset()
        {
            map = new string[mapWidth, mapHeight];
            InitializeUnits();
            InitializeBuildings();
            UpdateMap();
        }
    }
}
