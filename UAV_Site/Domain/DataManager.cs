using UAV_Site.Domain.Repositories.Abstract;

namespace UAV_Site.Domain
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }
        public IServiceItemRepository ServiceItem { get; set; }
        public DataManager(ITextFieldsRepository textFieldsRepository, IServiceItemRepository serviceItemRepository)
        {
            TextFields = textFieldsRepository;
            ServiceItem = serviceItemRepository;
        }
    }
}
