using System.ComponentModel.DataAnnotations;

namespace ASC.Domain.Common
{
    public abstract class Entity
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        protected Entity(Guid id, bool deleted)
        {
            Id = id;
            Deleted = deleted;
        }

        [Required]
        public Guid Id { get; }

        [Required]
        public bool Deleted { get; }
    }
}
