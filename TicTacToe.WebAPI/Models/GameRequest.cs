﻿namespace TicTacToe.WebAPI.Models
{
    public class GameRequest
    {
        public Guid GameId { get; set; }

        public GameMove GameMove { get; set; }
    }
}
