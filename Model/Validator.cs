using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.Model
{
    /// <summary>
    /// Содержит методы для валидации полей классов.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверяет, меньше или равно ли значение поле чем значение size.
        /// </summary>
        /// <param name="value">Проверяемое значение поля.</param>
        /// <param name="size">Значение, которое должно быть выше, чем значение поля</param>
        /// <returns>true, если значение поле меньше или равно, чем значение size.</returns>
        /// <exception cref="ArgumentException">Если значение поле выше, чем значение size.</exception>
        public static bool IsShorterOrEqualThan(string value, int size)
        {
            if (value.Length > size)
                throw new ArgumentException($"Значение поле должно быть меньше или равно, чем {size}.");
            else
                return true;
        }

        /// <summary>
        /// Проверяет, раньше ли значение поля, чем сегодняшнее число
        /// </summary>
        /// <param name="value">Проверяемое значение поля</param>
        /// <returns>true, если значение поля раньше сегодняшнего числа</returns>
        /// <exception cref="ArgumentException"></exception>
        public static bool IsEarlierThanToday(DateTime value)
        {
            if (value >= DateTime.Today)
                throw new ArgumentException("Значение поля должно быть раньше сегодняшнего числа.");
            else
                return true;
        }

        /// <summary>
        /// Проверяет, удолетворяет ли значение поля условиям: первый символ должен быть равен '+', а остальные должны быть цифрами.
        /// </summary>
        /// <param name="value">Проверяемое значение поля</param>
        /// <returns>true, если первый символ равен '+', а остальные - цифры.</returns>
        /// <exception cref="ArgumentException"></exception>
        public static bool IsPhoneNumber(string value)
        {
            if (value[0] != '+')
                throw new ArgumentException("Первый символ в значении поля должен быть равен '+', а остальные должны быть цифрами.");
            else
                for (int i = 1; i < value.Length; i++)
                {
                    if (!Char.IsDigit(value[i]))
                        throw new ArgumentException("Первый символ в значении поля должен быть равен '+', а остальные должны быть цифрами.");
                }
            return true;
        }
    }
}