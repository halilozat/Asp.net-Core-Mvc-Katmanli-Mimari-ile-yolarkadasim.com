using System;
using System.Collections.Generic;
using System.Text;
using YolArkadasim.Shared.Entities.Abstract;

namespace YolArkadasim.Entities.Concrete
{
    public class Comment:EntityBase,IEntity
    {
        public string Text { get; set; }
        public int JoruneyId { get; set; }
        public Journey Journey { get; set; } //bir yorum bir tane yolculuğa sahip olmak zorunda.
    }
}
