// See https://aka.ms/new-console-template for more information

using Logging.DispatchProxy;

INotificationService notificationService = new NotificationService();

notificationService = LoggingProxy<INotificationService>.SetProxy(notificationService);

notificationService.Send("message");
notificationService.Checkdelivery(1);
