using Sep.BL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sep.BL.Repositories
{
    public interface IRepostiory<T, TKey>
    {
        void Create(T t);
        void Update(T t);

        void Delete(T t);

        void Get(TKey key);
    }

    public interface IUserRepository: IRepostiory<User, long>
    {

    }

    public interface IMessageRepository : IRepostiory<Message, long>
    {
        IList<Message> GetMessages(long roomId);
    }
    public interface IRoomRepository : IRepostiory<Room, long>
    {
        IList<Room> GetRooms(long userId);
    }
}
