using UAV_Site.Domain.Entities;
using UAV_Site.Domain.Repositories.Abstract;

namespace UAV_Site.Domain.Repositories.EntityFramework
{
    public class EFServiceItemsRepository : IServiceItemRepository
    {
        public void DeleteServiceItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public ServiceItem GetServiceItemById(Guid id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<ServiceItem> GetServiceItems()
        {
            throw new NotImplementedException();
        }

        public void SaveServiceItem(ServiceItem entity)
        {
            throw new NotImplementedException();
        }
    }
}
