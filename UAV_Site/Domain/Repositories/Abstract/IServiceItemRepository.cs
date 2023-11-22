using UAV_Site.Domain.Entities;

namespace UAV_Site.Domain.Repositories.Abstract
{
    public interface IServiceItemRepository
    {
        IQueryable<ServiceItem> GetServiceItems();
        ServiceItem GetServiceItemById(Guid id);
        void SaveServiceItem(ServiceItem entity);
        void DeleteServiceItem(Guid id);
    }
}
