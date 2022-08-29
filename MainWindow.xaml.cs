using System.Windows;
using Microsoft.Toolkit.Uwp.Notifications;
using Windows.UI.Notifications;

namespace IconColorIInversion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ToastNotifierCompat? _notifier;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _notifier ??= ToastNotificationManagerCompat.CreateToastNotifier();

            var builder = new ToastContentBuilder()
                .AddText("Some tilte")
                .AddText("Some description")
                .SetToastDuration(ToastDuration.Short)
                .SetToastScenario(ToastScenario.Default);

            var notification = new ToastNotification(builder.GetXml());
            _notifier.Show(notification);
        }
    }
}
