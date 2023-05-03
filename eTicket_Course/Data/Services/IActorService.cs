using eTicket_Course.Models;

namespace eTicket_Course.Data.Services

{
    public interface IActorService
    {
        Task<IEnumerable<Actor>> GetAllAsync();
        Task<Actor> GetByIdAsync(int id);
        Task AddAsync(Actor actor);
        Actor Update(int id, Actor newActor);
        void Delete(int id);
    }
}
