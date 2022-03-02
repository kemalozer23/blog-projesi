namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        IEnumerable<T> GetListAll();
        T GetById(int id);
    }
}