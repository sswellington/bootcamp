using System.Collections.Generic;

using Serie.Interface;

namespace Serie
{
    public class Repository : IRepository<Serie>
    {
        private List<Serie> record = new List<Serie>();
        public Serie getId(int id)
        {
            return record[id];
        }

        public void update(int id, Serie entity)
        {
            record[id] = entity;
        }

        public void delete(int id)
        {
            record.Remove(getId(id));
        }

        public void insert(Serie entity)
        {
            record.Add(entity);
        }

        public List<Serie> list()
        {
            return record;
        }

        public int nextId()
        {
            return record.Count;
        }
    }
}