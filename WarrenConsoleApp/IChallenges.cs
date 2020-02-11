using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarrenConsoleApp
{
    public interface IChallenges
    {
        void GetChallengeById(int id);

        void Display(Challenges entity);
        Challenges LoadData();
    
        void AddChallengeToList(Challenges entity);

    }
}
