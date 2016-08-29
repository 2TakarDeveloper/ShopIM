using System.Collections.Generic;
using System.Linq;
using ShopIM.Entity;

namespace ShopIM.DAL
{
    public class NotificationContext
    {

        public List<Notification> GetLogs()
        {
            using (var context = new DatabaseContext())
            {
                return (from notification in context.Notifications select notification).ToList();

            }
        }

        public void Remove(List<Notification> notifications)
        {
            using (var context = new DatabaseContext())
            {
                foreach (var notification in notifications)
                {
                    var item = context.Set<Notification>().FirstOrDefault(r => r.Sl == notification.Sl);
                    if (item == null) continue;
                    context.Notifications.Remove(item);
                    context.SaveChanges();
                }
            }
        }
    }
}
