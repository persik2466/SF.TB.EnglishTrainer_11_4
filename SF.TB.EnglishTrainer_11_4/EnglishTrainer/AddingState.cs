using System;
using System.Collections.Generic;
using System.Text;

namespace SF.TB.EnglishTrainer_11_4
{
    /// <summary>
    /// Структура состояний
    /// </summary>
    public enum AddingState
    {
        Russian, //Русское слово (начало ввода)
        English, //Английское слово
        Theme,   //Тематика
        Finish   //Успешный ввод
    }

}
