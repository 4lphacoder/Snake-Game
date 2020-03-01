﻿using System;
using System.Collections.Generic;
using System.Text;

using SFML;
using SFML.Window;
using SFML.Graphics;
using SFML.System;

namespace Snake_Game
{
    class SnakeFood
    {
        private Vector2f PositionOfFood;        // 2D vector to store the random position of snake food
        private RectangleShape Pixel = new RectangleShape();    // an elementary box to be plotted as pixel
        private RenderWindow window;
        public void RandomizeFoodPosition()
        {
            Random RandomInt = new Random();
            this.PositionOfFood.X = RandomInt.Next(20, (int)Config.SCREEN_WIDTH - 20);
            this.PositionOfFood.Y = RandomInt.Next(20, (int)Config.SCREEN_HEIGHT - 20);
        }
        public SnakeFood(ref RenderWindow window)      // constructor of this class
        {
            this.window = window;
            Pixel.Size = new Vector2f(Config.PIXEL_WIDTH, Config.PIXEL_HEIGHT);
            RandomizeFoodPosition();
        }

        public Vector2f GetPosition()
        {
            return PositionOfFood;
        }
        public void Draw()
        {
            Pixel.Position = PositionOfFood;
            this.window.Draw(Pixel);
        }
    }
}
