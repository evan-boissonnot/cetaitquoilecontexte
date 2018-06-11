namespace CetaitQuoiLeContexte.Core.Interfaces.Data
{
    public interface IAppSettings
    {
        /// <summary>
        /// Nombre d'items chargés, par défaut
        /// </summary>
        int ContextNbItems { get; set; }

        /// <summary>
        /// Url de l'api
        /// </summary>
        string ApiUrl { get; set; }
    }
}