using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistence.Repositories;

//IQuery:Ilgili domain nesnesine .(nokta) diyerek sql sorgusu yazmamizi saglar.

public interface IQuery<T>
{
    IQueryable<T> Query();
}