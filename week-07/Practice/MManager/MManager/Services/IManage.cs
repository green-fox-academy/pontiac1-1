using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MManager.Serives
{
    public interface IManage
    {
        void Load();
        void Send();
        void Pay();
        void AddCard();
        void RemoveCard();
        void LockCard();
    }
}
