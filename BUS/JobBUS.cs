using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class JobBUS
    {
        JobDAO dao;
        public JobBUS() 
        {
            dao = JobDAO.getInstance();
        }
        public bool Add(Job dto)
        {
            return dao.Add(dto);
        } 
        public bool Update(int id, Job dto)
        {
            return dao.Update(id, dto);
        }
        public bool Delete(int id)
        {
            return dao.Delete(id);
        }
        public Job GetById(int id)
        {
            return dao.GetById(id);
        }
        public List<Job> GetAll()
        {
            return dao.GetAll();
        }
    }
}
