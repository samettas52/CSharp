using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.DataAccess
{
    //class => reference type
    //new() => renewable
    //IEntity => take the T type from IEntity interface or take from classes who implements the IEntity interface    
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        //if our interfaces using the same thing then we create a entityrepository . Thats for the stoping code repetitions .
        List<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
