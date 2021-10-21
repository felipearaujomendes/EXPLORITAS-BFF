using System;

namespace Exploritas.Domain.Entities
{
    public class Entity
    {
        protected Entity()
        {
        }

        public int Id { get; private set; }
    }
}
