using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistence.Repositories;

public class Entity<TId>:IEntityTimestamps
{
    public TId Id { get; set; }
    public DateTime CreatedDate { get; set; }

    //Ilk nesne olustugunda UpdatedDate ve DeletedDate girmek zorunda olmadiigmiz icin null olabilir.
    public DateTime? UpdatedDate { get; set; }
    public DateTime? DeletedDate { get; set; }

    public Entity()
    {
        //Ornegin id degeri int verilmisse default olarak 0 atar.
        Id = default;
    }
    public Entity(TId id)
    {
        Id = id;
    }

}
