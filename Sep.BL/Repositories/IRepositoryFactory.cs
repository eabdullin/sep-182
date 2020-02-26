using System;
using System.Collections.Generic;
using System.Text;

namespace Sep.BL.Repositories
{
    public interface IRepositoryFactory
    {
        IRoomRepository GetRooms();
    }
}
