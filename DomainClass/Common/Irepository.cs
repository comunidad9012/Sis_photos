using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClass.Common


{
    //// ESTO HACE COMPATIBLE A TODOS LOS SERVIDORES 

    //// ENTONCES LA T SIGNIFICA QUE ES GENERICO, ENTITY NO ES OBLIGATORIO, PUEDEN SER CLASES TAMBIEN.
    //public interface Irepository<TEntity> where TEntity : 
    //    BaseEntityClass, new()
    //{
    //    /// <summary>
    //    /// Metodo usado para insertar un registro en la base de datos
    //    /// </summary>
    //    /// <param name="entity"></param>
    //    /// <returns></returns>
    //    Task Insert(TEntity entity);

    //    Task Delete(TEntity entity);

    //    Task Update(TEntity entity);

    //    Task<IEnumerable<TEntity>> GetAll();

    //    Task<TEntity> GetById(int id);

    //    Task<int> SaveChange();

    //}
}
