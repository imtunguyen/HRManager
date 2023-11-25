using System;
using System.Collections.Generic;
using DAO;
using DTO;

namespace BUS
{
    public class LevelBUS
    {
        private LevelDAO levelDAO;

        public LevelBUS()
        {
            this.levelDAO = new LevelDAO();
        }

        public bool AddLevel(Level level)
        {
            // You can add business logic/validation here before calling the DAO method
            return levelDAO.Add(level);
        }

        public bool UpdateLevel(Level level)
        {
            // You can add business logic/validation here before calling the DAO method
            return levelDAO.Update(level);
        }

        public bool DeleteLevel(int id)
        {
            // You can add business logic/validation here before calling the DAO method
            return levelDAO.Delete(id);
        }

        public List<Level> GetAllLevels()
        {
            // You can add business logic/validation here before calling the DAO method
            return levelDAO.GetAll();
        }

        public Level GetLevelById(int id)
        {
            // You can add business logic/validation here before calling the DAO method
            return levelDAO.GetById(id);
        }
        public int GetMaxLevelId()
        {
            return levelDAO.GetMaxLevelId();
        }

    }
}
