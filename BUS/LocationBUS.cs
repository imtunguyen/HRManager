using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LocationBUS
    {
        public LocationDAO locaDao;
        public LocationBUS()
        {
            locaDao = LocationDAO.getInstance();
        }
        public List<Location> GetAll()
        {
            return locaDao.GetAll();
        }
        public Location getById(int id)
        {
            return locaDao.GetById(id);
        }
    }
}