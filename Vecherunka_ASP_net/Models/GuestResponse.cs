﻿using System.ComponentModel.DataAnnotations;

namespace Vecherunka_ASP_net.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="Пожалуйста, введите свое имя")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Пожалуйста, введите email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage ="Вы ввели некорректный email")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Пожалуйста, введите телефон")]
        public string Phone { get; set; }

        [Required(ErrorMessage ="Пожалуйста, укажите, примите ли участие в вечеринке")]
        public bool? WillAttend { get; set; }

    }
}
