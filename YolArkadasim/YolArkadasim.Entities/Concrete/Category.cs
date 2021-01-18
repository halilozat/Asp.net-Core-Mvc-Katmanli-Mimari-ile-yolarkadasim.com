using System;
using System.Collections.Generic;
using System.Text;
using YolArkadasim.Shared.Entities.Abstract;

namespace YolArkadasim.Entities.Concrete
{
    public class Category:EntityBase,IEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Journey> Journeys { get; set; } //bir kategori birden fazla yolculuğa sahip olabilir.
    }
}
