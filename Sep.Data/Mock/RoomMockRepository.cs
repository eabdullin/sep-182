using Sep.BL.Entities;
using Sep.BL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sep.Data.Mock
{
    public class RoomMockRepository : IRoomRepository
    {
        public void Create(Room t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Room t)
        {
            throw new NotImplementedException();
        }

        public void Get(long key)
        {
            throw new NotImplementedException();
        }

        public IList<Room> GetRooms(long userId)
        {
            return new List<Room>()
            {
                new Room()
                {
                    Name = "Dimash"
                }
            };
        }

        public void Update(Room t)
        {
            throw new NotImplementedException();
        }
    }
}
