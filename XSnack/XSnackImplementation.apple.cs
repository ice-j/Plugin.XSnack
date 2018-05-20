using System;
using System.Threading.Tasks;
using System.Windows.Input;
using TTGSnackBar;

namespace Plugin.XSnack
{
    /// <summary>
    /// iOS Implementation for Plugin.XSnack
    /// </summary>
    public class XSnackImplementation : IXSnack
    {
        /// <summary>
        /// Displays a message and an optional action button within a snackbar
        /// </summary>
        /// <param name="message">The message you want to be displayed</param>
        /// <param name="duration">Duration of the snackbar (Default 5 seconds)</param>
        /// <param name="actionText">Text for the action button (optional)</param>
        /// <param name="actionCommand">Callback command for the action button (optional)</param>
        /// <returns></returns>
        public Task ShowMessageAsync(string message, int duration = 5, string actionText = null, ICommand actionCommand = null)
        {
            DisplayMessage(message, duration, actionText, actionCommand);
            return Task.CompletedTask;
        }

        /// <summary>
        /// Displays a message and an optional action button within a snackbar
        /// </summary>
        /// <param name="message">The message you want to be displayed</param>
        /// <param name="duration">Duration of the snackbar (Default 5 seconds)</param>
        /// <param name="actionText">Text for the action button (optional)</param>
        /// <param name="actionCommand">Callback command for the action button (optional)</param>
        /// <returns></returns>
        public void ShowMessage(string message, int duration = 5, string actionText = null, ICommand actionCommand = null)
            => DisplayMessage(message, duration, actionText, actionCommand);

        void DisplayMessage(string message, int duration = 5, string actionText = null, ICommand actionCommand = null)
        {
            var snack = new TTGSnackbar(message)
            {
                Duration = TimeSpan.FromSeconds(duration),
                ActionText = actionText
            };

            if (actionCommand != null)
            {
                snack.ActionBlock = (snackbar) =>
                {
                    if (actionCommand?.CanExecute(null) == true)
                        actionCommand?.Execute(null);
                };
            }

            snack.Show();
        }
    }
}
