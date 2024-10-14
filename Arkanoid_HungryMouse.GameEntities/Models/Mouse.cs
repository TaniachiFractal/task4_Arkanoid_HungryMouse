﻿using Arkanoid_HungryMouse.GameEntities.Interfaces;

namespace Arkanoid_HungryMouse.GameEntities.Models
{
    /// <summary>
    /// <see cref="IGameObject"/> мыши, который прыгает по экрану 
    /// </summary>
    public class Mouse : IGameObject
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool Destroyed { get; set; }
    }
}
