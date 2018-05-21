using System.Threading.Tasks;
using System.Windows.Input;

namespace Plugin.XSnack
{
    /// <summary>
    /// Interface for registering the Plugin.XSNack with DI
    /// </summary>
    public interface IXSnack
    {
        /// <summary>
        /// Displays a message and an optional action button within a snackbar
        /// </summary>
        /// <param name="message">The message you want to be displayed</param>
        /// <param name="duration">Duration of the snackbar in seconds (Default 3 seconds)</param>
        /// <param name="actionText">Text for the action button (optional)</param>
        /// <param name="actionCommand">Callback command for the action button (optional)</param>
        /// <returns></returns>
        Task ShowMessageAsync(string message, int duration = 3, string actionText = null, ICommand actionCommand = null);

        /// <summary>
        /// Displays a message and an optional action button within a snackbar
        /// </summary>
        /// <param name="message">The message you want to be displayed</param>
        /// <param name="duration">Duration of the snackbar in seconds (Default 3 seconds)</param>
        /// <param name="actionText">Text for the action button (optional)</param>
        /// <param name="actionCommand">Callback command for the action button (optional)</param>
        /// <returns></returns>
        void ShowMessage(string message, int duration = 3, string actionText = null, ICommand actionCommand = null);
    }
}
