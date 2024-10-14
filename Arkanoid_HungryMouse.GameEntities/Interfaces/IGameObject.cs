﻿namespace Arkanoid_HungryMouse.GameEntities.Interfaces
{
    /// <summary>
    /// Игровой объект
    /// </summary>
    public interface IGameObject
    {
        /// <summary>
        /// Координата по ширине
        /// </summary>
        int X { get; set; }

        /// <summary>
        /// Координата по высоте
        /// </summary>
        int Y { get; set; }

        /// <summary>
        /// Ширина объекта
        /// </summary>
        int Width { get; set; }

        /// <summary>
        /// Высота объекта
        /// </summary>
        int Height { get; set; }

        /// <summary>
        /// Разрушен ли объект
        /// </summary>
        bool Destroyed { get; set; }
    }
}
