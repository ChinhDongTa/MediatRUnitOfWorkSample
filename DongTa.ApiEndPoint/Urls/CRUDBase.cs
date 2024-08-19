namespace DongTa.ApiEndPoint.Urls;

public static class CRUDBase {

    public static string GetOne(string controllerName, int entityId)
        => $"{controllerName}/One/{entityId}";

    public static string GetAll(string controllerName)
       => $"{controllerName}/All";

    public static string Delete(string controllerName, int entityId)
       => $"{controllerName}/Delete/{entityId}";

    public static string Edit(string controllerName)
      => $"{controllerName}/Edit";
}