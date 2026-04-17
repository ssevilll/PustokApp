using PustokAppMvc.Data;

namespace PustokAppMvc.Services
{
    public class LayoutService(AppDbContext context)
    {
        public Dictionary<string, string> GetSettings()
        {
            return context.Settings.ToDictionary(s => s.Key, s => s.Value);
        }
    }
}
