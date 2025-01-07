namespace LiamMotorApp.Website.Services.Interfaces;

public interface IApiIntegrationService
{
  Task<T?> GetAsync<T>(string url);
  Task PostAsync<T>(string url, T data);
}
