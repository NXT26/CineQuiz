using System;

namespace cinequiz.Models
{
    public class QuizQuestion
    {
        public string Question { get; set; } = string.Empty; // Инициализация пустой строкой
        public string[] Answers { get; set; } = Array.Empty<string>(); // Инициализация пустым массивом
        public int CorrectAnswerIndex { get; set; }
    }
}