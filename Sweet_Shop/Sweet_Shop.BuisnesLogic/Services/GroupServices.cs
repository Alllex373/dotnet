using Sweet_Shop.Models.Datamodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweet_Shop.BuisnesLogic.Services
{
    public interface IGroupServices
    {
        List<Group> GetList();
    }

    public class GroupServices : IGroupServices
    {
        public List<Group> GetList()
        {
            var groupList =
               new List<Group>
               {
                    new Group
                    {
                        Id = 1,
                        Name = "Овощи"
                    },
                    new Group
                    {
                        Id = 2,
                        Name = "Фрукты"
                    }
               };

            //return RedirectToAction("Add");
            return groupList;
        }
    }
}
