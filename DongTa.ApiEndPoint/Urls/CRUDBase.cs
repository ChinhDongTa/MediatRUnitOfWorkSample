namespace DongTa.ApiEndPoint.Urls;

public static class CRUDBase {

    public static string GetOne(string controllerName, int entityId)
        => $"{controllerName}/GetOne/{entityId}";

    public static string GetAll(string controllerName)
       => $"{controllerName}/GetAll";

    public static string Delete(string controllerName, int entityId)
       => $"{controllerName}/Delete/{entityId}";

    public static string Edit(string controllerName)
      => $"{controllerName}/Edit";
}